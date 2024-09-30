using CapaDatos.Entidades;
using System.Data;

namespace Controllers
{
    public class ColoniasNeg
    {
        public static DataTable consultar() { return Colonias.consultar(); }
    }
}
