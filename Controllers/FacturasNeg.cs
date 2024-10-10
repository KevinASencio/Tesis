using CapaDatos.Entidades;
using System;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
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
            fac = Facturas.consultarFactura(idfactura);
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

        public Boolean PagoCompleto(double descuento)
        {
            if (fac.Mora > 0)
            {
                fac.Comentario = fac.Comentario + "Se cobro $ " + fac.Mora + " por pago tardio; ";
            }
            if (descuento > 0)
            {
                fac.Comentario += "se le desconto el valor de $ " + descuento;
            }
            fac.EstadoPago = "Cancelado";

            return fac.Actualzar();
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
                }
                
            }catch (Exception ex) { MessageBox.Show("Error "+ ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            #endregion

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
