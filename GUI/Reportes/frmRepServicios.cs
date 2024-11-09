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
    public partial class frmRepServicios : Form
    {
        ServiciosNeg _ser = new ServiciosNeg();
        public frmRepServicios()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = -1;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepServicios rep = new RepServicios();
            rep.SetDataSource(_ser.ConsulatRep(cmbEstado.Text.ToString()));
            rep.SetParameterValue("ESTADO", cmbEstado.Text.ToString().ToUpper());
            crvServicios.ReportSource = rep;
        }
    }
}
