using CapaNegocio;
using GUI.Clases;
using System;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class frmGestionClientes : Form
    {
        public static frmGestionClientes frmgc;
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            frmgc = this;
            Clases.OrganizadorObj.Organizar(1, 8, this.pnlPrincipal, pnlApellidos.GetType());
        }

        public void cerrar()
        {
            this.Close();
        }

        public void procesar()
        {
            if (Validacion.seguroModificar() && !Validacion.esVacio(pnlPrincipal, ErrorNotificador))
            {
                if (string.IsNullOrEmpty(txbId.Text)) { txbId.Text = "0"; }
                ClientesNeg cliente = new ClientesNeg(txbNombres.Text.ToString(), txbApellidos.Text.ToString(),
                                                          txbDirreccion.Text.ToString(), txbDui.Text.ToString(), txbTelefono.Text.ToString(), cmbEstado.Text.ToString());
                if (cliente.Procesar(int.Parse(txbId.Text.ToString())))
                {
                    Validacion.frmMessageBox("Registro Guardado", "Exito");
                }
                else 
                {
                    Validacion.frmMessageBox("Error la Guardar","Error");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            procesar();
            this.Close();
            frmVistaClientes.frmvc.CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
