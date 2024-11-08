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

        public ControlFechasNeg(int idcontrol,string mes, DateTime fechavencimiento, DateTime fechahasta)
        {
            this.crt = new ControlFechasFacturas();
            crt.IdControl = idcontrol;
            crt.Mes = mes;
            crt.FechaHasta = fechahasta;
            crt.FechaVencimiento = fechavencimiento;
            crt.FechaGeneracion = DateTime.Now;
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
