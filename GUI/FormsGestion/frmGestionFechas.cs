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
            FechaNeg=new ControlFechasNeg();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion.esVacio(pnlPrincipal, ErrorNotificador) && Validacion.seguroModificar()) 
            {
                if (String.IsNullOrEmpty(txbId.Text)) { txbId.Text = "0"; }
                FechaNeg = new ControlFechasNeg(int.Parse(txbId.Text.ToString()), cmbMes.Text.ToString(), dtpVencimiento.Value, dtpFinConsumo.Value);
                if (FechaNeg.Procesar()) { Validacion.frmMessageBox("Registro Guardado", "Exito"); this.Close(); }
                else { Validacion.frmMessageBox("Error al Guardar el Registro","Error"); }
            }
        }
        public void CargarDatos(string mes, DateTime fechavencimiento, DateTime fechavencimientohasta) 
        {
            FechaNeg = new ControlFechasNeg(0,mes,fechavencimiento,fechavencimientohasta);
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        public void Cerrar() { this.Close(); }

       
    }
}
