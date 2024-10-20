using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
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
    }
}
