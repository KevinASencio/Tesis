using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CuotasNeg
    {
        Cuotas cuota;

        public static DataTable consultarCuotasConsumo()
        {
            return Cuotas.consultarCuotasConsumo();
        }
    }
}
