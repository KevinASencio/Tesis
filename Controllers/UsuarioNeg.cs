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
        public Usuario User { get => user; set => user = value; }

        public static DataTable consultar() { return Usuario.Consultar(); }

        public Boolean Iniciar(string usuario, string pass)
        { DataTable result = new DataTable();
            result = User.Validar(usuario, pass);
            if (result.Rows.Count > 0) {

                user.Nombres = result.Rows[0]["nombres"].ToString();
                user.Apellidos = result.Rows[0]["apellidos"].ToString();
                user.Uusuario = usuario;
                user.Estado = result.Rows[0]["estado"].ToString();
                user.IdRol = result.Rows[0]["idrol"].ToString();
                user.Rol= result.Rows[0]["rol"].ToString() ;
                return true;
            }
            return false;
        }

        public string usuario() { return user.Uusuario; }
        public string nombres() { return user.Nombres; }
        public string apellidos() { return user.Apellidos; }
        public string estado() { return user.Estado; }

        public string rol() { return user.Rol; }
        public int[] Permisos()
        {
            return user.permisos();
        }
    }
}
