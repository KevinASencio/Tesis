using CapaNegocio;
using Controllers;
using GUI.Clases;
using GUI.FormsGestion;
using GUI.FormsMessageBox;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GUI.FormsProcesos
{
    public partial class frmCobroFacturas : Form
    {
        FacturasNeg factura = new FacturasNeg();
        ClientesNeg cliente = new ClientesNeg();
        DataTable dtFactura = new DataTable();
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
            if (factura.procesar(double.Parse(txbTotalPagar.Text.ToString()), double.Parse(txbDescuento.Text.ToString()), frmPrincipal.useractivo.usuario()))
            {
                Validacion.frmMessageBox("¡Cobro realizado!", "Exito");
                btnImprimir.Enabled = false;
                LimpiarInf();
            }
        }

        public Boolean buscar(string idfactura)
        {
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
            CargarDatos();

        }

        //cargar reporte cunado la factura es impresa al momento de pagar
        public void CargarDatos()
        {
            {
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
        }
    }

}
