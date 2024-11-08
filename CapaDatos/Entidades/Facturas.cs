using MySqlX.XDevAPI;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
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

        public Facturas() 
        {
            Comentario = string.Empty;
            EstadoPago = string.Empty;
            Estado = string.Empty;
        }

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
        public DataTable ConsultarGenrarCon()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, ser.estado, ser.cuotas_anticipadas, cuo.monto, cl.idcliente ");
            sentencia.Append("from servicios ser, clientes cl, cuotasconsumo cuo, serviciosconsumo sercon ");
            sentencia.Append(" where ser.idcliente=cl.idcliente and ser.idconsumo = sercon.idserviciosconsumo and ");
            sentencia.Append(" sercon.idcuotaconsumo=cuo.idcuotaconsumo and ser.estado='Activo'; ");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex) { return null; }
        }
        //consultar lista de servicios que no se ha creado factura previa

        public DataTable ConsultarGenrarAco()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select ser.idservicio, ser.estado, ser.cuotas_anticipadas, cuo.monto, cl.idcliente ");
            sentencia.Append("from servicios ser, clientes cl, cuotasacometida cuo, serviciosacometida seraco ");
            sentencia.Append("where ser.idcliente=cl.idcliente and ser.idacometida = seraco.idserviciosacometida and ");
            sentencia.Append("seraco.idcuotaacometida=cuo.idcuotaacometida and ser.estado='Activo'; ");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex) { return null; }
        }
        public DataTable GenerarFacturasConsumo(int idcontrol, double mora, ProgressBar g, Label conta)
        {
           
            /*Datatable, si aparece algun error en tiempo de ejecución se procede a agregar
            la factura para devolver cono resulatdo la lista de facturas que no fueron posibles crear las siguientes
            ejemplo: si se esta generando la facturación para el mes de febrero pero una de estas da error se agrega a Result 
            la factura anterior a la que no se pudo generar en este caso enero
             */
            DataTable Resultado = new DataTable();
            DataTable ListaServicios = new DataTable();
            ListaServicios = ConsultarGenrarCon();
            g.Maximum = (Servicios.ConsulTotal()) * 5;
            MessageBox.Show(Servicios.ConsulTotal().ToString());
            string aux = "/" + (Servicios.ConsulTotal()).ToString();
            //contador de control de facturas con error al crearlas 
            int cont = 0;
            //contador de las facturas que se procesaron con o sin error
            int i = 0;
            //creacion de facturas, se consulta la ultima factura para los servicios que se encuentran activos 
            foreach (DataRow rw in ListaServicios.Rows)
            {
                //si el servicio no cueta con facturas pagadas de forma adelantada 
                if (int.Parse(rw.ItemArray[2].ToString()) == 0)
                {
                    Facturas Fac = new Facturas();
                    Fac = ConsultarFacturaServicio(rw.ItemArray[0].ToString());
                    //generar factura nueva si la factura anterior ya fue cancelada
                    if (Fac.EstadoPago.Equals("Cancelado") | Fac.EstadoPago.Length==0)
                    {
                        Fac = new Facturas();
                        Fac.Saldo = double.Parse(rw.ItemArray[3].ToString());
                        Fac.Mora = 0;
                        Fac.IdControlFecha = idcontrol;
                        Fac.ContPendientes = 0;
                        Fac.Comentario = "";
                        Fac.IdServicio = int.Parse(rw.ItemArray[0].ToString());
                        Fac.Estado = "Valida";
                        Fac.EstadoPago = "Pendiente";
                        try
                        {
                            if (!Fac.Insertar()) { Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                        }
                        catch
                        {
                            Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++;
                        }
                    }
                    else //generar factura si la factura anterior no fue cancelada
                    {
                        Fac.Estado = "Transferida";
                        if (Fac.Actualzar())
                        {
                            Fac.Saldo +=  double.Parse(rw.ItemArray[3].ToString());
                            Fac.Mora += mora;
                            Fac.ContPendientes += 1;
                            Fac.IdControlFecha = idcontrol;
                            Fac.Estado = "Valida";
                            Fac.EstadoPago = "Pendiente";
                            try
                            {
                                if (!Fac.Insertar()) { Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                            }
                            catch
                            {
                                Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++;
                            }
                        }
                    }
                }
                else //si el servicio tiene facturas adelantadas canceladas
                {
                    Servicios servicio = new Servicios();
                    servicio.IdServicio = int.Parse(rw.ItemArray[0].ToString());
                    servicio.ActualizarContAdelantadas();
                }
                i++;
                g.Value = i * 5;
                conta.Text = i + aux;
                conta.Refresh();
            }
            return Resultado;
        }

        public DataTable GenerarFacturasAcometida(int idcontrol, double mora, ProgressBar g, Label conta)
        {
            /*Datatable, si aparece algun error en tiempo de ejecución se procede a agregar
            la factura para devolver cono resulatdo la lista de facturas que no fueron posibles crear las siguientes
            ejemplo: si se esta generando la facturación para el mes de febrero pero una de estas da error se agrega a Result 
            la factura anterior a la que no se pudo generar en este caso enero
             */
            DataTable Resultado = new DataTable();
            DataTable ListaServicios = new DataTable();
            ListaServicios = ConsultarGenrarAco();
            int cont = 0;
            //variable para controlar el numero de facturas que han sido procesadas, para esto se utiliza el valor de la barra de porgreso entre 5, que nos da como resultado el valor de las facturas procesadas
            //el valir de g.value= Numero de facturas * 5

            int procesadas = g.Value / 5;
            string aux = "/" + (g.Maximum / 5).ToString();
            //creacion de facturas, se consulta la ultima factura para los servicios que se encuentran activos 
            foreach (DataRow rw in ListaServicios.Rows)
            {
                //si el servicio no cueta con facturas pagadas de forma adelantada 
                if (int.Parse(rw.ItemArray[2].ToString()) == 0)
                {
                    Facturas Fac = ConsultarFacturaServicio(rw.ItemArray[0].ToString());
                    //generar factura nueva si la factura anterior ya fue cancelada
                    if (Fac.EstadoPago.Equals("Cancelado") | Fac.EstadoPago.Length==0)
                    {
                        Fac = new Facturas();
                        Fac.Saldo = double.Parse(rw.ItemArray[3].ToString());
                        Fac.Mora = 0;
                        Fac.IdControlFecha = idcontrol;
                        Fac.ContPendientes = 0;
                        Fac.Comentario = "";
                        Fac.IdServicio = int.Parse(rw.ItemArray[0].ToString());
                        Fac.Estado = "Valida";
                        Fac.EstadoPago = "Pendiente";
                        try
                        {
                            if (!Fac.Insertar()) { Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                        }
                        catch
                        {
                            Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++;
                        }
                    }
                    else //generar factura si la factura anterior no fue cancelada
                    {
                        Fac.Estado = "Transferida";
                        if (Fac.Actualzar())
                        {
                            Fac.Saldo +=  double.Parse(rw.ItemArray[3].ToString());
                            Fac.Mora += mora;
                            Fac.ContPendientes += 1;
                            Fac.IdControlFecha = idcontrol;
                            Fac.Estado = "Valida";
                            Fac.EstadoPago = "Pendiente";
                            try
                            {
                                if (!Fac.Insertar()) { Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++; }
                            }
                            catch
                            {
                                Resultado.Rows.CopyTo(rw.ItemArray, cont); cont++;
                            }
                        }
                    }
                }
                else //si el servicio tiene facturas adelantadas canceladas 
                {
                    Servicios servicio = new Servicios();
                    servicio.IdServicio = int.Parse(rw.ItemArray[0].ToString());
                    servicio.ActualizarContAdelantadas();
                }
                procesadas++;
                g.Value = procesadas * 5;
                conta.Text = procesadas + aux;
                conta.Refresh();
            }
            return Resultado;
        }

        public Boolean ConsultarFactura(string idfactura)
        {
            //cambiar esto para usar diccionarios
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append(@"SELECT idfactura, saldo, mora, estado, estado_pago, idservicio, cont_pendiente, descuento, idcontrolfecha, comentario 
                                FROM db_acacuvan.facturas where idfactura= @idfactura;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idfactura", int.Parse(idfactura));
            try
            {
                DataRow rw = operacion.Consultar(sentencia.ToString(),dic).Rows[0];
                this.IdFactura = int.Parse(rw.ItemArray[0].ToString());
                this.Saldo = double.Parse(rw.ItemArray[1].ToString());
                this.Mora = double.Parse(rw.ItemArray[2].ToString());
                this.Estado = rw.ItemArray[3].ToString();
                this.EstadoPago = rw.ItemArray[4].ToString();
                this.IdServicio = int.Parse(rw.ItemArray[5].ToString());
                this.ContPendientes = int.Parse(rw.ItemArray[6].ToString());
                this.Descuento = double.Parse(rw.ItemArray[7].ToString());
                this.IdControlFecha = int.Parse(rw.ItemArray[8].ToString());
                this.Comentario = rw.ItemArray[9].ToString();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Facturas ConsultarFacturaServicio(string idservicio)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append(@"SELECT idfactura, saldo, mora, estado, estado_pago, idservicio, cont_pendiente, descuento, idcontrolfecha, comentario 
                                FROM db_acacuvan.facturas where idservicio= " + idservicio + "  order  by idfactura desc limit 1;");
            try
            {
                DataRow rw = operacion.Consultar(sentencia.ToString()).Rows[0];
                Facturas factura = new Facturas();
                factura.IdFactura = int.Parse(rw.ItemArray[0].ToString());
                factura.Saldo = double.Parse(rw.ItemArray[1].ToString());
                factura.Mora = double.Parse(rw.ItemArray[2].ToString());
                factura.Estado = rw.ItemArray[3].ToString();
                factura.EstadoPago = rw.ItemArray[4].ToString();
                factura.IdServicio = int.Parse(rw.ItemArray[5].ToString());
                factura.ContPendientes = int.Parse(rw.ItemArray[6].ToString());
                factura.Descuento = double.Parse(rw.ItemArray[7].ToString());
                factura.IdControlFecha = int.Parse(rw.ItemArray[8].ToString());
                factura.Comentario = rw.ItemArray[9].ToString();
                return factura;
            }
            catch (Exception ex)
            {
                return new Facturas();
            }
        }
        public Boolean Actualzar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update facturas set ");
            sentencia.Append("comentario = @comentario, ");
            sentencia.Append("descuento = @descuento, ");
            sentencia.Append("estado_pago=@estado_pago, ");
            sentencia.Append("estado=@estado, ");
            sentencia.Append("cont_pendiente=@cont_pendiente, ");
            sentencia.Append("idcontrolfecha=@idcontrol");
            sentencia.Append(" where idfactura=@idfactura;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("estado", Estado);
            dic.Add("estado_pago", EstadoPago);
            dic.Add("cont_pendiente", ContPendientes);
            dic.Add("descuento", Descuento);
            dic.Add("idcontrol", IdControlFecha);
            dic.Add("comentario", Comentario);
            dic.Add("idfactura", IdFactura);
            try
            {
                return operacion.Actualizar(sentencia.ToString(),dic);
            }
            catch (Exception ex) { return false; }
        }

        public Boolean Insertar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into facturas (saldo,mora,estado,estado_pago, idservicio, cont_pendiente, descuento,idcontrolfecha,comentario) values (");
            sentencia.Append(" @saldo, ");
            sentencia.Append(" @mora, ");
            sentencia.Append(" @estado, ");
            sentencia.Append(" @estado_pago, ");
            sentencia.Append(" @idservicio, ");
            sentencia.Append(" @cont_pendiente, ");
            sentencia.Append(" @descuento,");
            sentencia.Append(" @idcontrolfecha, ");
            sentencia.Append(" @comentario);");

            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("saldo",Saldo);
            dic.Add("mora",Mora);
            dic.Add("estado",Estado);
            dic.Add("estado_pago",EstadoPago);
            dic.Add("idservicio",IdServicio);
            dic.Add("cont_pendiente",ContPendientes);
            dic.Add("descuento",Descuento);
            dic.Add("idcontrolfecha",IdControlFecha);
            dic.Add("comentario",Comentario);
            try
            {
                //si la insertcion es un exito se ocnsulta el id de la factura que se acaba de ingresar y la asignamos al objeto que telaizao la insericon
                if (operacion.Insertar(sentencia.ToString(),dic))
                {
                    this.IdFactura = int.Parse(operacion.Consultar("select LAST_INSERT_ID() from facturas limit 1").Rows[0][0].ToString());
                    return true;
                }
                return false;
            }
            catch (Exception ex) { return false; }
        }

        public DataTable ConsultarFacServ(int idcliente) 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select fac.idfactura, fac.saldo, fac.mora, fac.estado, fac.estado_pago, ");
            sentencia.Append("fac.idservicio, fac.cont_pendiente, fac.idcontrolfecha, fac.comentario, fecha.fecha_vencimiento, fecha.mes ");
            sentencia.Append("from facturas fac, fecha_control_facturas fecha, servicios serv where ");
            sentencia.Append("fac.idcontrolfecha=fecha.idcontrol and fac.idservicio=serv.idservicio and ");
            sentencia.Append("serv.idcliente=@idcliente order by idfactura desc;");
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("idcliente",idcliente);
            try
            {
                return operacion.Consultar(sentencia.ToString(),dic);
            }
            catch (Exception ex) { return null; }

        }

        //consulta que se utilizara para realizar la impresion de reportes
        public DataTable ConsultarReporteGen(int idcontrol,int idcolonia) 
        {
            DBOperacion operacion =new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select fac.idfactura, serv.idcliente, concat(cli.nombres, ', ', cli.apellidos) as 'cliente', ctrl.fecha_hasta,ctrl.fecha_vencimiento, upper(ctrl.mes)as 'mes',(fac.saldo + fac.mora) as 'total', ");
            sentencia.Append("(fac.saldo / (fac.cont_pendiente + 1)) as 'cuota',fac.mora, fac.saldo, fac.cont_pendiente, col.colonia,fac.idservicio,if(isnull(serv.idconsumo),2,1) as 'tipo' from facturas fac inner join servicios serv on serv.idservicio = fac.idservicio ");
            sentencia.Append("inner join fecha_control_facturas ctrl on fac.idcontrolfecha = ctrl.idcontrol ");
            sentencia.Append("inner join colonias col on serv.idcolonia = col.idcolonia ");
            sentencia.Append("inner join clientes cli on serv.idcliente = cli.idcliente ");
            sentencia.Append(" where ctrl.idcontrol = @idcontrol and col.idcolonia=@idcolonia;");
            Dictionary <string,object> dic = new Dictionary<string,object>();
            dic.Add("idcontrol",idcontrol);
            dic.Add("idcolonia", idcolonia);
            try { return operacion.Consultar(sentencia.ToString(), dic); } catch { return new DataTable(); }
        }
        public DataTable ConsultarReporteBuscar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select fac.idfactura, serv.idcliente, concat(cli.nombres, ', ', cli.apellidos) as 'cliente', ctrl.fecha_hasta,ctrl.fecha_vencimiento, upper(ctrl.mes)as 'mes',(fac.saldo + fac.mora) as 'total', ");
            sentencia.Append("(fac.saldo / (fac.cont_pendiente + 1)) as 'cuota',fac.mora, fac.saldo, fac.cont_pendiente, col.colonia,fac.idservicio,if(isnull(serv.idconsumo),1,2) as 'tipo' from facturas fac inner join servicios serv on serv.idservicio = fac.idservicio ");
            sentencia.Append("inner join fecha_control_facturas ctrl on fac.idcontrolfecha = ctrl.idcontrol ");
            sentencia.Append("inner join colonias col on serv.idcolonia = col.idcolonia ");
            sentencia.Append("inner join clientes cli on serv.idcliente = cli.idcliente ");
            sentencia.Append(" where fac.idfactura=@idfactura");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("idfactura", IdFactura);
            try { return operacion.Consultar(sentencia.ToString(), dic); } catch { return new DataTable(); }
        }

        public DataTable ConsultarServPeligro(int maxpendientes)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("select fac.idfactura, serv.idcliente, concat(cli.nombres, ', ', cli.apellidos) as 'cliente', ctrl.fecha_hasta,ctrl.fecha_vencimiento, upper(ctrl.mes)as 'mes',(fac.saldo + fac.mora) as 'total', ");
            sentencia.Append("(fac.saldo / (fac.cont_pendiente + 1)) as 'cuota',fac.mora, fac.saldo, fac.cont_pendiente, col.colonia,fac.idservicio,if(isnull(serv.idconsumo),2,1) as 'tipo' from facturas fac inner join servicios serv on serv.idservicio = fac.idservicio ");
            sentencia.Append("inner join fecha_control_facturas ctrl on fac.idcontrolfecha = ctrl.idcontrol ");
            sentencia.Append("inner join colonias col on serv.idcolonia = col.idcolonia ");
            sentencia.Append("inner join clientes cli on serv.idcliente = cli.idcliente ");
            sentencia.Append(" where fac.cont_pendiente>@maxpendientes;");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("maxpendientes", maxpendientes);
            try { return operacion.Consultar(sentencia.ToString(), dic); } catch { return new DataTable(); }
        }
    }
}
