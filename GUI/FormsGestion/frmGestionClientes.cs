using CapaNegocio;
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
                ClientesNeg cliente = new ClientesNeg(int.Parse(txbId.Text.ToString()), txbNombres.Text.ToString(), txbApellidos.Text.ToString(),
                                                          txbDirreccion.Text.ToString(), txbDui.Text.ToString(), txbTelefono.Text.ToString(), cmbEstado.SelectedItem.ToString());
                if(txbDui.TextLength == 0){ cliente.setDui(null); }
                if (txbId.Text != null)
                {
                    if (cliente.Actualizar())
                    {
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
