using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Reportes
{
    public partial class frmRepResumenCaja : Form
    {
        ControlCajaNeg control = new ControlCajaNeg();
        public frmRepResumenCaja()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos() 
        {
            cmbControl.DataSource = control.ConsultarLista();
            cmbControl.DisplayMember = "periodo";
            cmbControl.ValueMember = "idcontrol_caja";
        }


        private void tscCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
