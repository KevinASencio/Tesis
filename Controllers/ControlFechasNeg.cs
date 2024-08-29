using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ControlFechasNeg
    {
        ControlFechasFacturas crt = new ControlFechasFacturas();

        public Boolean insertar() 
        {
            crt.FechaHasta = DateTime.Now; 
            crt.FechaVencimiento = DateTime.Now;
            crt.Mes = "enero";
            return crt.agregar();
        }
        public int getId() 
        {
            return crt.IdControl;
        }
    }
}
