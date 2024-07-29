using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ServiciosNeg
    {
        Servicios _Servicio;

        public ServiciosNeg()
        {
            _Servicio = new Servicios();
        }

        public ServiciosNeg(int idservicio, int idCliente, int idColonia)
        {
            this._Servicio = new Servicios();
            this._Servicio.IdServicio = idservicio;
            this._Servicio.IdCliente = idCliente;
            this._Servicio.IdColonia = idColonia;
        }
    }
}
