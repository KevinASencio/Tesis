﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Entidades
{
    public class ControlMensualCaja
    {
        int _IdControlCaja;
        DateTime _FechaInicio;
        DateTime _FechaCierre;
        double _SaldoInicial;
        double _SaldoFinal;

        public int IdControlCaja { get => _IdControlCaja; set => _IdControlCaja = value; }
        public DateTime FechaInicio { get => _FechaInicio; set => _FechaInicio = value; }
        public DateTime FechaCierre { get => _FechaCierre; set => _FechaCierre = value; }
        public double SaldoInicial { get => _SaldoInicial; set => _SaldoInicial = value; }
        public double SaldoFinal { get => _SaldoFinal; set => _SaldoFinal = value; }

        public void Consultar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcontrol_caja, fecha_inicio, fecha_cierre, saldoinicial, saldofinal ");
            sentencia.Append("from control_mensual_caja order by idcontrol_caja Desc limit 1;");

            try
            {
                DataRow rw = operacion.Consultar(sentencia.ToString()).Rows[0];
                this.IdControlCaja = int.Parse(rw.ItemArray[0].ToString());
                this.FechaInicio = DateTime.Parse(rw.ItemArray[1].ToString());
                if (rw.ItemArray[2].ToString() != null) { this._FechaCierre = DateTime.Parse(rw.ItemArray[2].ToString()); }
                this.SaldoInicial = double.Parse(rw.ItemArray[3].ToString());
                this.SaldoFinal = double.Parse(rw.ItemArray[4].ToString());
            }
            catch (Exception ex) { }
        }

        public bool insertar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into control_mensual_caja (fecha_inicio, saldoinicial, saldofinal)");
            sentencia.Append("values(");
            sentencia.Append("'" + this.FechaInicio.ToString("yyyy-MM-dd") + "', ");
            sentencia.Append(this.SaldoInicial + ", ");
            sentencia.Append(this.SaldoFinal + ");");
            try { return operacion.Insertar(sentencia.ToString()); }catch (Exception ex) { return false; }
        }

        public bool ActualizarSaldoFinal()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("update control_mensual_caja set ");
            sentencia.Append(" saldofinal =" + this.SaldoFinal);
            sentencia.Append("where idcontrol_caja =" + this.IdControlCaja + ",");
            try { return operacion.Actualizar(sentencia.ToString()); }catch (Exception ex) { return false; }
        }
    }
}