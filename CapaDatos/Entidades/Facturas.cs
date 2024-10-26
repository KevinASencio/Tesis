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
        public DataTable ConsultarGenrarCon(int idcontrol)
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
        public DataTable ServiciosSinFacCon(int idcontrol)
        {
            DBOperacion operacion = new DBOperacion();
            try
            {
                return operacion.Consultar(@"select serv.idservicio,cuo.monto from servicios serv, cuotasconsumo cuo, serviciosconsumo con 
                                           where con.idcuotaconsumo=cuo.idcuotaconsumo and serv.idconsumo=con.idserviciosconsumo and serv.estado='activo' and serv.idservicio 
                                           not in(select fac.idservicio from facturas fac where fac.idservicio=serv.idservicio);");

            }
            catch (Exception ex) { return null; }

        }
        public DataTable ServiciosSinFacAco(int idcontrol)
        {
            DBOperacion operacion = new DBOperacion();
            try
            {
                return operacion.Consultar(@"select serv.idservicio,cuo.monto from servicios serv, cuotasacometida cuo, serviciosacometida aco
                                            where serv.idacometida=aco.idserviciosacometida and   aco.idcuotaacometida=cuo.idcuotaacometida and serv.estado='activo' and  serv.idservicio
                                            not in(select fac.idservicio from facturas fac where fac.idservicio=serv.idservicio);");
            }
            catch (Exception ex) { return null; }
        }

        public DataTable ConsultarGenrarAco(int idcontrol)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append(" select fact.idfactura, fact.saldo,fact.mora, fact.estado, fact.estado_pago, fact.idservicio, ");
            sentencia.Append("fact.cont_pendiente, fact.descuento, fact.idcontrolfecha, cuo.monto as cuota");
            sentencia.Append(" from facturas as fact, servicios as ");
            sentencia.Append("serv, clientes as cli, serviciosacometida as aco, cuotasacometida as cuo ");
            sentencia.Append("where fact.idservicio = serv.idservicio and cli.idcliente = serv.idcliente and ");
            sentencia.Append("serv.idacometida = aco.idserviciosacometida and cuo.idcuotaacometida = aco.idcuotaacometida and serv.estado='activo' and  fact.estado='Valida' and ");
            sentencia.Append("fact.estado_pago='pendiente';");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception ex) { return null; }
        }
        public DataTable GenerarFacturasConsumo(int idcontrol, double mora, ProgressBar g, Label conta)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            /*Datatable, si aparece algun error en tiempo de ejecución se procede a agregar
            la factura para devolver cono resulatdo la lista de facturas que no fueron posibles crear las siguientes
            ejemplo: si se esta generando la facturación para el mes de febrero pero una de estas da error se agrega a Result 
            la factura anterior a la que no se pudo generar en este caso enero
             */
            DataTable Resultado = new DataTable();
            DataTable ListaServicios = new DataTable();
            ListaServicios = ConsultarGenrarCon(idcontrol);
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
                    Facturas Fac = consultarFacturaServicio(rw.ItemArray[0].ToString());
                    //generar factura nueva si la factura anterior ya fue cancelada
                    if (Fac.EstadoPago.Equals("Cancelado") || Fac == null)
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
                            Fac.Saldo = Saldo + double.Parse(rw.ItemArray[3].ToString());
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
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            /*Datatable, si aparece algun error en tiempo de ejecución se procede a agregar
            la factura para devolver cono resulatdo la lista de facturas que no fueron posibles crear las siguientes
            ejemplo: si se esta generando la facturación para el mes de febrero pero una de estas da error se agrega a Result 
            la factura anterior a la que no se pudo generar en este caso enero
             */
            DataTable Resultado = new DataTable();
            DataTable ListaFacturas = new DataTable();
            DataTable ListaServicios = new DataTable();
            ListaFacturas = ConsultarGenrarAco(idcontrol);
            ListaServicios = ServiciosSinFacAco(idcontrol);
            int cont = 0;
            //variable para controlar el numero de facturas que han sido procesadas, para esto se utiliza el valor de la barra de porgreso entre 5, que nos da como resultado el valor de las facturas procesadas
            //el valir de g.value= Numero de facturas * 5

            int procesadas = g.Value / 5;
            string aux = "/" + (g.Maximum / 5).ToString();
            //creacion de facturas, tomando en cuenta la informacion de las facturas de mes vencidos se recorre la lista de facturas pára acceder a la informacion necesaria para la creaciom de la factura
            //la insercion se hace factura por factura, de esta forma si surge un error con alguno no impide que las demas sean creadas
            foreach (DataRow rw in ListaFacturas.Rows)
            {
                sentencia.Clear();
                //si esta pendiente se genera la nueva factura con los saldos pendientes
                if (rw.ItemArray[4].ToString().ToLower() == "pendiente")
                {
                    sentencia.Append("insert into facturas (saldo, mora, estado, estado_pago, idservicio, cont_pendiente, idcontrolfecha)");
                    sentencia.Append("values (");
                    sentencia.Append((double.Parse(rw.ItemArray[1].ToString()) + double.Parse(rw.ItemArray[9].ToString())) + ", ");
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
                    sentencia.Append(double.Parse(rw.ItemArray[9].ToString()) + ", ");
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

                procesadas++;
                g.Value = procesadas * 5;
                conta.Text = procesadas + aux;
                conta.Refresh();
            }
            //crear faturas de los servicios los cuales aun no cuentan con una factura previa
            if (ListaServicios.Rows.Count > 0)
            {
                foreach (DataRow rw in ListaServicios.Rows)
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
                    procesadas++;
                    g.Value = procesadas * 5;
                    conta.Text = procesadas + aux;
                    conta.Refresh();
                }
            }
            return Resultado;
        }

        public  Facturas consultarFactura(string idfactura)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append(@"SELECT idfactura, saldo, mora, estado, estado_pago, idservicio, cont_pendiente, descuento, idcontrolfecha, comentario 
                                FROM db_acacuvan.facturas where idfactura= " + idfactura + ";");

            try
            {
                DataRow rw = operacion.Consultar(sentencia.ToString()).Rows[0];
                Facturas factura = new Facturas();
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
                return factura;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Facturas consultarFacturaServicio(string idservicio)
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
                return null;
            }
        }
        /*select concat(cli.nombres, ' ', cli.apellidos) as 'cliente' ,fac.idFactura, fac.saldo, fac.mora, fac.estado, fac.estado_pago, fac.idservicio, fac.cont_pendiente, fac.descuento, fac.idcontrolfecha, fac.Comentario

        from facturas fac, clientes cli, servicios serv where idfactura = 80547 and cli.idcliente=serv.idcliente and fac.idservicio= serv.idservicio;*/

        public Boolean Actualzar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update facturas set ");
            sentencia.Append("comentario = '" + this.Comentario + "', ");
            sentencia.Append("descuento = " + this.Descuento + ", ");
            sentencia.Append("estado_pago='" + this.EstadoPago + "' ");
            sentencia.Append("where idfactura=" + this.IdFactura + ";");

            try
            {
                return operacion.Actualizar(sentencia.ToString());
            }
            catch (Exception ex) { return false; }
        }

        public Boolean Insertar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("insert into facturas (saldo,mora,estado,estado_pago, idservicio, cont_pendiente, descuento,idcontrolfecha,comentario) values (");
            sentencia.Append(" " + this.Saldo + ", ");
            sentencia.Append(" " + this.Mora + ", ");
            sentencia.Append(" '" + this.Estado + "', ");
            sentencia.Append(" '" + this.EstadoPago + "', ");
            sentencia.Append(" " + this.IdServicio + ", ");
            sentencia.Append(" " + this.ContPendientes + ", ");
            sentencia.Append(" " + this.Descuento + ",");
            sentencia.Append(" " + this.IdControlFecha + ", ");
            sentencia.Append(" '" + Comentario + "');");
            try
            {
                //si la insertcion es un exito se ocnsulta el id de la factura que se acaba de ingresar y la asignamos al objeto que telaizao la insericon
                if (operacion.Insertar(sentencia.ToString())) 
                {
                    this.IdFactura = int.Parse(operacion.Consultar("select LAST_INSERT_ID() from facturas limit 1").Rows[0][0].ToString());
                    return true;
                }
                return false;
            }catch (Exception ex) { return false; }
        }
    }
}
