using System;
using System.Data;
using System.Text;

namespace CapaDatos.Entidades
{
    public class Usuario
    {
        string _Uusuario;
        string _Apellidos;
        string _Nombres;
        int _IdRol;
        string _Estado;
        string _Contraseña;
        string _Rol;

        public string Uusuario { get => _Uusuario; set => _Uusuario = value; }
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

        public Boolean Agregar()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("Agregar into usuarios (usuario, nombres, apellidos, idrol, contraseña, estado) values(");
            sentencia.Append("'" + _Uusuario + "',");
            sentencia.Append("'" + _Nombres + "',");
            sentencia.Append("'" + _Apellidos + "',");
            sentencia.Append(" " + _IdRol + ",");
            sentencia.Append("'" + _Contraseña + "',");
            sentencia.Append("'" + _Estado + "');");
            try
            {
                return operacion.Insertar(sentencia.ToString());

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
            sentencia.Append("usuario = '" + _Uusuario + "',");
            sentencia.Append("nombres = '" + _Nombres + "',");
            sentencia.Append("apellidos = '" + _Apellidos + "',");
            sentencia.Append("idrol = " + _IdRol + ",");
            sentencia.Append("contraseña = '" + _Contraseña + "',");
            sentencia.Append("estado = '" + _Estado + "' where usuario='" + _Uusuario + "';");

            try
            {
                return operacion.Actualizar(sentencia.ToString());

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

            sentencia.Append(@"select us.usuario, us.nombres, us.apellidos, us.estado,us.idrol , (select rol from roles as rl where us.idrol=rl.idrol) as rol 
                              from usuarios as us where  usuario='" + user + "' and BINARY contraseña='" + pass + "';");

            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
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
    }



}
