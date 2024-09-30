using System;
using System.Text;

namespace CapaDatos.Entidades
{
    public class ControlFechasFacturas
    {
        int _IdControl;
        DateTime _FechaVencimiento;
        DateTime _FechaHasta;//hasta que dia se esta tomando en cuenta para realizar el cobro del consumo
        string _Mes;
        DateTime _FechaGeneracion;
        public ControlFechasFacturas() { this.FechaGeneracion = DateTime.Now; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public DateTime FechaHasta { get => _FechaHasta; set => _FechaHasta = value; }
        public string Mes { get => _Mes; set => _Mes = value; }
        public DateTime FechaGeneracion { get => _FechaGeneracion; set => _FechaGeneracion = value; }
        public int IdControl { get => _IdControl; set => _IdControl = value; }

        public Boolean agregar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            bool resultado = false;
            sentencia.Append("Agregar into fecha_control_facturas (");
            sentencia.Append("fecha_vencimiento, fecha_hasta, mes, fecha_generacion) Values(");
            sentencia.Append("'" + this.FechaVencimiento.ToString("yyyy-MM-dd") + "', ");
            sentencia.Append("'" + this.FechaHasta.ToString("yyy-MM-dd") + "', ");
            sentencia.Append("'" + this.Mes + "', ");
            sentencia.Append("'" + this.FechaGeneracion.ToString("yyyy-MM-dd") + "');");
            try
            {
                resultado = operacion.Insertar(sentencia.ToString());
                if (resultado == true)
                {
                    this.IdControl = int.Parse(operacion.Consultar("select LAST_INSERT_ID() from fecha_control_facturas limit 1").Rows[0][0].ToString());
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { return false; }
        }
    }
}
