using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Entidades
{
    public class ServiciosAcometida
    {
        int _idserviciosacometida;
        int _idcuotaacometida;
        float _monto;
        int _cuotaspagadas;
        int _numeredecuotas;
        float _saldo;

        public int Idserviciosacometida { get => _idserviciosacometida; set => _idserviciosacometida = value; }
        public float Monto { get => _monto; set => _monto = value; }
        public int Cuotaspagadas { get => _cuotaspagadas; set => _cuotaspagadas = value; }
        public int Numeredecuotas { get => _numeredecuotas; set => _numeredecuotas = value; }
        public float Saldo { get => _saldo; set => _saldo = value; }
        public int Idcuotaacometida { get => _idcuotaacometida; set => _idcuotaacometida = value; }

        public Boolean Insertar()
        {
            bool resultado = false;
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into serviciosacometida (idcuotaacometida, monto,cuotas_pagadas,numerocuotas,saldo)");
            sentencia.Append("Values (@idcuotaacometida, ");
            sentencia.Append(" @monto, ");
            sentencia.Append(" @cuotaspagadas, ");
            sentencia.Append(" @ncuotas,");
            sentencia.Append(" @saldo);");
            Dictionary<string,object>  dic= new Dictionary<string,object>();
            dic.Add("idcuotaacometida", Idcuotaacometida);
            dic.Add("monto", Monto);
            dic.Add("cuotaspagadas", Cuotaspagadas);
            dic.Add("ncuotas", Numeredecuotas);
            dic.Add("saldo", Saldo);
            try
            {
                resultado = operacion.Insertar(sentencia.ToString(), dic);
                this.Idserviciosacometida = int.Parse(operacion.Consultar("select LAST_INSERT_ID() as \'id\' from serviciosacometida limit 1").Rows[0][0].ToString());
                return resultado;
            }
            catch (Exception ex) { return false; }
        }

        public Boolean Actualizar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update serviciosacometida set ");
            sentencia.Append("idcuotaacometida=@idcuotaacometida, ");
            sentencia.Append("saldo = @saldo, ");
            sentencia.Append("cuotas_pagadas =@cuotas_pagadas ");
            sentencia.Append("where idserviciosacometida =@idserviciosacometida; ");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idcuotaacometida", Idcuotaacometida);
            dic.Add("monto", Monto);
            dic.Add("cuotaspagadas", Cuotaspagadas);
            dic.Add("ncuotas", Numeredecuotas);
            dic.Add("saldo", Saldo);
            dic.Add("idserviciosacometida", Idserviciosacometida);

            try { return operacion.Actualizar(sentencia.ToString(), dic); } catch (Exception ex) { return false; }
        }
    }
}
