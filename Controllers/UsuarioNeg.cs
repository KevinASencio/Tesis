using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.UsuarioNeg
{
    public class UsuarioNeg
    {

        Usuario user = new Usuario();
        Dictionary<string,int> _Permisos = new Dictionary<string,int>();

        public Dictionary<string, int> Permisos { get => _Permisos; set => _Permisos = value; }

        public DataTable Iniciar(string usuario, string pass)
        {
            return user.Validar(usuario, pass);
        }
    }
}
