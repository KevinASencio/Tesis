using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos.Entidades
{
    public class Usuario
    {
        string _Usuario;
        string _Apellidos;
        string _Nombres;
        int _IdRol;
        string _Estado;
        string _Contraseña;
        string _Rol;

        public string Uusuario { get => _Usuario; set => _Usuario = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string Rol { get => _Rol; set => _Rol = value; }

        public static DataTable Consultar()
        {
            DataTable resul = new DataTable();
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append(@"select us.*, (select rol from roles as rl where us.idrol=rl.idrol) as rol from usuarios as us;");

            try
            {
                resul = operacion.Consultar(sentencia.ToString());
                return resul;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return new DataTable();
            }
        }

        public Boolean Insertar()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("insert into usuarios (usuario, nombres, apellidos, idrol, contraseña, estado) values(");
            sentencia.Append(" @usuario,");
            sentencia.Append(" @nombres,");
            sentencia.Append(" @apellidos,");
            sentencia.Append(" @idrol,");
            sentencia.Append(" sha1(@contraseña),");
            sentencia.Append(" @estado);");
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("usuario", Uusuario);
            dic.Add("nombres", Nombres);
            dic.Add("apellidos",Apellidos);
            dic.Add("idrol", IdRol);
            dic.Add("contraseña", Contraseña);
            dic.Add("estado", Estado);
            try
            {
                return operacion.Insertar(sentencia.ToString(),dic);

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return false;
            }
        }

        public Boolean Actualizar()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("update usuarios set ");
            sentencia.Append("nombres = @nombres,");
            sentencia.Append("apellidos = @apellidos,");
            sentencia.Append("idrol = @idrol,");
            sentencia.Append("contraseña = @contraseña,");
            sentencia.Append("estado = @estado where usuario=@usuario;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("usuario", Uusuario);
            dic.Add("nombres", Nombres);
            dic.Add("apellidos", Apellidos);
            dic.Add("idrol", IdRol);
            dic.Add("contraseña", Contraseña);
            dic.Add("estado", Estado);
            try
            {
                return operacion.Actualizar(sentencia.ToString(), dic);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return false;
            }
        }

        public DataTable Validar(string user, string pass)
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();

            sentencia.Append("select us.usuario, us.nombres, us.apellidos, us.estado,us.idrol , (select rol from roles as rl where us.idrol=rl.idrol) as rol");
            sentencia.Append(" from usuarios as us where  usuario='" +_Usuario + "'");
            sentencia.AppendFormat(" and BINARY contraseña=sha1('{0}');", pass);               

            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return new DataTable();
            }
        }

        public int[] permisos()
        {
            int[] privilegios = new int[7];
            DataTable aux = new DataTable();
            string consulta = "SELECT idaccion FROM db_acacuvan.permisos where idrol=" + _IdRol + ";";
            DBOperacion operacion = new DBOperacion();
            try
            {
                aux = operacion.Consultar(consulta);
                int i = 0;
                foreach (DataRow row in aux.Rows)
                {
                    privilegios[i] = int.Parse(row["idaccion"].ToString());
                    i++;
                }
                return privilegios;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Boolean CambiarEstado() 
        {
            DBOperacion operacion= new DBOperacion();
            StringBuilder sentencia=new StringBuilder();
            sentencia.Append("update usuarios set estado = '" + Estado + "' where usuario= '"+ Uusuario + "';");
            try
            {
                return operacion.Actualizar(sentencia.ToString());
            }
            catch (Exception ex) { return false; }
        }
    }



}
