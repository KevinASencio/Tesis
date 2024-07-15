using GUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
namespace GUI.FormsGestion
{
    public partial class frmVistaClientes : Form
    {
        BindingSource ListaClientes = new BindingSource();
        frmGestionClientes _frmGestionClientes;
        public frmVistaClientes()
        {
            InitializeComponent();
        }

        private void frmVistaClientes_Load(object sender, EventArgs e)
        {
            
            ListaClientes.DataSource = CapaNegocio.SistemCache.ConsultarClientes();
            dtgvClientes.AutoGenerateColumns = false;
            dtgvClientes.DataSource = ListaClientes;
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Editar()
        {
            _frmGestionClientes = new frmGestionClientes();
            _frmGestionClientes.txbId.Text = dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString();
            _frmGestionClientes.txbNombres.Text = dtgvClientes.CurrentRow.Cells["nombres"].Value.ToString();
            _frmGestionClientes.txbApellidos.Text = dtgvClientes.CurrentRow.Cells["apellidos"].Value.ToString();
            _frmGestionClientes.txbDirreccion.Text = dtgvClientes.CurrentRow.Cells["direccion"].Value.ToString();
            _frmGestionClientes.txbDui.Text = dtgvClientes.CurrentRow.Cells["dui"].Value.ToString();
            _frmGestionClientes.txbTelefono.Text = dtgvClientes.CurrentRow.Cells["telefono"].Value.ToString();
            _frmGestionClientes.cmbEstado.SelectedItem = dtgvClientes.CurrentRow.Cells["estado"].Value.ToString();
            OrganizadorObj.abrirCont(_frmGestionClientes);
        }

        private void dtgvClientes_SelectionChanged(object sender, EventArgs e)
            
        {
            
            //MessageBox.Show(dtgvClientes.CurrentRow.Cells["apellidos"].Value.ToString());
        }
    }
}
