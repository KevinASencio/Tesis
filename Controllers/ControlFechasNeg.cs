using CapaDatos.Entidades;
using System;

namespace Controllers
{
    public class ControlFechasNeg
    {
        ControlFechasFacturas crt = new ControlFechasFacturas();

        public Boolean insertar()
        {

            return crt.agregar();
        }
        public int getId()
        {
            return crt.IdControl;
        }

        public void setFechaHasta(DateTime dt) { this.crt.FechaHasta = dt; }
        DateTime getFechaHasta() { return this.crt.FechaHasta; }
        public void setFechaVencimiento(DateTime dt) { this.crt.FechaVencimiento = dt; }
        public void setFechaGeneracion() { this.crt.FechaGeneracion = DateTime.Now; }
        public void setMes(string mes) { this.crt.Mes = mes; }
    }
}
