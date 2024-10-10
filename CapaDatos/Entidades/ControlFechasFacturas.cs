using System;
using System.Data;
using System.Runtime.CompilerServices;
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

        public static ControlFechasFacturas ConsultarControlFecha(int idcontrol) 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcontrol, fecha_vencimiento, fecha_hasta, mes, fecha_generacion from fecha_control_facturas where idcontrol= " + idcontrol + ";");

            try 
            {
                ControlFechasFacturas ct = new ControlFechasFacturas();
                DataRow rw = operacion.Consultar(sentencia.ToString()).Rows[0];
                if (rw.ItemArray.Length > 0)
                {
                    ct.IdControl = int.Parse(rw.ItemArray[0].ToString());
                    ct.FechaVencimiento = DateTime.Parse(rw.ItemArray[1].ToString());
                    ct.FechaHasta = DateTime.Parse(rw.ItemArray[2].ToString());
                    ct.Mes = rw.ItemArray[3].ToString();
                    ct.FechaGeneracion = DateTime.Parse(rw.ItemArray[4].ToString());
                    return ct;
                }
                else { return null; }
            }
            catch (Exception ex) { return null; }
        }

        public static int ConsultarUltimoCtr() 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select idcontrol from fecha_control_facturas order by idcontrol desc limit 1;");
            try { return int.Parse(operacion.Consultar(sentencia.ToString()).Rows[0][0].ToString()); }
            catch (Exception ex) { return 0; }
        }
    }
}
