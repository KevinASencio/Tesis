using System;
using System.Text;

namespace CapaDatos.Entidades
{
    public class ServiciosConsumo
    {
        int _IdServicioConsumo;
        int _IdCuotaConsumo;

        public ServiciosConsumo(int IdCuota)
        {
            this.IdCuotaConsumo = IdCuota;
        }

        public ServiciosConsumo(int idservicio, int IdCuota)
        {
            this.IdServicioConsumo = idservicio;
            this.IdCuotaConsumo = IdCuota;
        }
        public int IdServicioConsumo { get => _IdServicioConsumo; set => _IdServicioConsumo = value; }
        public int IdCuotaConsumo { get => _IdCuotaConsumo; set => _IdCuotaConsumo = value; }

        public Boolean insertar()
        {
            Boolean resultado = false;
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into serviciosconsumo(idcuotaconsumo) ");
            sentencia.Append("Values ( " + IdCuotaConsumo + ");");
            try
            {
                resultado = operacion.Insertar(sentencia.ToString());
                this.IdServicioConsumo = int.Parse(operacion.Consultar("select LAST_INSERT_ID() from serviciosconsumo limit 1").Rows[0][0].ToString());
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public Boolean actualizarConsumo()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update serviciosconsumo set ");
            sentencia.Append("idcuotaconsumo = " + this.IdCuotaConsumo + " ");
            sentencia.Append("where idserviciosconsumo = " + this.IdServicioConsumo + ";");
            try { return operacion.Actualizar(sentencia.ToString()); } catch (Exception ex) { return false; }
        }
    }
}
