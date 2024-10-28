using CapaDatos.Entidades;
using System.Data;

namespace Controllers
{
    public class CuotasNeg
    {
        Cuotas cuota;

        public static DataTable consultarCuotasConsumo()
        {
            return Cuotas.consultarCuotasConsumo();
        }
        public static DataTable consultarCuotasAcometida() { return Cuotas.consultarCuotasAcometida(); }

        public static double ConCuota(int id) 
        {
            return Cuotas.ConsultarCuotaConsumo(id);
        }

        public bool ProcesarCuotaConsumo(int id, float monto) 
        {
            cuota = new Cuotas();
            if (id > 0)
            {
                cuota.IdCuota = id;
                cuota.Monto = monto;
                return cuota.ActualizarCuotaCon();
            }
            else 
            {
                cuota.Monto = monto;
                return cuota.InsertarCuotaCon();
            }
        }

        public bool ProcesarCuotaAcometida(int id, float monto)
        {
            cuota = new Cuotas();
            if (id > 0)
            {
                cuota.IdCuota = id;
                cuota.Monto = monto;
                return cuota.ActualizarCuotaAco();
            }
            else
            {
                cuota.Monto = monto;
                return cuota.InsertarCuotaAcometida();
            }
        }
    }
}
