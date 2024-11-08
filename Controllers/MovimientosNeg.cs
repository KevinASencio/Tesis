using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class MovimientosNeg
    {
        Movimientos movimiento = new Movimientos();
        ControlMensualCaja caja= new ControlMensualCaja();
        ControlMensualBanco banco = new ControlMensualBanco();

        public bool guardar(System.Windows.Forms.Form contenedor , string usuario) 
        {
            
            movimiento.Doc= contenedor.Controls.Find("txbFactura", true)[0].Text.ToString();
            movimiento.Monto = double.Parse(contenedor.Controls.Find("txbMonto", true)[0].Text.ToString());
            movimiento.Tipo = (contenedor.Controls.Find("cmbTipo", true)[0].Text.ToString());
            movimiento.Fecha = DateTime.Parse((contenedor.Controls.Find("dtpFecha", true)[0].Text.ToString()));
            movimiento.Concepto = contenedor.Controls.Find("txbConcepto", true)[0].Text.ToString();
            movimiento.Empleado = usuario;
            banco.Consultar();
            caja.Consultar();
            if (contenedor.Controls.Find("cmbLugarPago", true)[0].Text.ToString().Equals("Caja Local")) { movimiento.IdControlCaja = caja.IdControlCaja; movimiento.IdControlBanco = 0; }
            else { movimiento.IdControlBanco = banco.IdControlBanco; movimiento.IdControlCaja = 0; }
                return movimiento.Insertar();
        }

        public DataTable ConsultarRepCaja(int idcontrol)
        {
            DataTable movaux = new DataTable();
            DataTable conaux = new DataTable();
            movimiento.IdControlCaja = idcontrol;
            ControlCajaNeg control = new ControlCajaNeg();
            conaux = control.Consultar(idcontrol);
            movaux = movimiento.ConsultarRepResumeCaja();
            movaux.Columns.Add("saldo", typeof(double));
            movaux.Rows[0]["saldo"] = (Convert.ToDouble(conaux.Rows[0]["saldoinicial"]).ToString()+ Convert.ToDouble(movaux.Rows[0]["monto"].ToString())).ToString();
            int cont = 1;
            for (int i = 1; i < movaux.Rows.Count; i++)
            {
                
                double aux1 = Convert.ToDouble(movaux.Rows[i - 1]["saldo"].ToString());
                double aux2 = Convert.ToDouble(movaux.Rows[i]["monto"].ToString());
                movaux.Rows[i]["saldo"] = (aux1 + aux2).ToString();
            }
            return movaux;
        }

        public DataTable ConsultarRepBanco(int idcontrol)
        {
            DataTable movaux = new DataTable();
            DataTable conaux = new DataTable();
            movimiento.IdControlBanco = idcontrol;
            ControlMensualBanco control = new ControlMensualBanco();
            conaux = control.Consultar(idcontrol);
            movaux = movimiento.ConsultarRepResumeBanco();
            movaux.Columns.Add("saldo", typeof(double));
            movaux.Rows[0]["saldo"] = (Convert.ToDouble(conaux.Rows[0]["saldoinicial"].ToString()) + Convert.ToDouble(movaux.Rows[0]["monto"].ToString())).ToString();
            int cont = 1;
            for (int i = 1; i < movaux.Rows.Count; i++)
            {

                double aux1 = Convert.ToDouble(movaux.Rows[i - 1]["saldo"].ToString());
                double aux2 = Convert.ToDouble(movaux.Rows[i]["monto"].ToString());
                movaux.Rows[i]["saldo"] = (aux1 + aux2).ToString();
            }
            return movaux;
        }
    }
}
