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
    public partial class frmRepResumenBanco : Form
    {

        ControlBancoNeg control= new ControlBancoNeg();
        MovimientosNeg movimiento = new MovimientosNeg();
        public frmRepResumenBanco()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            cmbControl.DataSource = control.ConsultarLista();
            cmbControl.DisplayMember = "periodo";
            cmbControl.ValueMember = "idcontrol_banco";
        }

        private void cmbControl_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Reportes.RepResumenBanco repResumen = new RepResumenBanco();
                repResumen.SetDataSource(movimiento.ConsultarRepBanco(int.Parse(cmbControl.SelectedValue.ToString())));
                repResumen.SetParameterValue("mes", cmbControl.GetItemText(cmbControl.SelectedItem));
                crvResumenCaja.ReportSource = repResumen;

            }
            catch { }
        }
    }
}
