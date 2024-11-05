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
        ControlFechasNeg FechaNeg;
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
                if (FechaNeg.Procesar()) { Validacion.frmMessageBox("Registro Guardado", "Exito"); }
                else { Validacion.frmMessageBox("Error al Guardar el Registro","Error"); }
            }
        }
        public void CargarDatos(string mes, DateTime fechavencimiento, DateTime fechavencimientohasta) 
        {
            FechaNeg = new ControlFechasNeg(mes,fechavencimiento,fechavencimientohasta);
        }
    }
}
