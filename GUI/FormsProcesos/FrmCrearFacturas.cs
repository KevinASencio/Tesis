using Controllers;
using GUI.Clases;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class FrmCrearFacturas : Form
    {
        ColoniasNeg colonias = new ColoniasNeg();
        FacturasNeg fac = new FacturasNeg();
        ControlFechasNeg fecha;
        public static ProgressBar pgsCrear;
        public FrmCrearFacturas()
        {
            InitializeComponent();
            CargarDatos();
            pgsCrear = pgbCrear;
        }
        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGnerar_Click(object sender, EventArgs e)
        {
            //establece como fecha de generacion la fecha del sistema 
            if (dtpFinalConsumo.Value.Date < DateTime.Now.Date)
            {
                if (dtpVencimiento.Value.Date > DateTime.Now.Date)
                {
                    fecha= new ControlFechasNeg(0,cmbMes.Text.ToString(), dtpVencimiento.Value, dtpFinalConsumo.Value);
                    fecha.Procesar();
                    fac.Generar(fecha.getId(), pgbCrear, lblTotal);
                    fac.GenerarAco(fecha.getId(), pgbCrear, lblTotal);
                }
                else
                {
                    MessageBox.Show("La fecha de vencimiento debe ser mayor a la fecha actual");
                }
            }
            else
            {
                MessageBox.Show("La fecha final de consumo debe ser menor a la fecha actual");
            }
        }
        private void cmbMes_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void FrmCrearFacturas_SizeChanged(object sender, EventArgs e)
        {
            calcTamaño();
        }
        public void calcTamaño()
        {
            panel5.Size = new Size((this.Width / 2), (this.Height) - 115);
            panel7.Size = new Size((this.Width / 2), (this.Height) - 115);
            panel7.Padding = new Padding(10);
            panel5.Padding = new Padding(10);
            panel7.Refresh();
            panel7.Location = new Point(this.Width / 2, 25);
            panel5.Refresh();
        }
        private void FrmCrearFacturas_Load(object sender, EventArgs e)
        {
            //calcTamaño();
        }
        private void FrmCrearFacturas_Resize(object sender, EventArgs e)
        {
            calcTamaño();
            OrganizadorObj.Organizar(1, 5, gbCrear, panel5.GetType());
            OrganizadorObj.Organizar(1, 1, gbImprimir, pnlBoton.GetType());
        }

        private void btnImpimir_Click(object sender, EventArgs e)
        {
            Imprimir(int.Parse(cmbColonia.SelectedValue.ToString()));
        }

        public void CargarDatos() 
        {
            cmbColonia.DataSource=colonias.consultar();
            cmbColonia.DisplayMember = "colonia";
            cmbColonia.ValueMember = "idcolonia";
            cmbColonia.SelectedIndex = -1;
        }

        public void Imprimir(int idcolonia)
        {
            //Crear una instancia del reporte
            Reportes.RepFacturasColonia reporte = new Reportes.RepFacturasColonia();
            // Obtener los datos para el reporte
            DataTable dtFactura = fac.ConsultarReporteGen(idcolonia); reporte.SetDataSource(dtFactura);
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
