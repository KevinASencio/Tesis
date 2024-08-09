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

        public int insertar(int idcuota)
        {
            this.servicio = new ServiciosConsumo(idcuota);
            this.servicio.insertar();
            return this.servicio.IdServicioConsumo;
        }

        public void setIdServicioConsumo(int id)
        {
            this.servicio.IdServicioConsumo = id;
        }
        public int getIdServicioConsumo() 
        {
            return this.servicio.IdServicioConsumo;
        }
    }
}
