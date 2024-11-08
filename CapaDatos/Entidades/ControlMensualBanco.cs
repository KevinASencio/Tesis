﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class ControlMensualBanco
    {
        int _IdControlBanco;
        DateTime _FechaInicio;
        DateTime _FechaCierre;
        double _SaldoInicial;
        double _SaldoFinal;

        public int IdControlBanco { get => _IdControlBanco; set => _IdControlBanco = value; }
        public DateTime FechaInicio { get => _FechaInicio; set => _FechaInicio = value; }
        public DateTime FechaCierre { get => _FechaCierre; set => _FechaCierre = value; }
        public double SaldoInicial { get => _SaldoInicial; set => _SaldoInicial = value; }
        public double SaldoFinal { get => _SaldoFinal; set => _SaldoFinal = value; }

        public void Consultar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcontrol_banco, fecha_inicio, fecha_cierre, saldoinicial, saldofinal ");
            sentencia.Append("from control_mensual_banco order by idcontrol_banco Desc limit 1;");

            try
            {
                DataRow rw = operacion.Consultar(sentencia.ToString()).Rows[0];
                this.IdControlBanco = int.Parse(rw.ItemArray[0].ToString());
                this.FechaInicio = DateTime.Parse(rw.ItemArray[1].ToString());
                if (rw.ItemArray[2].ToString().Length > 0) { this._FechaCierre = DateTime.Parse(rw.ItemArray[2].ToString()); }
                this.SaldoInicial = double.Parse(rw.ItemArray[3].ToString());
                this.SaldoFinal = double.Parse(rw.ItemArray[4].ToString());
            }
            catch (Exception ex) { }
        }
        public DataTable Consultar(int id)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcontrol_banco, fecha_inicio, fecha_cierre, saldoinicial, saldofinal ");
            sentencia.Append("from control_mensual_banco where idcontrol_banco=@idcontrol;");
            Dictionary<string,object> dic= new Dictionary<string,object>();
            dic.Add("idcontrol", id);
            try
            {
                return operacion.Consultar(sentencia.ToString(),dic);
            }
            catch (Exception ex) { return new DataTable(); }
        }

        public DataTable ConsultarRep()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcontrol_banco, fecha_inicio, fecha_cierre, saldoinicial, saldofinal ");
            sentencia.Append("from control_mensual_banco where idcontrol_banco=@idcontrol;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idcontrol", IdControlBanco);
            return operacion.Consultar(sentencia.ToString(), dic);
        }
        public bool insertar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into control_mensual_banco (fecha_inicio, saldoinicial, saldofinal)");
            sentencia.Append("values(");
            sentencia.Append(" @fecha_inicio, ");
            sentencia.Append(" @saldoinicial, ");
            sentencia.Append(" @saldofinal);");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("fecha_inicio", FechaInicio);
            dic.Add("saldoinicial", SaldoInicial);
            dic.Add("saldofinal", SaldoFinal);
            try { return operacion.Insertar(sentencia.ToString(),dic); } catch (Exception ex) { return false; }
        }

        public bool CierreMes()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("update control_mensual_banco set ");
            sentencia.Append(" fecha_cierre =@fecha");
            sentencia.Append(" where idcontrol_banco =@idcontrolbanco;");
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("fecha", DateTime.Now);
            dic.Add("idcontrolbanco", IdControlBanco);
            try { return operacion.Actualizar(sentencia.ToString(), dic); } catch (Exception ex) { return false; }
        }

        public DataTable ConsultarLista()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select banco.idcontrol_banco,upper(concat(DATE_FORMAT(DATE_ADD(banco.fecha_inicio, INTERVAL 10 DAY),'%M'),' - ',  ");
            sentencia.Append("year(DATE_ADD(banco.fecha_inicio, INTERVAL 10 DAY))))as 'periodo' from control_mensual_banco banco;");

            try
            {
                operacion.EjecutarProcedure("SET lc_time_names = 'es_ES';", new Dictionary<string, object>());
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex) { return new DataTable(); }
        }
    }
}
