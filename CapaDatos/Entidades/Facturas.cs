using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Entidades
{
    public class Facturas
    {
        int _IdFactura;
        int _IdServicio;
        int _ContPendientes;
        int _IdControlFecha;
        double _Saldo;
        double _Mora;
        double _Descuento;
        string _Estado;
        string _EstadoPago;
        string _Comentario;

        public int IdFactura { get => _IdFactura; set => _IdFactura = value; }
        public int IdServicio { get => _IdServicio; set => _IdServicio = value; }
        public int ContPendientes { get => _ContPendientes; set => _ContPendientes = value; }
        public int IdControlFecha { get => _IdControlFecha; set => _IdControlFecha = value; }
        public double Saldo { get => _Saldo; set => _Saldo = value; }
        public double Mora { get => _Mora; set => _Mora = value; }
        public double Descuento { get => _Descuento; set => _Descuento = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string EstadoPago { get => _EstadoPago; set => _EstadoPago = value; }
        public string Comentario { get => _Comentario; set => _Comentario = value; }

        public DataTable Consultar() 
        {
            DBOperacion operacion= new DBOperacion();
            StringBuilder sentencia= new StringBuilder();
            sentencia.Append(" select fact.idfactura, fact.saldo,fact.mora, fact.estado, fact.estado_pago, fact.idservicio, ");
            sentencia.Append("fact.cont_pendiente, fact.descuento, fact.idcontrolfecha, fact.comentario, ");
            sentencia.Append("concat(cli.nombres, \" \" , cli.apellidos) as 'cliente' from facturas as fact, servicios as ");
            sentencia.Append("serv, clientes as cli, serviciosconsumo as con ");
            sentencia.Append("where fact.idservicio = serv.idservicio and cli.idcliente = serv.idcliente and ");
            sentencia.Append("serv.idconsumo = con.idserviciosconsumo and  ");
            sentencia.Append("fact.idcontrolfecha = (select idcontrol from fecha_control_factura order by idcontrol desc limit 1);");
            try 
            {
                return operacion.Consultar(sentencia.ToString());
            } catch (Exception ex) { return null; }
        }
        //obtiene las facturas con la informacion necesaria para generar las facturas del mes
        public DataTable ConsultarGenrar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append(" select fact.idfactura, fact.saldo,fact.mora, fact.estado, fact.estado_pago, fact.idservicio, ");
            sentencia.Append("fact.cont_pendiente, fact.descuento, fact.idcontrolfecha, fact.comentario, cuo.monto as cuota ");
            sentencia.Append(" from facturas as fact, servicios as ");
            sentencia.Append("serv, clientes as cli, serviciosconsumo as con, cuotasconsumo as cuo ");
            sentencia.Append("where fact.idservicio = serv.idservicio and cli.idcliente = serv.idcliente and ");
            sentencia.Append("serv.idconsumo = con.idserviciosconsumo and cuo.idcuotaconsumo = con.idcuotaconsumo and fact.estado='Valida' and ");
            sentencia.Append("fact.idcontrolfecha = (select idcontrol from fecha_control_facturas order by idcontrol desc limit 1 offset 1);");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex) { return null; }
        }
        public DataTable GenerarFacturas(int idcontrol, double mora)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            DataTable Result = new DataTable();
            DataTable facturas = new DataTable();
            facturas = ConsultarGenrar();
            int cont = 0;
            foreach (DataRow rw in facturas.Rows)
            {

                sentencia.Clear();
                if (rw.ItemArray[4].ToString().ToLower() == "pendiente")
                {
                    sentencia.Append("insert into facturas (saldo, mora, estado, estado_pago, idservicio, cont_pendiente, idcontrolfecha)");
                    sentencia.Append("values (");
                    sentencia.Append((double.Parse(rw.ItemArray[1].ToString()) + double.Parse(rw.ItemArray[10].ToString())) + ", ");
                    sentencia.Append((double.Parse(rw.ItemArray[2].ToString()) + mora) + ", ");
                    sentencia.Append("'Valida', ");
                    sentencia.Append("'Pendiente', ");
                    sentencia.Append(rw.ItemArray[5].ToString() + ", ");
                    sentencia.Append((int.Parse(rw.ItemArray[6].ToString()) + 1) + ", ");
                    sentencia.Append(idcontrol + ")");
                    try
                    {
                        if (operacion.Insertar(sentencia.ToString())) { operacion.Actualizar("update facturas set estado='Transferida' where idfactura= " + rw.ItemArray[0] + ";"); }
                        else { Result.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                    }
                    catch (Exception ex)
                    {
                        Result.Rows.CopyTo(rw.ItemArray, cont);
                        cont++;
                    }
                } 
                else
                {
                    sentencia.Append("insert into facturas (saldo, mora, estado, estado_pago, idservicio, cont_pendiente, idcontrolfecha)");
                    sentencia.Append("values (");
                    sentencia.Append(double.Parse(rw.ItemArray[10].ToString()) + ", ");
                    sentencia.Append("0.00, ");
                    sentencia.Append("'Valida', ");
                    sentencia.Append("'Pendiente', ");
                    sentencia.Append(rw.ItemArray[5].ToString() + ", ");
                    sentencia.Append("0, ");
                    sentencia.Append(idcontrol + ")");
                    try
                    {
                        if (!operacion.Insertar(sentencia.ToString())) { Result.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                    }
                    catch (Exception ex)
                    {
                        Result.Rows.CopyTo(rw.ItemArray, cont);
                        cont++;
                    }
                }
            }
            return Result;
        }


    }
}
