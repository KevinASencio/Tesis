using CapaNegocio;
using Controllers;
using GUI.Clases;
using GUI.FormsGestion;
using GUI.FormsMessageBox;
using GUI.Reportes;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI.FormsProcesos
{
    public partial class frmCobroFacturas : Form
    {
        FacturasNeg factura = new FacturasNeg();
        ClientesNeg cliente = new ClientesNeg();
        DataTable dtFactura = new DataTable();
        const string patronDecimal = @"\.";
        Boolean puntoTotal = false;
        Boolean puntoDescuento = false;
        Regex validar;
        public frmCobroFacturas()
        {
            InitializeComponent();
        }

        private void frmCobroFacturas_Load(object sender, EventArgs e)
        {
            OrganizadorObj.Organizar(1, 9, this, panel1.GetType());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscar();
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (buscar(txbFactura.Text.ToString())) btnImprimir.Enabled = true;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double descuento = double.Parse(txbDescuento.Text.ToString());
            double total = double.Parse(txbTotalPagar.Text.ToString());
            if (descuento<total && total>0)
            {
                if (factura.procesar(double.Parse(txbTotalPagar.Text.ToString()), double.Parse(txbDescuento.Text.ToString()), frmPrincipal.useractivo.usuario()))
                {
                    Validacion.frmMessageBox("¡Cobro realizado!", "Exito");
                    btnImprimir.Enabled = false;
                    LimpiarInf();
                }
            }
            else Validacion.frmMessageBox("Verifique la cantidad a pagar y el descuento", "Error");
        }

        public Boolean buscar(string idfactura)
        {
            btnImprimir.Enabled = true;
            return factura.ConsultarFactura(idfactura, this);
        }
        public void LimpiarInf()
        {
            lblMes.Text = string.Empty;
            lblCliente.Text = string.Empty;
            lblMesesPen.Text = string.Empty;
            lblIdFactura.Text = string.Empty;
            lblMonto.Text = string.Empty;
            lblMora.Text = string.Empty;
            txbDescuento.Clear();
            txbFactura.Clear();
            txbTotalPagar.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();

        }

        //cargar reporte cunado la factura es impresa al momento de pagar
        public void Imprimir()
        {
            ParametrosNeg _parametros = new ParametrosNeg();
            //Crear una instancia del reporte
            Reportes.RepFacturaCobrar reporte = new Reportes.RepFacturaCobrar();
            // Obtener los datos para el reporte
            DataTable dtFactura = factura.ConsultarReporteGen(0); reporte.SetDataSource(dtFactura);
            // Configurar el nombre del documento para imprimir
            PrintDocument printDocument1 = new PrintDocument(); printDocument1.DocumentName = "RepFacturaCobrar";
            // Mostrar el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog(); printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {

                // Configurar la impresora
                reporte.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
                try
                {  //Imprimir el reporte
                    reporte.PrintToPrinter(printDialog.PrinterSettings.Copies, false, 0, 0);
                    MessageBox.Show("Reporte impreso correctamente.");
                }
                catch (Exception ex) { MessageBox.Show("Error al imprimir el reporte: " + ex.Message); }
            }
        }

        private void txbTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                puntoTotal = Regex.IsMatch(this.txbTotalPagar.Text.ToString(), patronDecimal) ? true : false;
                Validacion.Decimales(e, puntoTotal);
            }
            catch (Exception ex)
            {
                Validacion.ErrorBox(ex);
            }
        }

        private void txbDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                puntoDescuento = Regex.IsMatch(this.txbDescuento.Text.ToString(), patronDecimal) ? true : false;
                Validacion.Decimales(e, puntoDescuento);
            }
            catch (Exception ex)
            {
                Validacion.ErrorBox(ex);
            }
        }
    }

}
