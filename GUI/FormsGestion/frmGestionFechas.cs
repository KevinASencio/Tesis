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
    public partial class frmGestionFechas : Form
    {
        ControlFechasNeg FechaNeg= new ControlFechasNeg();
        public frmGestionFechas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion.esVacio(pnlPrincipal, ErrorNotificador) && Validacion.seguroModificar()) 
            {
                if (String.IsNullOrEmpty(txbId.Text)) { txbId.Text = "0"; }

            }
        }
    }
}
