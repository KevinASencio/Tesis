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
            Dictionary<string, object> dic = new Dictionary<string, object>();

            sentencia.Append("insert into movimientos(fecha, tipo, concepto, idcliente, monto,");
            sentencia.Append(" doc, idfactura, empleado, emisor, idcontrol_banco, idcontrol_caja) values( ");
            sentencia.Append("@fecha, ");
            sentencia.Append("@tipo, ");
            sentencia.Append("@concepto, ");
            //valida si el valor es 0 puesto que esto generaria un error al hacer referencia a un registro con id=0 el cual no existe
            if (IdCliente == 0) { sentencia.Append("null, "); } else { sentencia.Append("@idcliente, "); dic.Add("idcliente", IdCliente); };
            sentencia.Append("@monto, ");
            sentencia.Append("@doc, ");
            //valida si el valor es 0 puesto que esto generaria un error al hacer referencia a un registro con id=0 el cual no existe
            if (IdFactura == 0) { sentencia.Append("null, "); } else { sentencia.Append("@idfactura, "); dic.Add("idfactura", IdFactura); }
            sentencia.Append("@empleado, ");
            sentencia.Append("@emisor,");
            //valida si el valor es 0 puesto que esto generaria un error al hacer referencia a un registro con id=0 el cual no existe
            if (IdControlBanco == 0) { sentencia.Append("null , @idcontrolcaja);");dic.Add("idcontrolcaja", IdControlCaja); }
            else { sentencia.Append("@idcontrolbanco, null);"); dic.Add("idcontrolbanco", IdControlBanco); }
            dic.Add("fecha", Fecha);
            dic.Add("tipo", Tipo);
            dic.Add("concepto", Concepto);
            dic.Add("monto", Monto);
            dic.Add("doc", Doc);
            dic.Add("empleado", Empleado);
            dic.Add("emisor", Emisor);

            try
            {
                return operacion.Insertar(sentencia.ToString(),dic);
            }
            catch (Exception ex) { return false; }
        }

        public bool Actualizar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update movimientos set ");
            sentencia.Append("fecha = @fecha, ");
            sentencia.Append("tipo = @tipo', ");
            sentencia.Append("concepto =@concepto, ");
            sentencia.Append("idcliente = @idcliente, ");
            sentencia.Append("monto = @monto, ");
            sentencia.Append("idcontrol_banco =@idcaja, ");
            sentencia.Append("idcontrol_caja =@idbanco, ");
            sentencia.Append("doc = @doc, ");
            sentencia.Append("idfactura = @idfactura, ");
            sentencia.Append("empleado =@empleado, ");
            sentencia.Append("emisor = @emisor where idmovimiento=@idmovimiento;");
            Dictionary<string, object> dic = new Dictionary<string, object>();

            dic.Add("fecha", Fecha);
            dic.Add("tipo", Tipo);
            dic.Add("concepto", Concepto);
            dic.Add("monto", Monto);
            dic.Add("doc", Doc);
            dic.Add("empleado", Empleado);
            dic.Add("emisor", Emisor);
            dic.Add("idcliente", IdCliente);
            dic.Add("idcaja", IdControlCaja);
            dic.Add("idbanco", IdControlBanco);
            dic.Add("idfactura", IdFactura);
            dic.Add("idmovimiento", IdMovimiento);
            try
            {
                return operacion.Actualizar(sentencia.ToString(),dic);
            }
            catch (Exception ex) { return false; }
        }
    }
}
