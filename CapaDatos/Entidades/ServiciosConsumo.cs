using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                
                this.IdServicioConsumo= int.Parse(operacion.Consultar("select LAST_INSERT_ID() as \'id\' from serviciosconsumo limit 1").Rows[0][0].ToString());
                return resultado;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
