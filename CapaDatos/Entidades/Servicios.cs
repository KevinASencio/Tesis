using System;
using System.Data;
using System.Text;

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
            sentencia.Append("select ser.idservicio, concat(cl.nombres,\" \", cl.apellidos)as cliente, ser.idconsumo, cuo.idcuota_consumo, cuo.monto, col.Colonia, ");
            sentencia.Append(" col.idcolonia, ser.fecha_apertura, ser.estado, ser.comentario, ser.cuotas_anticipadas from servicios ser, clientes cl, colonias col,");
            sentencia.Append("cuotas_consumo cuo, serviciosconsumo sercon  where ser.idcliente=cl.idcliente and ");
            sentencia.Append("col.idcolonia=ser.idcolonia and ser.idconsumo = sercon.idserviciosconsumo and sercon.idcuotaconsumo=cuo.idcuota_consumo;");
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
            sentencia.Append("select ser.idservicio, concat(cl.nombres,\" \", cl.apellidos)as cliente, ser.idconsumo, cuo.idcuota_consumo, cuo.monto, col.Colonia, ");
            sentencia.Append(" col.idcolonia, ser.fecha_apertura, ser.estado, ser.comentario, ser.cuotas_anticipadas from servicios ser, clientes cl, colonias col,");
            sentencia.Append("cuotas_consumo cuo, serviciosconsumo sercon  where ser.idcliente=" + idcliente + " and ser.idcliente=cl.idcliente and ");
            sentencia.Append("col.idcolonia=ser.idcolonia and ser.idconsumo = sercon.idserviciosconsumo and sercon.idcuotaconsumo=cuo.idcuota_consumo;");
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
            sentencia.Append("select ser.idservicio, concat(cl.nombres, \" \", cl.apellidos) as cliente, ser.idconsumo, cuo.idcuota_acometida, cuo.monto, col.Colonia, col.idcolonia, ser.fecha_apertura, ser.estado, ser.Comentario, ");
            sentencia.Append("seraco.saldo, seraco.monto as 'total', (seraco.numerocuotas - seraco.cuotas_pagadas) as cuotas_restantes ");
            sentencia.Append("from servicios ser, clientes cl, colonias col, cuotas_acometida cuo, serviciosacometida seraco ");
            sentencia.Append("where ser.idcliente = cl.idcliente and col.idcolonia = ser.idcolonia and ser.idacometida = seraco.idserviciosacometida and seraco.idcuotaacometida = cuo.idcuota_acometida;");
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
            sentencia.Append("select ser.idservicio, concat(cl.nombres, \" \", cl.apellidos) as cliente, ser.idconsumo, cuo.idcuota_acometida, cuo.monto, col.Colonia, col.idcolonia, ser.fecha_apertura, ser.estado, ser.Comentario, ");
            sentencia.Append("seraco.saldo, seraco.monto as 'total', (seraco.numerocuotas - seraco.cuotas_pagadas) as cuotas_restantes ");
            sentencia.Append("from servicios ser, clientes cl, colonias col, cuotas_acometida cuo, serviciosacometida seraco ");
            sentencia.Append("where ser.idcliente = " + idcliente + " and ser.idcliente = cl.idcliente and col.idcolonia = ser.idcolonia and ser.idacometida = seraco.idserviciosacometida and seraco.idcuotaacometida = cuo.idcuota_acometida;");
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
        public Boolean InsertConsumo()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into servicios(idcliente,idcolonia,fecha_apertura,estado,comentario, idconsumo)");
            sentencia.Append("Values (" + this.IdCliente + ",");
            sentencia.Append(" " + this.IdColonia + ", ");
            sentencia.Append(" '" + this.FechaApertura.ToString("yyyy,MM,dd") + "', ");
            sentencia.Append(" '" + this.Estado + "', ");
            sentencia.Append(" '" + this.Comentario + "', ");
            sentencia.Append(" (select last_insert_id() from serviciosconsumo limit 1) );");
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
    }
}
