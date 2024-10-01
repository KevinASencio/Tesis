using CapaDatos.Entidades;
using System;
using System.Data;

namespace CapaNegocio.UsuarioNeg
{
    public class UsuarioNeg
    {

        private Usuario user = new Usuario();
        public Usuario User { get => user; set => user = value; }

        public static DataTable consultar() { return Usuario.Consultar(); }

        public Boolean Iniciar(string usuario, string pass)
        {
            DataTable result = new DataTable();
            result = User.Validar(usuario, pass);
            if (result.Rows.Count > 0)
            {
                user.Nombres = result.Rows[0]["nombres"].ToString();
                user.Apellidos = result.Rows[0]["apellidos"].ToString();
                user.Uusuario = usuario;
                user.Estado = result.Rows[0]["estado"].ToString();
                user.IdRol = int.Parse(result.Rows[0]["idrol"].ToString());
                user.Rol = result.Rows[0]["rol"].ToString();
                return true;
            }
            return false;
        }

        public string usuario() { return user.Uusuario; }
        public string nombres() { return user.Nombres; }
        public string apellidos() { return user.Apellidos; }
        public string estado() { return user.Estado; }
        public string rol() { return user.Rol; }

        public void Setusuario(string usuario) { user.Uusuario = usuario; }
        public void Setcontraseña(string contraseña) { user.Contraseña = contraseña; }

        public void Setnombres(string nombres) { user.Nombres = nombres; }
        public void Setapellidos(string apellidos) { user.Apellidos = apellidos; }
        public void Setestado(string apellidos) { user.Estado = apellidos; }

        public void Setrol(string rol) { user.Rol = rol; }
        public void Setidrol(int idrol) { user.IdRol = idrol; }


        public int[] Permisos()
        {
            return user.permisos();
        }

        public Boolean Actualizar(string usuario)
        {
            return user.Actualizar(usuario);
        }
        public Boolean Agregar()
        {
            return user.Agregar();
        }

    }
}
