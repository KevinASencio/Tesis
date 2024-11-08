﻿using Org.BouncyCastle.Asn1.Misc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Parametros
    {
        double _MoraConsumo;
        double _MoraAcometida;
        int _CuotasPenMax;

        public double MoraConsumo { get => _MoraConsumo; set => _MoraConsumo = value; }
        public double MoraAcometida { get => _MoraAcometida; set => _MoraAcometida = value; }
        public int CuotasPenMax { get => _CuotasPenMax; set => _CuotasPenMax = value; }

        public Parametros Consultar() 
        {
            DBOperacion operacion= new DBOperacion();
            StringBuilder sentencia= new StringBuilder();
            sentencia.Append("select MoraConsumo, MoraAcometida, cuotasPenMax from parametros;");
            try
            {
                DataTable dt = operacion.Consultar(sentencia.ToString());
                Parametros parametro= new Parametros();
                parametro.MoraConsumo = double.Parse(dt.Rows[0][0].ToString());
                parametro.MoraAcometida = double.Parse(dt.Rows[0][1].ToString());
                parametro.CuotasPenMax = int.Parse(dt.Rows[0][2].ToString());
                return parametro;
            }
            catch (Exception ex) { return null; }
        }

        public DataTable ConsultarParametro()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select MoraConsumo, MoraAcometida, cuotasPenMax from parametros;");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex) { return new DataTable(); }
        }

        public Boolean Actualizar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("update parametros set");
            sentencia.Append(" MoraConsumo=@moraconsumo,");
            sentencia.Append(" MoraAcometida=@moraacometida,");
            sentencia.Append(" cuotasPenMax=@contmax where id=1;");
            Dictionary<string,object> dic= new Dictionary<string,object>();
            dic.Add("moraconsumo", MoraConsumo);
            dic.Add("moraacometida", MoraAcometida);
            dic.Add("contmax", CuotasPenMax);
            try { return operacion.Actualizar(sentencia.ToString(), dic); } catch { return false; }            
        }
    }
}
