using CapaDatos.Entidades;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Controllers
{
    public class FacturasNeg
    {
        Facturas fac = new Facturas();
        Clientes cliente = new Clientes();
        Servicios servicio = new Servicios();
        ControlFechasFacturas fechacontrol = new ControlFechasFacturas();
        Cuotas cuotas = new Cuotas();
        Parametros parametros = new Parametros();
        ControlMensualCaja ct = new ControlMensualCaja();
        ControlBancoNeg bn = new ControlBancoNeg();
        public FacturasNeg()
        {
            parametros = parametros.Consultar();
        }
        public DataTable Generar(int idcontrol, ProgressBar psbBar, Label conta)
        {
            return fac.GenerarFacturasConsumo(idcontrol, parametros.MoraConsumo, psbBar, conta);
        }
        public DataTable GenerarAco(int idcontrol, ProgressBar psbBar, Label conta)
        {
            return fac.GenerarFacturasAcometida(idcontrol, parametros.MoraAcometida, psbBar, conta);
        }
        //cosultar a la base de datos y rellenar informacion del formulario
        public Boolean ConsultarFactura(string idfactura, Form contenedor)
        {
            fac.ConsultarFactura(idfactura);
            servicio.IdServicio = fac.IdServicio;
            servicio = servicio.ConsultarServicio();
            cliente.IdCliente = servicio.IdCliente;
            cliente = cliente.ConsultarCliente();
            fechacontrol = fechacontrol.ConsultarControlFecha(fac.IdControlFecha);
            bool encontrado = ct.Consultar();
            contenedor.Controls.Find("lblcliente", true)[0].Text = cliente.Nombres + ", " + cliente.Apellidos;
            contenedor.Controls.Find("lblMora", true)[0].Text = fac.Mora.ToString("$ 00.00");
            contenedor.Controls.Find("lblMonto", true)[0].Text = fac.Saldo.ToString("$ 00.00");
            contenedor.Controls.Find("txbTotalPagar", true)[0].Text = (fac.Saldo + fac.Mora).ToString("00.00");
            contenedor.Controls.Find("txbDescuento", true)[0].Text = fac.Descuento.ToString("00.00");
            contenedor.Controls.Find("lblMes", true)[0].Text = fechacontrol.Mes;
            contenedor.Controls.Find("lblMesesPen", true)[0].Text = GetMesesPendientes(fechacontrol.Mes, fac.ContPendientes);
            return encontrado;
        }
        public string GetNomCLiente()
        {
            return cliente.Nombres + ", " + cliente.Apellidos;
        }
        //funcion a llamar en el formalario de pago;
        public bool procesar(double pagado, double descuento, string empleado)
        {
            //validamos la fecha, esto para cobrar o no el dolar por pago despues de la fecha de vencimiento
            pagado = vencida(pagado);
            double aux = fac.Saldo + fac.Mora;
            if ((pagado - fac.Mora) % cuotas.ConsultarCuota(servicio.IdConsumo, servicio.IdAcometida) == 0)
            {
                if (pagado < aux)
                {
                    return PagoParcial(pagado, descuento, empleado);
                }
                else if (pagado > aux)
                {
                    //validamos si el monto que esta pagando es por cuotas enteras 

                    return PagoAdelantado(pagado, descuento, empleado);

                }
                else
                {
                    return PagoCompleto(pagado, descuento, empleado);
                }
            }
            else { MessageBox.Show("Solo se pueden procesar cuotas enteras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }

        public double vencida(double pagado)
        {
            if (fechacontrol.FechaVencimiento < DateTime.Now)
            {
                if (MessageBox.Show("Desea cobrar mora por pago tardio?", "Ojo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (servicio.IdConsumo != 0)
                    {
                        fac.Comentario = fac.Comentario + "Se cobro $ " + parametros.MoraConsumo + " por pago tardio";
                        fac.Mora = fac.Mora + parametros.MoraConsumo;
                        pagado += parametros.MoraConsumo;
                    }
                    else
                    {
                        fac.Comentario = fac.Comentario + "Se cobro $ " + parametros.MoraAcometida + " por pago tardio;";
                        fac.Mora = fac.Mora + parametros.MoraAcometida;
                        pagado += parametros.MoraAcometida;
                    }
                }
            }
            return pagado;
        }
        public string getMes()
        {
            return fechacontrol.Mes;
        }

        public string GetMesesPendientes(string mes, int pendiente)
        {
            // arreglo para crear la cedena de meses pendientes 
            string[] meses = { "diciembre", "noviembre", "octubre", "septiembre", "agosto", "julio", "junio", "mayo", "abril", "marzo", "febrero", "enero" };
            StringBuilder aux = new StringBuilder();
            int i = fac.ContPendientes;
            //acceder al indice del mes que se esta cobrando en la factura para recorrer desde ahi el arreglo 
            int cont = Array.IndexOf(meses, mes);
            int contPendiente = pendiente;
            while (contPendiente > 0)
            {
                cont++;
                if (cont >= 11)
                {
                    cont = 0;
                    aux.Append(", " + meses[cont]);
                }
                else
                {
                    aux.Append(", " + meses[cont]);
                }
                contPendiente--;
            };
            return !String.IsNullOrEmpty(aux.ToString()) ? aux.ToString().Remove(0, 2) : String.Empty;
        }
        public Boolean PagoCompleto(double pagado, double descuento, string empleado)
        {
            if (descuento > 0)
            {
                fac.Comentario += " se le desconto el valor de $ " + descuento + ";";
                fac.Descuento = descuento;
            }
            fac.EstadoPago = "Cancelado";

            if (fac.Actualzar())
            {
                Movimientos movimientos = new Movimientos();
                movimientos.IdFactura = fac.IdFactura;
                movimientos.IdControlCaja = ct.IdControlCaja;
                movimientos.Concepto = "CANCELACION POR SUMINISTRO DE AGUA SEGUN RECIBOS";
                movimientos.Tipo = "Ingreso";
                movimientos.IdControlCaja = ct.IdControlCaja;
                movimientos.Doc = fac.IdFactura.ToString();
                movimientos.IdFactura = fac.IdFactura;
                movimientos.Empleado = empleado;
                movimientos.IdControlBanco = 0;
                movimientos.IdCliente = servicio.IdCliente;
                movimientos.Fecha = DateTime.Now;
                movimientos.Monto = pagado - descuento;
                return movimientos.Insertar();
            }
            return false;
        }

        public Boolean CancelarBamco (double pagado, double descuento, string empleado,int idbanco)
        {
            if (descuento > 0)
            {
                fac.Comentario += " se le desconto el valor de $ " + descuento + ";";
                fac.Descuento = descuento;
            }
            fac.EstadoPago = "Cancelado";

            if (fac.Actualzar())
            {
                Movimientos movimientos = new Movimientos();
                movimientos.IdFactura = fac.IdFactura;
                movimientos.IdControlCaja = ct.IdControlCaja;
                movimientos.Concepto = "CANCELACION POR SUMINISTRO DE AGUA SEGUN RECIBOS";
                movimientos.Tipo = "Ingreso";
                movimientos.IdControlBanco = idbanco;
                movimientos.Doc = fac.IdFactura.ToString();
                movimientos.IdFactura = fac.IdFactura;
                movimientos.Empleado = empleado;
                movimientos.IdControlBanco = 0;
                movimientos.IdCliente = servicio.IdCliente;
                movimientos.Fecha = DateTime.Now;
                movimientos.Monto = pagado - descuento;
                return movimientos.Insertar();
            }
            return false;
        }
        public Boolean PagoParcial(double pagado, double descuento, string empleado)
        {
            Facturas facParcial = new Facturas();
            Facturas cancelada = new Facturas();
            int cuopagadas = FacturasPagadas(pagado);

            #region creacion y procesamiento de factura con la infromacion de las cuotas pagaas
            if (servicio.IdConsumo > 0) { cancelada.Saldo = pagado - (parametros.MoraConsumo * cuopagadas); }
            else { cancelada.Saldo = pagado - (parametros.MoraAcometida * cuopagadas); }
            cancelada.Estado = "Valida";
            cancelada.EstadoPago = "Cancelado";
            cancelada.Comentario = "Se generó esta factura por pago parcial de la factura: " + fac.IdFactura + ";";
            cancelada.IdServicio = fac.IdServicio;
            cancelada.IdControlFecha = fechacontrol.IdControl;
            if (servicio.IdConsumo > 0) { cancelada.Mora = cuopagadas * parametros.MoraConsumo; } else { cancelada.Mora = cuopagadas * parametros.MoraAcometida; };
            cancelada.Descuento = descuento;
            if (cancelada.Saldo % cuotas.ConsultarCuota(servicio.IdConsumo, servicio.IdAcometida) == 0)
            {
                try
                {
                    //se cambia el estado de la factura ya que cono resultado de esta operacion se generan dos facturas mas, una con el monto cancelado y otra con el monto pendiente
                    fac.Estado = "Nula";
                    if (fac.Actualzar())
                    {
                        if (cancelada.Insertar())
                        {
                            //insertar movimiento de la factura cancelada
                            Movimientos movimiento = new Movimientos();
                            movimiento.IdFactura = cancelada.IdFactura;
                            movimiento.IdControlCaja = ct.IdControlCaja;
                            movimiento.Concepto = "CANCELACION POR SUMINISTRO DE AGUA SEGUN RECIBOS";
                            movimiento.Tipo = "Ingreso";

                            movimiento.IdControlCaja = ct.IdControlCaja;
                            movimiento.Doc = cancelada.IdFactura.ToString();
                            movimiento.IdFactura = cancelada.IdFactura;
                            movimiento.Empleado = empleado;
                            movimiento.IdControlBanco = 0;
                            movimiento.IdCliente = servicio.IdCliente;
                            movimiento.Fecha = DateTime.Now;
                            movimiento.Monto = pagado - descuento;
                            movimiento.Insertar();
                            //generar factura con saldo pendeinte
                            facParcial.Saldo = fac.Saldo - cancelada.Saldo;
                            facParcial.Mora = fac.Mora - cancelada.Mora;
                            facParcial.EstadoPago = "pendiente";
                            facParcial.Estado = "valida";
                            facParcial.Descuento = 0;
                            facParcial.IdServicio = fac.IdServicio;
                            facParcial.ContPendientes = fac.ContPendientes - cuopagadas;
                            facParcial.IdControlFecha = fechacontrol.IdControl;
                            facParcial.Comentario = "Esta factura se genero con el saldo pendiente por el pago parcial de la factura N°" + fac.IdFactura;
                            return facParcial.Insertar();
                        }
                    }
                    return true;
                }
                catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            }
            else { MessageBox.Show("nomas completas wey"); return false; }

            #endregion

        }
        public Boolean PagoAdelantado(double pagado, double descuento, string empleado)
        {
            Facturas adelantada = new Facturas();
            int facturaspagadas = FacturasPagadas(pagado - (fac.Saldo + fac.Mora));
            fac.EstadoPago = "cancelado";
            if (descuento > 0) { fac.Descuento = descuento; fac.Comentario = fac.Comentario + " se le aplico un descuento de $" + descuento; }
            adelantada.Saldo = pagado - ((fac.Saldo + fac.Mora) - fac.Descuento);
            adelantada.Mora = 0;
            adelantada.Estado = "valida";
            adelantada.EstadoPago = "cancelado";
            servicio.CuotasAnticipadas = facturaspagadas;
            adelantada.IdControlFecha = fechacontrol.IdControl;
            adelantada.IdServicio = servicio.IdServicio;
            adelantada.Descuento = 0;
            adelantada.Comentario = "Esta factura se genero por el pago adelantado de " + facturaspagadas + " cuotas de la factura n°" + fac.IdFactura;
            try
            {
                if (fac.Actualzar() && servicio.ActualizarServicio())
                {
                    //ingresar movimiento de la factura que esta pendiente
                    Movimientos movimiento = new Movimientos();
                    movimiento.IdFactura = fac.IdFactura;
                    movimiento.IdControlCaja = ct.IdControlCaja;
                    movimiento.Concepto = "CANCELACION POR SUMINISTRO DE AGUA SEGUN RECIBOS";
                    movimiento.IdControlCaja = ct.IdControlCaja;
                    movimiento.Doc = fac.IdFactura.ToString();
                    movimiento.Tipo = "Ingreso";
                    movimiento.Empleado = empleado;
                    movimiento.IdControlBanco = 0;
                    movimiento.IdCliente = servicio.IdCliente;
                    movimiento.Fecha = DateTime.Now;
                    movimiento.Monto = pagado - adelantada.Saldo;
                    movimiento.Insertar();
                    //insertar factura con el monto de las cuotas a delantadas que se esta cancelando
                    if (adelantada.Insertar())
                    {
                        //si se inserta la factura con el monto adelantado procedemos a insertar su respectivo movimiento
                        movimiento = new Movimientos();
                        movimiento.IdFactura = adelantada.IdFactura;
                        movimiento.IdControlCaja = ct.IdControlCaja;
                        movimiento.Tipo = "Ingreso";
                        movimiento.Concepto = "CANCELACION ANTICIPADA POR SUMINISTRO DE AGUA SEGUN RECIBOS";
                        movimiento.IdControlCaja = ct.IdControlCaja;
                        movimiento.Doc = adelantada.IdFactura.ToString();
                        movimiento.Empleado = empleado;
                        movimiento.IdControlBanco = 0;
                        movimiento.IdCliente = servicio.IdCliente;
                        movimiento.Fecha = DateTime.Now;
                        movimiento.Monto = adelantada.Saldo - descuento;
                        return movimiento.Insertar();
                    }
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }
        private int FacturasPagadas(double Pagado)
        {
            double cuota = cuotas.ConsultarCuota(servicio.IdConsumo, servicio.IdAcometida);
            int aux = 0;
            while (Pagado >= cuota)
            {
                Pagado = Pagado - cuota;
                aux++;
            }
            return aux;
        }

        public DataTable ConsultarFactuServ(int idcliente)
        {
            return fac.ConsultarFacServ(idcliente);
        }

        public DataTable ConsultarReporteGen(int idcolonia)
        {
            //inicializar objeto que contendra el resultado 
            DataTable resultado = new DataTable();
            //si el id de la colonia es 0 consulta unicamente una factura en base al idfactura buscado
            if (idcolonia != 0) resultado = fac.ConsultarReporteGen(fechacontrol.ConsultarUltimoCtr(), idcolonia);
            else resultado = fac.ConsultarReporteBuscar();
            resultado.Columns.Add("textmeses");
            resultado.Columns.Add("textsaldo");
            resultado.Columns.Add("morac");
            ConvertiraLetras conv = new ConvertiraLetras();
            foreach (DataRow row in resultado.Rows)
            {
                row["textmeses"] = GetMesesPendientes(row["mes"].ToString(), int.Parse(row["cont_pendiente"].ToString())).ToUpper();
                row["textsaldo"] = conv.Convertir(double.Parse(row["total"].ToString()));
                if (row["tipo"].ToString().Equals("1")) { row["morac"] = parametros.MoraConsumo.ToString("$ 0.00"); }
                else { row["morac"] = parametros.MoraAcometida.ToString("$ 0.00"); }
            }
            return resultado;
        }

        public DataTable ConsultarServPeligro()
        {
            return fac.ConsultarServPeligro(parametros.CuotasPenMax);
        }

        public Boolean IngresarFacBanco(string idfac)
        {
            fac.ConsultarFactura(idfac);
            servicio.IdServicio = fac.IdServicio;
            servicio = servicio.ConsultarServicio();
            cliente.IdCliente = servicio.IdCliente;
            cliente = cliente.ConsultarCliente();
            fechacontrol = fechacontrol.ConsultarControlFecha(fac.IdControlFecha);
            bool encontrado = ct.Consultar();
            bn = new ControlBancoNeg();
            bn.getCtBanco();
            return (CancelarBamco(fac.Mora + fac.Saldo, 0, "admin", bn.getid()));
        }

    }

}
