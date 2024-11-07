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
using System.Windows.Markup;

namespace GUI.FormsGestion
{
    public partial class frmVistaControlFechas : Form
    {
        ControlFechasNeg fechaneg = new ControlFechasNeg();
        BindingSource listafechas = new BindingSource();
        frmGestionFechas _frmgestionfechas = new frmGestionFechas();
        public frmVistaControlFechas()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            listafechas.DataSource = fechaneg.ConsultarFechas();
            dgtvContorlFechas.DataSource = listafechas;
        }

        private void frmVistaControlFechas_Load(object sender, EventArgs e)
        {

        }


        public void Editar() 
        {
            _frmgestionfechas.dtpFinConsumo.Value = DateTime.Parse(dgtvContorlFechas.CurrentRow.Cells["fecha_hasta"].Value.ToString());
            _frmgestionfechas.dtpVencimiento.Value = DateTime.Parse(dgtvContorlFechas.CurrentRow.Cells["fecha_vencimiento"].Value.ToString());
            _frmgestionfechas.cmbMes.Text= dgtvContorlFechas.CurrentRow.Cells["mes"].ToString();
            _frmgestionfechas.txbId.Text= dgtvContorlFechas.CurrentRow.Cells["idcontrol"].ToString();
            _frmgestionfechas.StartPosition= FormStartPosition.CenterParent;
            _frmgestionfechas.ShowDialog();
        }
    }
}
