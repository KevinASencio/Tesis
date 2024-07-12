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
        static frmVistaClientes fl;
        public frmVistaClientes()
        {
            InitializeComponent();
            fl = this;
        }

        private void frmVistaClientes_Load(object sender, EventArgs e)
        {

            ListaClientes.DataSource = CapaNegocio.ClientesNeg.ConsultarClientes();
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
            //_frmGestionClientes.txbId.Text =
            MessageBox.Show(dtgvClientes.SelectedRows.Count.ToString());

            //MessageBox.Show(dgtvClientes.CurrentRow.Cells["apellidos"].Value.ToString());
            OrganizadorObj.abrirCont(_frmGestionClientes);
        }

        private void dtgvClientes_SelectionChanged(object sender, EventArgs e)
            
        {
            
            //MessageBox.Show(dtgvClientes.CurrentRow.Cells["apellidos"].Value.ToString());
        }
    }
}
