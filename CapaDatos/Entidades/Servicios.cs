using Microsoft.SqlServer.Server;
using Mysqlx.Crud;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CapaDatos.Entidades
{
    public class Servicios
    {
        int _IdServicio;
        int _IdCliente;
        int _IdColonia;
        DateTime _FechaApertura;
        int _CuotasAnticipadas;
        string _Comentario;
        int _IdConsumo;
        int _IdAcometida;
        string _Estado;

        public int IdServicio { get => _IdServicio; set => _IdServicio = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdColonia { get => _IdColonia; set => _IdColonia = value; }
        public DateTime FechaApertura { get => _FechaApertura; set => _FechaApertura = value; }
        public int CuotasAnticipadas { get => _CuotasAnticipadas; set => _CuotasAnticipadas = value; }
        public string Comentario { get => _Comentario; set => _Comentario = value; }
        public int IdConsumo { get => _IdConsumo; set => _IdConsumo = value; }
        public int IdAcometida { get => _IdAcometida; set => _IdAcometida = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public static DataTable ConsultarCon()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, concat(cl.nombres,\" \", cl.apellidos)as cliente,ser.idcliente, ser.idconsumo, cuo.idcuotaconsumo, cuo.monto, col.Colonia, ");
            sentencia.Append(" col.idcolonia, ser.fecha_apertura, ser.estado, ser.comentario, ser.cuotas_anticipadas from servicios ser, clientes cl, colonias col,");
            sentencia.Append("cuotasconsumo cuo, serviciosconsumo sercon  where ser.idcliente=cl.idcliente and ");
            sentencia.Append("col.idcolonia=ser.idcolonia and ser.idconsumo = sercon.idserviciosconsumo and sercon.idcuotaconsumo=cuo.idcuotaconsumo;");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }

        public static DataTable ConsultarCon(int idcliente)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, concat(cl.nombres,\" \", cl.apellidos)as cliente,ser.idcliente, ser.idconsumo, cuo.idcuotaconsumo, cuo.monto, col.Colonia, ");
            sentencia.Append(" col.idcolonia, ser.fecha_apertura, ser.estado, ser.comentario, ser.cuotas_anticipadas from servicios ser, clientes cl, colonias col,");
            sentencia.Append("cuotasconsumo cuo, serviciosconsumo sercon  where ser.idcliente=" + idcliente + " and ser.idcliente=cl.idcliente and ");
            sentencia.Append("col.idcolonia=ser.idcolonia and ser.idconsumo = sercon.idserviciosconsumo and sercon.idcuotaconsumo=cuo.idcuotaconsumo;");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }
        public static DataTable ConsultarAco()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, concat(cl.nombres, \" \", cl.apellidos) as cliente, ser.idacometida, cuo.idcuotaacometida, cuo.monto, col.Colonia, col.idcolonia, ser.fecha_apertura, ser.estado, ser.Comentario, ");
            sentencia.Append("seraco.saldo, seraco.monto as 'total', (seraco.numerocuotas - seraco.cuotas_pagadas) as cuotas_restantes, seraco.idserviciosacometida ");
            sentencia.Append("from servicios ser, clientes cl, colonias col, cuotasacometida cuo, serviciosacometida seraco ");
            sentencia.Append("where ser.idcliente = cl.idcliente and col.idcolonia = ser.idcolonia and ser.idacometida = seraco.idserviciosacometida and seraco.idcuotaacometida = cuo.idcuotaacometida;");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }
        public static DataTable ConsultarAco(int idcliente)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, concat(cl.nombres, \" \", cl.apellidos) as cliente, ser.idacometida, cuo.idcuotaacometida, cuo.monto, col.Colonia, col.idcolonia, ser.fecha_apertura, ser.estado, ser.Comentario, ");
            sentencia.Append("seraco.saldo, seraco.monto as 'total', (seraco.numerocuotas - seraco.cuotas_pagadas) as cuotas_restantes, seraco.idserviciosacometida ");
            sentencia.Append("from servicios ser, clientes cl, colonias col, cuotasacometida cuo, serviciosacometida seraco ");
            sentencia.Append("where ser.idcliente = " + idcliente + " and ser.idcliente = cl.idcliente and col.idcolonia = ser.idcolonia and ser.idacometida = seraco.idserviciosacometida and seraco.idcuotaacometida = cuo.idcuotaacometida;");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }
        public Boolean InsertarServicio(string tipo)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into servicios(idcliente,idcolonia,fecha_apertura,estado,comentario, idconsumo)");
            sentencia.Append("Values (" + this.IdCliente + ",");
            sentencia.Append(" " + this.IdColonia + ", ");
            sentencia.Append(" '" + this.FechaApertura.ToString("yyyy,MM,dd") + "', ");
            
            sentencia.Append(" '" + this.Estado + "', ");
            sentencia.Append(" '" + this.Comentario + "', ");
            switch (tipo) 
            {
                case "consumo":
                    sentencia.Append(" " + this.IdConsumo + " );");
                    break;
                case "acometida":
                    sentencia.Replace("idconsumo", "idacometida");
                    sentencia.Append(" " + this.IdAcometida + " );");
                    break;
            }
            try
            {
                return operacion.Insertar(sentencia.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }

        public Boolean ActualizarServicio() 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update servicios set ");
            sentencia.Append("idcolonia = " + this.IdColonia + ", ");
            sentencia.Append("estado = '" + this.Estado + "', ");
            sentencia.Append("comentario = '" + this.Comentario + "', ");
            sentencia.Append("idcolonia = " + this.IdColonia + " ");
            sentencia.Append("where idservicio= " + this.IdServicio + ";");
            try{ return operacion.Actualizar(sentencia.ToString()); } catch (Exception e) { return false;}
        }

        public Boolean CambiarEstado()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update servicios set ");
            sentencia.Append("estado = '" + this.Estado + "' ");
            sentencia.Append("where idservicio= " + this.IdServicio + ";");
            try { return operacion.Actualizar(sentencia.ToString()); } catch (Exception e) { return false; }
        }
        public Boolean InsertAcometida()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into servicios(idcliente,idcolonia,fecha_apertura,estado,comentario, idacometida)");
            sentencia.Append("Values (" + this.IdCliente + ",");
            sentencia.Append(" " + this.IdColonia + ", ");
            sentencia.Append(" '" + this.FechaApertura.ToString("yyyy,MM,dd") + "', ");
            sentencia.Append(" '" + this.Estado + "', ");
            sentencia.Append(" '" + this.Comentario + "', ");
            sentencia.Append(" " + this.IdAcometida + " );");
            try
            {
                return operacion.Insertar(sentencia.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }
        public static int ConsulTotal()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia= new StringBuilder();
            sentencia.Append("select count(idservicio) from servicios where estado='Activo' limit 1;");
            try 
            {
                return int.Parse(operacion.Consultar(sentencia.ToString()).Rows[0][0].ToString());
            } 
            catch (Exception e) 
            {
                return 0;
            }
        }
    }

}
