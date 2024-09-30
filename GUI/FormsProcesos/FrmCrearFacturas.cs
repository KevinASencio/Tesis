using Controllers;
using GUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class FrmCrearFacturas : Form
    {
        FacturasNeg fac = new FacturasNeg(); 
        ControlFechasNeg fecha= new ControlFechasNeg();
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
            fecha.setFechaGeneracion();
            fecha.setFechaHasta(this.dtpFinalConsumo.Value);
            fecha.setFechaVencimiento(this.dtpVencimiento.Value);
            fecha.setMes(cmbMes.Text.ToString());
            fecha.insertar();
            fac.Generar(fecha.getId(),2, pgbCrear,lblTotal);
            fac.GenerarAco(fecha.getId(),2, pgbCrear, lblTotal);
            MessageBox.Show(cmbMes.Text.ToString());
        }

        private void cmbMes_SelectedValueChanged(object sender, EventArgs e)
        {
            fecha.setMes(cmbMes.Text.ToString());
            MessageBox.Show(cmbMes.Text.ToString());
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
