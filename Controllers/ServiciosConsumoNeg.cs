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

        public ServiciosConsumoNeg() {}
        public ServiciosConsumoNeg(int id, int cuota) { servicio = new ServiciosConsumo(id, cuota); }
        public Boolean insertar(int idcuota)
        {
            this.servicio = new ServiciosConsumo(idcuota);
            return this.servicio.insertar();
        }

        public void setIdServicioConsumo(int id)
        {
            this.servicio.IdServicioConsumo = id;
        }
        public int getIdServicioConsumo() 
        {
            return this.servicio.IdServicioConsumo;
        }
        public void setIdCuotaConsumo(int id)
        {
            this.servicio.IdCuotaConsumo = id;
        }
        public int getIdCuotaConsumo()
        {
            return this.servicio.IdCuotaConsumo;
        }
        public Boolean actualizar() { return servicio.actualizarConsumo(); }
    }
}
