using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class ControlFechasFacturas
    {
        DateTime _FechaVencimiento;
        DateTime _FechaHasta;//hasta que dia se esta tomando en cuenta para realizar el cobro del consumo
        string _Mes;
        DateTime _FechaGeneracion;
        ControlFechasFacturas() { this.FechaGeneracion = DateTime.Now; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public DateTime FechaHasta { get => _FechaHasta; set => _FechaHasta = value; }
        public string Mes { get => _Mes; set => _Mes = value; }
        public DateTime FechaGeneracion { get => _FechaGeneracion; set => _FechaGeneracion = value; }

        public Boolean agregar() 
        {
            DBOperacion operacion=new DBOperacion();
            StringBuilder sentencia=new StringBuilder();
            sentencia.Append("insert into fecha_control_facturas into(");
            sentencia.Append("fecha_vencimiento, fecha_hasta, mes, fecha_generacion) Values(");
            sentencia.Append(this.FechaVencimiento.ToString("yyyy,MM,dd") + ", ");
            sentencia.Append(this.FechaHasta.ToString("yyy,MM,dd") + ", ");
            sentencia.Append(this.Mes + ", ");
            sentencia.Append(this.FechaGeneracion.ToString("yyyy,MM,dd") + ");");
            try { return operacion.Insertar(sentencia.ToString()); }
            catch(Exception ex) { return false; }
        }
    }
}
