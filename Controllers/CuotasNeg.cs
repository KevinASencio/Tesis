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
    }
}
