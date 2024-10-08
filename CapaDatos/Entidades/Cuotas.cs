using System;
using System.Data;
using System.Text;

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
            sentencia.Append("select idcuotaacometida, monto from cuotasacometida;");
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

        public static double ConsultarCuotaConsumo(int id) 
        {
            DBOperacion operacion= new DBOperacion();
            StringBuilder sentencia= new StringBuilder();
            sentencia.Append("select cuota from cuotasconsumo where idcuotaconsumo= " + id + ";");
            try 
            {
                return double.Parse(operacion.Consultar(sentencia.ToString()).Rows[0][0].ToString());
            }catch (Exception ex) { return 0; Console.WriteLine(ex.Message); }
        }

    }
}
