using CapaDatos.Entidades;
using System;
using System.Data;

namespace Controllers
{
    public class ControlFechasNeg
    {
        ControlFechasFacturas crt = new ControlFechasFacturas();

        public Boolean insertar(string mes, DateTime fechavencimiento,DateTime fechahasta)
        {
            crt.Mes = mes;
            crt.FechaHasta = fechahasta;
            crt.FechaVencimiento = fechavencimiento;
            crt.FechaGeneracion=DateTime.Now;
            return crt.Agregar();
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
