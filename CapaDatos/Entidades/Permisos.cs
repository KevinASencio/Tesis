using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Permisos
    {
        int _IdPermiso;
        int _IdAccion;
        int _IdRol;

        public int IdPermiso { get => _IdPermiso; set => _IdPermiso = value; }
        public int IdAccion { get => _IdAccion; set => _IdAccion = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }

        //consultar los permisos concedidos a un rol x
        public DataTable ConsultarPermisosCon()
        {
            DBOperacion operaion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT acc.accion, acc.idaccion, per.idpermiso ");
            sentencia.Append("FROM acciones acc ");
            sentencia.Append("JOIN permisos per ON acc.idaccion = per.idaccion ");
            sentencia.Append("JOIN roles rol ON per.idrol = rol.idrol ");
            sentencia.Append("WHERE rol.idrol = @idrol;");
            Dictionary <string,object> dic = new Dictionary<string,object>();
            dic.Add("idrol", IdRol);
            try
            {
                return operaion.Consultar(sentencia.ToString(),dic);
            }
            catch { return new DataTable(); }
        }

        //consultar los permisos denegados a un rol x
        public DataTable ConsultarPermisosDen()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT acc.accion, acc.idaccion ");
            sentencia.Append("FROM acciones acc ");
            sentencia.Append("WHERE NOT EXISTS(");
            sentencia.Append("SELECT idaccion  ");
            sentencia.Append("FROM permisos per ");
            sentencia.Append("JOIN roles rol ON per.idrol = rol.idrol ");
            sentencia.Append("WHERE rol.idrol =@idrol AND per.idaccion = acc.idaccion);");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idrol", IdRol);
            try
            {
                return operacion.Consultar(sentencia.ToString(),dic);
            }
            catch (Exception ex)
            {
                // Registro del error para depuración
                Console.WriteLine("Error: " + ex.Message);
                return new DataTable();
            }
        }

        public Boolean Insertar() 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia= new StringBuilder();
            sentencia.Append("insert into permisos (idrol,idaccion) values(");
            sentencia.Append("@idrol,");
            sentencia.Append(" @idaccion);");
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("idrol", IdRol);
            dic.Add("idaccion", IdAccion);
            try { return operacion.Insertar(sentencia.ToString(), dic); }catch { return false; }
        }

        public Boolean Eliminar() 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("delete from permisos where idpermiso=@idpermiso;");
            Dictionary<string,object> dic= new Dictionary<string,object>();
            dic.Add("idpermiso", IdPermiso);
            try { return operacion.Eliminar(sentencia.ToString(), dic); } catch { return false; }
        }

    }
}
