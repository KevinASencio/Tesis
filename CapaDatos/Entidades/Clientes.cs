using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public  class Clientes
    {
        private string _Nombres;
        private string _Apellidos;
        private int _IdCliente;
        private string _Dui;
        private string _Direecion;
        private string _Estado;
        private string _Telefono;

        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Dui { get => _Dui; set => _Dui = value; }
        public string Direecion { get => _Direecion; set => _Direecion = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public static DataTable Consultar() 
        { 
            DataTable resul = new DataTable();
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append(@"select * from clientes");
            
            try {
                resul = operacion.Consultar(sentencia.ToString());
                return resul;
            }
            catch(Exception ex) {
                Console.Error.WriteLine(ex.ToString());
                return new DataTable();
            }
        }

        public int insert() {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion= new DBOperacion();
            sentencia.Append("insert into clientes (nombres, apellidos, direccion, dui, telefono) values(");
            sentencia.Append("'" + _Nombres + "',");
            sentencia.Append("'" + _Apellidos + "',");
            sentencia.Append("'" + _Direecion + "',");
            sentencia.Append("'" + _Dui + "',");
            sentencia.Append("'" + _Telefono + "');");
            try {
                return operacion.Insertar(sentencia.ToString());
                
            }
            catch(Exception ex) {
                Console.Error.WriteLine(ex.ToString());
                return 0;
            }
        }

        public int update()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("update lcientes set ");
            sentencia.Append("nombres='" + _Nombres + "',");
            sentencia.Append("apellidos='" + _Apellidos + "',");
            sentencia.Append("direccion='" + _Direecion + "',");
            sentencia.Append("dui='" + _Dui + "',");
            sentencia.Append("telefono='" + _Telefono + "'");
            sentencia.Append("where idcliente=" + _IdCliente.ToString());
            try
            {
                return operacion.Actualizar(sentencia.ToString());

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return 0;
            }
        }
    }
}
