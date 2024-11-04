using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
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

        public DataTable ConsultarCon(int idcliente)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, concat(cl.nombres,\" \", cl.apellidos)as cliente,ser.idcliente, ser.idconsumo, cuo.idcuotaconsumo, cuo.monto, col.Colonia, ");
            sentencia.Append(" col.idcolonia, ser.fecha_apertura, ser.estado, ser.comentario, ser.cuotas_anticipadas from servicios ser, clientes cl, colonias col,");
            sentencia.Append("cuotasconsumo cuo, serviciosconsumo sercon  where ser.idcliente=@idcliente and ser.idcliente=cl.idcliente and ");
            sentencia.Append("col.idcolonia=ser.idcolonia and ser.idconsumo = sercon.idserviciosconsumo and sercon.idcuotaconsumo=cuo.idcuotaconsumo;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idcliente", idcliente);
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
        public DataTable ConsultarAco(int idcliente)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, concat(cl.nombres, \" \", cl.apellidos) as cliente, ser.idacometida, cuo.idcuotaacometida, cuo.monto, col.Colonia, col.idcolonia, ser.fecha_apertura, ser.estado, ser.Comentario, ");
            sentencia.Append("seraco.saldo, seraco.monto as 'total', (seraco.numerocuotas - seraco.cuotas_pagadas) as cuotas_restantes, seraco.idserviciosacometida ");
            sentencia.Append("from servicios ser, clientes cl, colonias col, cuotasacometida cuo, serviciosacometida seraco ");
            sentencia.Append("where ser.idcliente = @idcliente and ser.idcliente = cl.idcliente and col.idcolonia = ser.idcolonia and ser.idacometida = seraco.idserviciosacometida and seraco.idcuotaacometida = cuo.idcuotaacometida;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idcliente", idcliente);
            try
            {
                return operacion.Consultar(sentencia.ToString(), dic);
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
            Dictionary<string, object> dic = new Dictionary<string, object>();
            sentencia.Append("insert into servicios(idcliente,idcolonia,fecha_apertura,estado,comentario, idconsumo)");
            sentencia.Append("Values (@idcliente,");
            sentencia.Append(" @idcolonia, ");
            sentencia.Append(" @fecha, ");
            sentencia.Append(" @estado, ");
            sentencia.Append(" @comentario, ");
            switch (tipo)
            {
                case "consumo":
                    sentencia.Append(" @idconsumo );");
                    dic.Add("idconsumo", IdConsumo);
                    break;
                case "acometida":
                    sentencia.Replace("idconsumo", "idacometida");
                    sentencia.Append(" @idacometida );");
                    dic.Add("idacometida", IdAcometida);
                    break;
            }
            dic.Add("fecha", FechaApertura);
            dic.Add("comentario", Comentario);
            dic.Add("estado", Estado);
            dic.Add("idcolonia", IdColonia);
            dic.Add("idcliente", IdCliente);
            try
            {
                return operacion.Insertar(sentencia.ToString(), dic);
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
            sentencia.Append("idcolonia =@idcolonia, ");
            sentencia.Append("estado = @estado, ");
            sentencia.Append("comentario = @comentario, ");
            sentencia.Append("idcolonia = @idcolonia, ");
            sentencia.Append("cuotas_anticipadas =@cuotas_anticipadas ");
            sentencia.Append("where idservicio= @idservicio;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("fecha", FechaApertura);
            dic.Add("comentario", Comentario);
            dic.Add("estado", Estado);
            dic.Add("idcolonia", IdColonia);
            dic.Add("idcliente", IdCliente);
            try { return operacion.Actualizar(sentencia.ToString(), dic); } catch (Exception e) { return false; }
        }

        public Boolean CambiarEstado()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update servicios set ");
            sentencia.Append("estado = @estado ");
            sentencia.Append("where idservicio= @idservicio;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("estado", Estado);
            dic.Add("idservicio", IdServicio);
            try { return operacion.Actualizar(sentencia.ToString(), dic); } catch (Exception e) { return false; }
        }
        public Boolean InsertAcometida()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into servicios(idcliente,idcolonia,fecha_apertura,estado,comentario, idacometida)");
            sentencia.Append("Values (@idcliente,");
            sentencia.Append(" @idcolonia, ");
            sentencia.Append(" @fecha, ");
            sentencia.Append(" @estado, ");
            sentencia.Append(" @comentario, ");
            sentencia.Append(" @idacometida );");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idcliente", IdCliente);
            dic.Add("fecha", FechaApertura);
            dic.Add("idcolonia", IdColonia);
            dic.Add("estado", Estado);
            dic.Add("comentario", Comentario);
            dic.Add("idacometida", IdAcometida);
            try
            {
                return operacion.Insertar(sentencia.ToString(), dic);
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
            StringBuilder sentencia = new StringBuilder();
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

        public Servicios ConsultarServicio()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idservicio, idcliente, idcolonia, fecha_apertura, cuotas_anticipadas, estado, comentario, ifnull(idacometida,0) as 'idacometida', ");
            sentencia.Append("ifnull(idconsumo,0) as 'idconsumo' from servicios where idservicio=@idserv;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idserv", IdServicio);
            try
            {
                Servicios servicio = new Servicios();
                DataRow rw = operacion.Consultar(sentencia.ToString(),dic).Rows[0];
                if (rw.ItemArray.Length > 0)
                {
                    servicio.IdServicio = int.Parse(rw.ItemArray[0].ToString());
                    servicio.IdCliente = int.Parse(rw.ItemArray[1].ToString());
                    servicio.IdColonia = int.Parse(rw.ItemArray[2].ToString());
                    servicio.FechaApertura = DateTime.Parse(rw.ItemArray[3].ToString());
                    servicio.CuotasAnticipadas = int.Parse(rw.ItemArray[4].ToString());
                    servicio.Estado = rw.ItemArray[5].ToString();
                    servicio.Comentario = rw.ItemArray[6].ToString();
                    servicio.IdConsumo = int.Parse(rw.ItemArray[8].ToString());
                    servicio.IdAcometida = int.Parse(rw.ItemArray[7].ToString());
                    return servicio;
                }
                else { return new Servicios(); }
            }
            catch (Exception e) { return new Servicios(); }
        }



        public bool ActualizarContAdelantadas()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update servicios set cuotas_anticipadas=cuotas_anticipadas-1 where idservicio=@idservicio;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idservicio", IdServicio);
            try
            {
                return operacion.Actualizar(sentencia.ToString(), dic);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
        }


    }

}
