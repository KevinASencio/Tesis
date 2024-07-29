using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ServiciosConsumoNeg
    {
        ServiciosConsumo servicio;

        public ServiciosConsumoNeg() { }

        public int consultar() 
        {
            this.servicio = new ServiciosConsumo(1);
            this.servicio.insertar();
            return this.servicio.IdServicioConsumo;
        }
    }
}
