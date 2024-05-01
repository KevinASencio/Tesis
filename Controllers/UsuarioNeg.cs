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

        private Usuario user = new Usuario();

        Dictionary<string,int> _Permisos = new Dictionary<string,int>();

        public Dictionary<string, int> Permisos { get => _Permisos; set => _Permisos = value; }
        public Usuario User { get => user; set => user = value; }

        public Boolean Iniciar(string usuario, string pass)
        {   DataTable result = new DataTable();
            result = User.Validar(usuario, pass);
            if (result.Rows.Count > 0) {

                user.Nombres = result.Rows[0]["nombres"].ToString();
                user.Apellidos = result.Rows[0]["apellidos"].ToString();
                user.Uusuario = usuario;
                user.Estado = result.Rows[0]["estado"].ToString();

                return true;
            }
            return false;
        }

        public string usuario() { return user.Uusuario; }
        public string nombres() { return user.Nombres; }
        public string apellidos() { return user.Apellidos; }
        public string estado() { return user.Estado; }

    }
}
