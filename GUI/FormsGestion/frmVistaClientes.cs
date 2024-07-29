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
using System.Windows.Controls;
using System.Windows.Forms;
namespace GUI.FormsGestion
{
    public partial class frmVistaClientes : Form
    {
        BindingSource ListaClientes = new BindingSource();
        frmGestionClientes _frmGestionClientes;
        frmVistaServicios _frmVistaServicios;

        public frmVistaClientes()
        {
            InitializeComponent();
        }

        private void frmVistaClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
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
            OrganizadorObj.abrirFormularioHijo(this,_frmGestionClientes);
        }

        private void dtgvClientes_SelectionChanged(object sender, EventArgs e)
            
        {
            
            //MessageBox.Show(dtgvClientes.CurrentRow.Cells["apellidos"].Value.ToString());
        }

        public void CambiarEstado() 
        {
            ClientesNeg cl = new ClientesNeg(int.Parse(dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString()),
                                             dtgvClientes.CurrentRow.Cells["estado"].Value.ToString());
            if (cl.CambiarEstado() == true)
            {
                MessageBox.Show("Erro al Cambiar Estado", "Error", MessageBoxButtons.OK);
            }
            else
            { 
                //MessageBox.Show()
            }
           
        }

        private void frmVistaClientes_ControlRemoved(object sender, ControlEventArgs e)
        {
            CargarDatos();
            OrganizadorObj.ocuktar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlMenuInicio);
            OrganizadorObj.mostrar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlMenuDetalles);
            OrganizadorObj.ocuktar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlAcciones);
        }

        public void CargarDatos() 
        {
            ListaClientes.DataSource = CapaNegocio.SistemCache.ConsultarClientes();
            dtgvClientes.AutoGenerateColumns = false;
            dtgvClientes.DataSource = ListaClientes;
            lblRegistro.Text = ListaClientes.Count.ToString();
        }
        public void Servicios() 
        {
            _frmVistaServicios = new frmVistaServicios();
            OrganizadorObj.ocuktar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlMenuInicio);
            OrganizadorObj.ocuktar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlMenuDetalles);
            OrganizadorObj.mostrar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlAcciones);
            _frmVistaServicios.CargarDatos(Convert.ToInt32(dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString()));
            /*this.AddOwnedForm(_frmVistaServicios);
            _frmVistaServicios.TopLevel = false;
            this.Controls.Add(_frmVistaServicios);
            _frmVistaServicios.BringToFront();
            _frmVistaServicios.Show();
            _frmVistaServicios.StartPosition= FormStartPosition.CenterParent;
            _frmVistaServicios.Update();*/
            //OrganizadorObj.abrirFormularioHijo(this, _frmVistaServicios);
            _frmVistaServicios.StartPosition= FormStartPosition.CenterParent;
            _frmVistaServicios.ShowDialog();
        }
    }
}
