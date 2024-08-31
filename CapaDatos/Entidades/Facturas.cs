using System;
using System.Data;
using System.Text;
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
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
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
            }
            catch (Exception ex) { return null; }
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

        public DataTable GenerarFacturasConsumo(int idcontrol, double mora)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            /*Datatable, si aparece algun error en tiempo de ejecución se procede a agregar
            la factura para devolver cono resulatdo la lista de facturas que no fueron posibles crear las siguientes
            ejemplo: si se esta generando la facturación para el mes de febrero pero una de estas da error se agrega a Result 
            la factura anterior a la que no se pudo generar en este caso enero
             */
            DataTable Resultado = new DataTable();
            DataTable lista = new DataTable();
            lista = ConsultarGenrar();
            int cont = 0;
            //creacion de facturas, tomando en cuenta la informacion de las facturas de mes vencidos se recorre la lista de facturas pára acceder a la informacion necesaria para la creaciom de la factura
            //la insercion se hace factura por factura, de esta forma si surge un error con alguno no impide que las demas sean creadas
            foreach (DataRow rw in lista.Rows)
            {
                sentencia.Clear();
                //si esta pendiente se genera la nueva factura con los saldos pendientes
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
                        //si la creacion de la factura es exitosa entonces, se procede a cambiar de estado
                        //la factura del mes anterior, esto para indicar que la factura anterior no fue pagada y que el saldo de esta fue transferido a la nueva factura 
                        if (operacion.Insertar(sentencia.ToString())) { operacion.Actualizar("update facturas set estado='Transferida' where idfactura= " + rw.ItemArray[0] + ";"); }
                        else { Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                    }
                    catch (Exception ex)
                    {
                        Resultado.Rows.CopyTo(rw.ItemArray, cont);
                        cont++;
                    }
                }
                else //creacion de la factura si la factura anterior al servicio fue cancelada
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
                        if (!operacion.Insertar(sentencia.ToString())) { Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                    }
                    catch (Exception ex)
                    {
                        Resultado.Rows.CopyTo(rw.ItemArray, cont);
                        cont++;
                    }
                }
            }
            //crear faturas de los servicios los cuales aun no cuentan con una factura previa

            lista.Clear();

            lista = operacion.Consultar(@"select serv.idservicio,cuo.monto from servicios serv, cuotasconsumo cuo, serviciosconsumo con 
                                            where con.idcuotaconsumo=cuo.idcuotaconsumo and serv.idconsumo=con.idserviciosconsumo and serv.idservicio 
                                            not in(select fac.idservicio from facturas fac where fac.idservicio=serv.idservicio and fac.idcontrolfecha=" + (int)(idcontrol-1) + ");");
            
            if (lista.Rows.Count > 0)
            {
                foreach (DataRow rw in lista.Rows)
                {
                    sentencia.Clear();
                    sentencia.Append("insert into facturas (saldo, mora, estado, estado_pago, idservicio, cont_pendiente, idcontrolfecha)");
                    sentencia.Append("values (");
                    sentencia.Append(double.Parse(rw.ItemArray[1].ToString()) + ", ");
                    sentencia.Append("0.00, ");
                    sentencia.Append("'Valida', ");
                    sentencia.Append("'Pendiente', ");
                    sentencia.Append(rw.ItemArray[0].ToString() + ", ");
                    sentencia.Append("0, ");
                    sentencia.Append(idcontrol + ")");
                    try
                    {
                        if (!operacion.Insertar(sentencia.ToString()))
                        {
                            MessageBox.Show("Error al crear facturas para el servicio N°" + rw.ItemArray[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error al crear facturas para el servicio N°" + rw.ItemArray[0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                }
            }
            return Resultado;
        }

        public DataTable GeneraraFacturasAcom()
        {
            return null;
        }


    }
}
