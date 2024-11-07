using CapaDatos.Entidades;
using System.Data;

namespace Controllers
{
    public class ColoniasNeg
    {
        Colonias _colonias = new Colonias();
        public DataTable consultar() { return _colonias.consultar(); }
    }
}
