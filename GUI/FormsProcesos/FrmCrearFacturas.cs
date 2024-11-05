using Controllers;
using GUI.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class FrmCrearFacturas : Form
    {
        FacturasNeg fac = new FacturasNeg();
        ControlFechasNeg fecha;
        public static ProgressBar pgsCrear;
        public FrmCrearFacturas()
        {
            InitializeComponent();
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
                    fecha= new ControlFechasNeg(cmbMes.Text.ToString(), dtpVencimiento.Value, dtpFinalConsumo.Value);
                    fecha.insertar();
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
        }
    }
}
