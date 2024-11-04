using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos.Entidades
{
    public class Clientes
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
        public DataTable Consultar()
        {
            DataTable resul = new DataTable();
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append(@"select idcliente, nombres, apellidos, direccion, dui, estado, telefono from clientes;");

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
            sentencia.Append("insert into clientes (nombres, apellidos, direccion, dui, estado,telefono) values(");
            sentencia.Append(" @nombres,");
            sentencia.Append(" @apellidos,");
            sentencia.Append(" @direccion,");
            sentencia.Append(" @dui,");
            sentencia.Append(" @estado,");
            sentencia.Append(" @telefono);");

            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("nombres", Nombres);
            dic.Add("apellidos", Apellidos);
            dic.Add("direccion", Direecion);
            dic.Add("dui", Dui);
            dic.Add("estado", Estado);
            dic.Add("telefono", Telefono);

            try
            {
                return operacion.Insertar(sentencia.ToString(), dic);
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
            sentencia.Append("update clientes set ");
            sentencia.Append("nombres= @nombres,");
            sentencia.Append("apellidos=@apellidos,");
            sentencia.Append("direccion=@direccion,");
            sentencia.Append("dui=@dui,");
            sentencia.Append("telefono= @telefono,");
            sentencia.Append("estado=@estado");
            sentencia.Append("where idcliente=@idcliente;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("nombres", Nombres);
            dic.Add("apellidos", Apellidos);
            dic.Add("direccion", Direecion);
            dic.Add("dui", Dui);
            dic.Add("estado", Estado);
            dic.Add("telefono", Telefono);
            dic.Add("@idcliente", IdCliente);
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

        public Boolean CambiarEstado()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("update clientes set estado = '@estado' where idcliente=@idcliente;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("estado", Estado);
            dic.Add("idcliente", IdCliente);
            try
            {
                return operacion.Actualizar(sentencia.ToString(), dic);
            }
            catch
            {
                return false;
            }

        }

        public  Clientes ConsultarCliente()
        {

            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append(@"select idcliente, nombres, apellidos, direccion, dui, estado, telefono from clientes where idcliente=@idcliente;");
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("idcliente",IdCliente);
            try
            {
                DataRow rw = operacion.Consultar(sentencia.ToString(),dic).Rows[0];
                Clientes cliente = new Clientes();
                cliente.IdCliente = int.Parse(rw.ItemArray[0].ToString());
                cliente.Nombres = rw.ItemArray[1].ToString();
                cliente.Apellidos = rw.ItemArray[2].ToString();
                cliente.Direecion = rw.ItemArray[3].ToString();
                cliente.Dui = rw.ItemArray[4].ToString();
                cliente.Estado = rw.ItemArray[5].ToString();
                cliente.Telefono = rw.ItemArray[6].ToString();
                return cliente;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
