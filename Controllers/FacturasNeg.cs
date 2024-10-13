using CapaDatos.Entidades;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public DataTable Generar(int idcontrol, double mora, ProgressBar psbBar, Label conta)
        {
            return fac.GenerarFacturasConsumo(idcontrol, mora, psbBar, conta);
        }

        public DataTable GenerarAco(int idcontrol, double mora, ProgressBar psbBar, Label conta)
        {
            return fac.GenerarFacturasAcometida(idcontrol, mora, psbBar, conta);
        }

        public void ConsultarFactura(string idfactura, Form contenedor)
        {
            fac.consultarFactura(idfactura);
            servicio = Servicios.ConsultarServicio(fac.IdServicio);
            cliente = Clientes.ConsultarCliente(servicio.IdCliente);
            fechacontrol = ControlFechasFacturas.ConsultarControlFecha(fac.IdControlFecha);
            parametros = Parametros.Consultar();

            contenedor.Controls.Find("lblcliente", true)[0].Text = cliente.Nombres + ", " + cliente.Apellidos;
            contenedor.Controls.Find("lblMora", true)[0].Text = fac.Mora.ToString("$ 00.00");
            contenedor.Controls.Find("lblMonto", true)[0].Text = fac.Saldo.ToString("$ 00.00");
            contenedor.Controls.Find("txbTotalPagar", true)[0].Text = (fac.Saldo + fac.Mora).ToString("$ 00.00");
            contenedor.Controls.Find("txbDescuento", true)[0].Text = fac.Descuento.ToString("$ 00.00");
            contenedor.Controls.Find("lblMes", true)[0].Text = fechacontrol.Mes;
            contenedor.Controls.Find("lblMesesPen", true)[0].Text = GetMesesPendientes(fechacontrol.Mes);
        }
        public string GetNomCLiente()
        {
            return cliente.Nombres + ", " + cliente.Apellidos;
        }

        public string getMes()
        {
            return fechacontrol.Mes;
        }

        public string GetMesesPendientes(string mes)
        {
            // arreglo para crear la cedena de meses pendientes 
            string[] meses = { "diciembre", "noviembre", "octubre", "septiembre", "agosto", "julio", "junio", "mayo", "abril", "marzo", "febrero", "enero" };
            StringBuilder aux = new StringBuilder();
            int i = fac.ContPendientes;
            int pendiente = fac.ContPendientes;
            //acceder al indice del mes que se esta cobrando en la factura para recorrer desde ahi el arreglo 
            int cont = Array.IndexOf(meses, mes);

            do
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
                pendiente--;
            } while (pendiente > 0);

            return aux.ToString().Remove(0, 2);
        }

        public Boolean PagoCompleto(double pagado, double descuento, string empleado
        {
            if (fechacontrol.FechaVencimiento < DateTime.Now)
            {
                if (MessageBox.Show("Desea cobrar mora por pago tardio?", "Ojo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (servicio.IdConsumo == 0) { fac.Comentario = fac.Comentario + "Se cobro $ " + parametros.MoraConsumo + " por pago tardio"; }
                    else { fac.Comentario = fac.Comentario + "Se cobro $ " + parametros.MoraAcometida + " por pago tardio;"; }
                }
            }
            if (descuento > 0)
            {
                fac.Comentario += "se le desconto el valor de $ " + descuento;
            }
            fac.EstadoPago = "Cancelado";

            if (fac.Actualzar()) 
            {
                Movimientos movimientos = new Movimientos();
                ControlMensualCaja ct = new ControlMensualCaja();
                ct.Consultar();
                movimientos.IdFactura = fac.IdFactura;
                movimientos.IdControlCaja = ct.IdControlCaja;
                movimientos.Concepto = "CANCELACION POR SUMINISTRO DE AGUA SEGUN RECIBOS";
                movimientos.IdControlCaja= ct.IdControlCaja;
                movimientos.Doc = fac.IdFactura.ToString();
                movimientos.IdFactura= fac.IdFactura;
                movimientos.Empleado = empleado;
                movimientos.IdControlBanco = 0;
                movimientos.IdCliente = servicio.IdCliente;
                movimientos.Fecha = DateTime.Now;
            }


            return false;
        }

        public Boolean PagoParcial(double pagado, double descuento)
        {
            Facturas facParcial = new Facturas();
            Facturas cancelada = new Facturas();
            int cuopagadas = FacturasPagadas(pagado);

            #region creacion y procesamiento de factura con la infromacion de las cuotas pagaas
            cancelada.Saldo = pagado;
            cancelada.Estado = "Valida";
            cancelada.EstadoPago = "Cancelado";
            cancelada.Comentario = "Se generó esta factura por pago parcial de la factura: " + fac.IdFactura + ";";
            cancelada.IdServicio = fac.IdServicio;
            cancelada.IdControlFecha = ControlFechasFacturas.ConsultarUltimoCtr();
            if (servicio.IdConsumo > 0) { cancelada.Mora = cuopagadas * parametros.MoraConsumo; } else { cancelada.Mora = cuopagadas + parametros.MoraAcometida; };
            cancelada.Descuento = descuento;

            try
            {
                if (cancelada.Insertar() == true)
                {
                    //insertar movimiento
                    //generar factura con saldo pendeinte
                    facParcial.Saldo = fac.Saldo - cancelada.Saldo;
                    facParcial.Mora = fac.Mora - cancelada.Mora;
                    facParcial.EstadoPago = "pendiente";
                    facParcial.Estado = "valida";
                    facParcial.Descuento = 0;
                    facParcial.IdServicio = fac.IdServicio;
                    facParcial.ContPendientes = fac.ContPendientes - cuopagadas;
                    facParcial.IdControlFecha = ControlFechasFacturas.ConsultarUltimoCtr();
                    facParcial.Comentario = "Esta factura se genero con el saldo pendiente por el pago parcial de la factura N°" + fac.IdFactura;
                    return facParcial.Insertar();
                }

                return true;

            }
            catch (Exception ex) { MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            #endregion

        }

        public Boolean PagoAdelantado(double pagado, double descuento)
        {
            Facturas adelantada = new Facturas();
            int facturaspagadas = FacturasPagadas(pagado - (fac.Saldo + fac.Mora));

            fac.EstadoPago = "cancelado";
            if (descuento > 0) { fac.Descuento = descuento; fac.Comentario = fac.Comentario + " se le aplico un descuento de $" + descuento; }

            adelantada.Saldo = pagado - (fac.Saldo + fac.Mora);
            adelantada.Mora = 0;
            adelantada.Estado = "valida";
            adelantada.EstadoPago = "cancelado";
            servicio.CuotasAnticipadas = facturaspagadas;
            adelantada.IdControlFecha = ControlFechasFacturas.ConsultarUltimoCtr();
            adelantada.IdServicio = servicio.IdServicio;
            adelantada.Descuento = 0;
            adelantada.Comentario = "Esta factura se genero por el pago adelantado de " + facturaspagadas + " cuotas de la factura n°" + fac.IdFactura;

            try
            {
                if (fac.Actualzar())
                {
                    //ingresar movimiento


                    return adelantada.Insertar();
                }
                return false;
            }
            catch (Exception ex) { return false; }

        }

        private int FacturasPagadas(double Pagado)
        {
            double cuota = Cuotas.ConsultarCuota(servicio.IdConsumo, servicio.IdAcometida);
            int aux = 0;
            while (Pagado >= cuota)
            {
                Pagado = Pagado - cuota;
                aux++;
            }
            return aux;
        }
    }
}
