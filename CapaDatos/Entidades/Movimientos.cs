using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Movimientos
    {
        int _IdMovimiento;
        DateTime _Fecha;
        string _Tipo;
        string _Concepto;
        int _IdCliente;
        double _Monto;
        int _IdControlBanco;
        int _IdControlCaja;
        string _Doc;
        int _IdFactura;
        string _Empleado;
        string emisor;

        public int IdMovimiento { get => _IdMovimiento; set => _IdMovimiento = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Concepto { get => _Concepto; set => _Concepto = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public double Monto { get => _Monto; set => _Monto = value; }
        public int IdControlBanco { get => _IdControlBanco; set => _IdControlBanco = value; }
        public int IdControlCaja { get => _IdControlCaja; set => _IdControlCaja = value; }
        public string Doc { get => _Doc; set => _Doc = value; }
        public int IdFactura { get => _IdFactura; set => _IdFactura = value; }
        public string Empleado { get => _Empleado; set => _Empleado = value; }
        public string Emisor { get => emisor; set => emisor = value; }

        public bool Insertar() 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();

            sentencia.Append("insert into movimientos(fecha, tipo, concepto, idcliente, monto,");
            sentencia.Append(" doc, idfactura, empleado, emisor, idcontrol_banco, idcontrol_caja) values( ");
            sentencia.Append("'" + this.Fecha.ToString("yyyy-MM-dd hh:mm:ss") + "', ");
            sentencia.Append("'" + this.Tipo + "', ");
            sentencia.Append("'" + this.Concepto + "', ");
            //valida si el valor es 0 puesto que esto generaria un error al hacer referencia a un registro con id=0 el cual no existe
            if (IdCliente == 0) { sentencia.Append("null, "); } else { sentencia.Append(IdCliente + ", "); };
            sentencia.Append(this.Monto + ", ");
            sentencia.Append("' " + this.Doc + "', ");
            //valida si el valor es 0 puesto que esto generaria un error al hacer referencia a un registro con id=0 el cual no existe
            if (IdFactura == 0) { sentencia.Append("null, "); } else { sentencia.Append(this._IdFactura + ", ");}
            sentencia.Append("'"+this.Empleado + "', ");
            sentencia.Append("'" + this.emisor + "',");
            //valida si el valor es 0 puesto que esto generaria un error al hacer referencia a un registro con id=0 el cual no existe
            if (IdControlBanco == 0) { sentencia.Append("null , " + this.IdControlCaja + ");"); }
            else { sentencia.Append("" + this.IdControlBanco + ", null);"); }
            try 
            {
                return operacion.Insertar(sentencia.ToString());
            }
            catch(Exception ex) { return false; }
        }

        public bool Actualizar() 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update movimientos set ");
            sentencia.Append("fecha = '" + this.Fecha.ToString("yyyy-MM-dd hh:mm:ss") + "', ");
            sentencia.Append("tipo = '" + this.Tipo + "', ");
            sentencia.Append("concepto = '" + this.Concepto + "', ");
            sentencia.Append("idcliente = " + IdCliente + ", ");
            sentencia.Append("monto = " + this.Monto + ", ");
            sentencia.Append("idcontrol_banco =" + this.IdControlBanco + ", ");
            sentencia.Append("idcontrol_caja = " + this.IdControlCaja + ", ");
            sentencia.Append("doc = '" + this.Doc + "', ");
            sentencia.Append("idfactura = " + this._IdFactura + ", ");
            sentencia.Append("empleado = '" + this.Empleado + "', ");
            sentencia.Append("emisor = '" + this.emisor + "' where idmovimiento=" + this.IdMovimiento + ";");

            try
            {
                return operacion.Actualizar(sentencia.ToString());
            }
            catch (Exception ex) { return false; }
        }
    }
}
