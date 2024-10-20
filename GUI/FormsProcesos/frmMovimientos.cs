using GUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using GUI.FormsGestion;
namespace GUI.FormsProcesos
{
    public partial class frmMovimientos : Form
    {
        
        const string patronDecimal = @"\.";
        Boolean punto = false;
        MovimientosNeg _movimineto = new MovimientosNeg();
        public frmMovimientos()
        {
            InitializeComponent();
        }

        private void frmMovimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validacion.esVacio(this, errorNotificador)) 
            {
                if (_movimineto.guardar(this, frmPrincipal.useractivo.usuario()))
                {
                    Validacion.frmMessageBox("Registro ingresado al sistema", "Exito");
                    OrganizadorObj.LimpiarControles(this);
                }
                else { Validacion.frmMessageBox("¡Error! Registro no guardado", "Error"); }
            }
        }

        private void txbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                 punto = Regex.IsMatch(this.txbMonto.Text.ToString(), patronDecimal) ? true : false;
                Validacion.Decimales(e, punto);
            }
            catch
            {}
            
        }
    }
}
