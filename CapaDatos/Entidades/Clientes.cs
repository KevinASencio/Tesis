﻿using System;
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
        public static DataTable Consultar()
        {
            DataTable resul = new DataTable();
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append(@"select * from clientes;");

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

        public Boolean Guardar()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("insert into clientes (nombres, apellidos, direccion, dui, estado,telefono) values(");
            sentencia.Append("'" + _Nombres + "',");
            sentencia.Append("'" + _Apellidos + "',");
            sentencia.Append("'" + _Direecion + "',");
            sentencia.Append("'" + _Dui + "',");
            sentencia.Append("'" + _Estado + "',");
            sentencia.Append("'" + _Telefono + "');");
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
            sentencia.Append("Actualizar clientes set ");
            sentencia.Append("nombres='" + _Nombres + "',");
            sentencia.Append("apellidos='" + _Apellidos + "',");
            sentencia.Append("direccion='" + _Direecion + "',");
            sentencia.Append("dui='" + _Dui + "',");
            sentencia.Append("telefono='" + _Telefono + "',");
            sentencia.Append("estado='" + _Estado + "'");
            sentencia.Append("where idcliente=" + _IdCliente + ";");
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

        public Boolean CambiarEstado()
        {
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append("Actualizar clientes set estado = '" + _Estado + "' where idcliente=" + _IdCliente + ";");
            try
            {
                if (operacion.Eliminar(sentencia.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }

        public static Clientes ConsultarCliente(int idcliente) 
        {
            
            StringBuilder sentencia = new StringBuilder();
            DBOperacion operacion = new DBOperacion();
            sentencia.Append(@"select idcliente, nombres, apellidos, direccion, dui, estado, telefono from clientes where idcliente=" + idcliente + ";");

            try
            {
                DataRow rw = operacion.Consultar(sentencia.ToString()).Rows[0];
                Clientes cliente = new Clientes();
                cliente.IdCliente = int.Parse(rw.ItemArray[0].ToString());
                cliente.Nombres = rw.ItemArray[1].ToString();
                cliente.Apellidos = rw.ItemArray[2].ToString();
                cliente.Direecion = rw.ItemArray[3].ToString();
                cliente.Dui= rw.ItemArray[4].ToString();
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
