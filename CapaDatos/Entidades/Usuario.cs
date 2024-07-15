using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Usuario
    {
        string _Uusuario;
        string _Apellidos;
        string _Nombres;
        string _IdRol;
        string _Estado;
        string _Password;

        public string Uusuario { get => _Uusuario; set => _Uusuario = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string IdRol { get => _IdRol; set => _IdRol = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Password { get => _Password; set => _Password = value; }

        public DataTable Consultar()
        {
            DataTable resul = new DataTable();
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append(@"select * from clientes");

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

        public Boolean insert()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("insert into usuarios (usuario, nombres, apellidos, idrol, password, estado) values(");
            sentencia.Append("'" + _Uusuario + "',");
            sentencia.Append("'" + _Nombres + "',");
            sentencia.Append("'" + _Apellidos + "',");
            sentencia.Append("'" + _IdRol + "',");
            sentencia.Append("'" + _Password + "',");
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

        public Boolean update()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("Actualizar lcientes set ");
            sentencia.Append("usuario = '" + _Uusuario + "',");
            sentencia.Append("nombres = '" + _Nombres + "',");
            sentencia.Append("apellidos = '" + _Apellidos + "',");
            sentencia.Append("idrol = " + _IdRol + ",");
            sentencia.Append("password = '" + _Password + "',");
            sentencia.Append("estado = '" + _Estado + "') where usuario=" + _Uusuario + ";");

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

        public DataTable Validar(string user, string pass) {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();

            sentencia.Append("select usuario, nombres, apellidos, estado, idrol from usuarios where  usuario='" + user + "' and BINARY password='" + pass + "';");

            try
            {
                return operacion.Consultar(sentencia.ToString());
            } catch (Exception ex)
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
                    privilegios[i]= int.Parse(row["idaccion"].ToString());
                    i++;
                }
                return privilegios;
            } catch (Exception e) {
                return null;
            }
        }
    }

   
    
}
