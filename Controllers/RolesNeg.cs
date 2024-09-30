using CapaDatos.Entidades;
using System.Data;

namespace Controllers
{
    public class RolesNeg
    {
        public static DataTable consultar()
        {
            return Roles.Consultar();
        }
    }
}
