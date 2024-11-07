
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ParametrosNeg
    {
        Parametros _parametros;

        public DataTable ConsultarParametros()
        {
            _parametros = new Parametros();
            return _parametros.ConsultarParametro();
        }
    }
}
