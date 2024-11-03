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
        ControlFechasNeg fechaneg= new ControlFechasNeg();
        BindingSource listafechas = new BindingSource();
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
    }
}
