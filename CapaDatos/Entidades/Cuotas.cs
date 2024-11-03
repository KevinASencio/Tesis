using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

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
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select cuota from cuotasconsumo where idcuotaconsumo= " + id + ";");
            try
            {
                return double.Parse(operacion.Consultar(sentencia.ToString()).Rows[0][0].ToString());
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 0; }
        }

        public static double ConsultarCuota(int idconsumo, int idacometida)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            if (idconsumo > 0)
            {
                sentencia.Append("select cuo.monto from cuotasconsumo as cuo, serviciosconsumo as serv where serv.idserviciosconsumo=" + idconsumo + " and serv.idcuotaconsumo=cuo.idcuotaconsumo;");
            }
            else
            {
                sentencia.Append("select cuo.monto from cuotasacometida as cuo, serviciosacometida as serv where serv.idserviciosacometida=" + idacometida + " and serv.idcuotaacometida=cuo.idcuotaacometida;");
            }
            try { return double.Parse(operacion.Consultar(sentencia.ToString()).Rows[0][0].ToString()); } catch (Exception ex) { }
            return 0;
        }

        public bool InsertarCuotaCon()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into cuotasconsumo  (monto) values (" + this.Monto + ")");
            try { return operacion.Insertar(sentencia.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        public bool InsertarCuotaAcometida()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into cuotasacometida  (monto) values (" + this.Monto + ")");
            try { return operacion.Insertar(sentencia.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        public bool ActualizarCuotaCon()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update cuotasconsumo set monto= " + this.Monto + " where idcuotaconsumo = " + this.IdCuota + ";");
            try { return operacion.Insertar(sentencia.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        public bool ActualizarCuotaAco()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update cuotasacometida set monto= " + this.Monto + " where idcuotaacometida = " + this.IdCuota + ";");
            try { return operacion.Insertar(sentencia.ToString()); } catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
    }
}
