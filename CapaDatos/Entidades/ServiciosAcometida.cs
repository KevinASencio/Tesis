﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class ServiciosAcometida
    {
        int _idserciciosacometida;
        int _idcuotaacometida;
        float _monto;
        int _cuotaspagadas;
        int _numeredecuotas;
        float _saldo;

        public int Idserciciosacometida { get => _idserciciosacometida; set => _idserciciosacometida = value; }
        public float Monto { get => _monto; set => _monto = value; }
        public int Cuotaspagadas { get => _cuotaspagadas; set => _cuotaspagadas = value; }
        public int Numeredecuotas { get => _numeredecuotas; set => _numeredecuotas = value; }
        public float Saldo { get => _saldo; set => _saldo = value; }
        public int Idcuotaacometida { get => _idcuotaacometida; set => _idcuotaacometida = value; }

        public Boolean agregar() 
        {
            bool resultado = false;
            DBOperacion operacion= new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into serviciosacometida (idcuotaacometida, monto,cuotas_pagadas,numerocuotas,saldo)");
            sentencia.Append("Values (" + this.Idcuotaacometida + ", ");
            sentencia.Append(" " + this.Monto +", ");
            sentencia.Append(" " + this.Cuotaspagadas + ", ");
            sentencia.Append(" " + this.Numeredecuotas + ", ");
            sentencia.Append(" " + this.Saldo + ");");
            
            try { 
                resultado = operacion.Insertar(sentencia.ToString());
                this.Idserciciosacometida = int.Parse(operacion.Consultar("select LAST_INSERT_ID() as \'id\' from serviciosacometida limit 1").Rows[0][0].ToString());
                return resultado;
            }
            catch (Exception ex) { return false; }
        }

        public Boolean Actualizar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update serviciosacometida set "); 
            sentencia.Append("idcuotaacometida=" + this.Idcuotaacometida + " ");
            sentencia.Append("where idserciviosacoemtida =" + this.Idserciciosacometida + "; ");

            try { return operacion.Actualizar(sentencia.ToString()); }catch(Exception ex){ return false; }
        }
    }
}
