using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CapaDatos.Entidades
{
    public class Roles
    {

        int _IdRol;
        string _Rol;

        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string Rol { get => _Rol; set => _Rol = value; }

        public static DataTable Consultar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            try
            {
                sentencia.Append(@"select idrol, rol from roles;");
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); return null; }

        }

        public Boolean AgregarRol()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into roles (rol) Values ( '" + Rol + "')");
            try { return operacion.Insertar(sentencia.ToString()); }
            catch { return false; }
        }

        public Boolean Actualizar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update roles set rol='" + Rol + "' where idrol=;" + IdRol + ";");
            try { return operacion.Actualizar(sentencia.ToString()); } catch { return false; }

        }
    }
}
