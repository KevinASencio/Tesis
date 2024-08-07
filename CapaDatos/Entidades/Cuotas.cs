﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Cuotas
    {
        int _IdCuota;
        float _Monto;

        public int IdCuota { get => _IdCuota; set => _IdCuota = value; }
        public float Monto { get => _Monto; set => _Monto = value; }

        public static DataTable consultarCuotasConsumo()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcuotaconsumo, monto from cuotasconsumo;");
            try
            {
                DBOperacion operacion = new DBOperacion();
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }

        public static DataTable consultarCuotasAcometida()
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcuotaacometida, monto from cuotasacoemtida;");
            try
            {
                DBOperacion operacion = new DBOperacion();
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }

    }
}
