using CapaDatos.Entidades;
using System;
using System.Data;

namespace Controllers
{
    public class ControlFechasNeg
    {
        ControlFechasFacturas crt = new ControlFechasFacturas();

        public ControlFechasNeg() {

            this.crt = new ControlFechasFacturas();
        }

        public ControlFechasNeg(string mes, DateTime fechavencimiento, DateTime fechahasta)
        {
            this.crt = new ControlFechasFacturas();
            crt.Mes = mes;
            crt.FechaHasta = fechahasta;
            crt.FechaVencimiento = fechavencimiento;
            crt.FechaGeneracion = DateTime.Now;
        }

        public Boolean insertar()
        {
            return crt.Agregar();
        }

        public Boolean Procesar() 
        {
            if (crt.IdControl == 0)
            {
                return crt.Agregar();
            }
            else 
            {
                return crt.Actualizar();
            }
            return false;
        }
        public int getId()
        {
            return crt.IdControl;
        }

        public DataTable ConsultarFechas() 
        {
            return crt.ConsultarControlFecha();
        }
        public ControlFechasFacturas ConsultarControl() 
        {
            return crt.ConsultarControlFecha(crt.IdControl);
        }
    }
}
