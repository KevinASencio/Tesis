using CapaNegocio;
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
            if (SistemCache.seguro())
            {
                ClientesNeg cliente = new ClientesNeg(txbNombres.Text.ToString(), txbApellidos.Text.ToString(),
                                                          txbDirreccion.Text.ToString(), txbDui.Text.ToString(), txbTelefono.Text.ToString(), cmbEstado.Text.ToString());
                if (txbDui.TextLength == 0) { cliente.setDui(null); }
                if (txbId.TextLength > 0)
                {
                    if (cliente.Actualizar())
                    {
                        cliente.SetIdclilente(int.Parse(txbId.Text.ToString()));
                        MessageBox.Show("¡Cambios guardados!", "Exito", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("¡Error al guardar!", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (cliente.guardar())
                    {
                        MessageBox.Show("¡Registro guardado!", "Exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("¡Error al guardar!", "Error", MessageBoxButtons.OK);
                    }
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
    }
}
