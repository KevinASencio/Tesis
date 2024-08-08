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
    public partial class frmGestionConsumo : Form
    {
        CuotasNeg cuota = new CuotasNeg();
        BindingSource cuotasConsumo = new BindingSource();  
        public frmGestionConsumo()
        {
            InitializeComponent();
            CargarDatos();
            OrganizadorObj.Organizar(1, 7, pnlPrincipal, panel1.GetType());
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void CargarDatos() 
        {
            this.cmbCuota.DataSource= CuotasNeg.consultarCuotasConsumo();
            cmbCuota.DisplayMember = "monto";
            cmbCuota.ValueMember = "idcuotaconsumo";
            cmbCuota.SelectedIndex = -1;
        }
    }
}
