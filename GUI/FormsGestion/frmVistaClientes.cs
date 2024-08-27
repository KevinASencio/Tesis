using CapaNegocio;
using GUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        ClientesNeg cliente;
        public static frmVistaClientes frmvc;

        public frmVistaClientes()
        {
            InitializeComponent();
            frmvc = this;
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
            //OrganizadorObj.abrirFormularioHijo(this,_frmGestionClientes);

            _frmGestionClientes.StartPosition = FormStartPosition.CenterParent;
            _frmGestionClientes.ShowDialog();
        }

        private void dtgvClientes_SelectionChanged(object sender, EventArgs e)

        {

            //MessageBox.Show(dtgvClientes.CurrentRow.Cells["apellidos"].Value.ToString());
        }


        private void frmVistaClientes_ControlRemoved(object sender, ControlEventArgs e)
        {
            CargarDatos();
            OrganizadorObj.ocultar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlMenuInicio);
            OrganizadorObj.mostrar(frmPrincipal.fr.pnlMenus, frmPrincipal.fr.pnlMenuDetalles);
        }

        public void CargarDatos()
        {
            ListaClientes.DataSource = CapaNegocio.SistemCache.ConsultarClientes();
            dtgvClientes.AutoGenerateColumns = false;
            dtgvClientes.DataSource = ListaClientes;
            lblRegistro.Text = ListaClientes.Count.ToString() + " Registros Encontrados";
        }
        public void Servicios()
        {
            _frmVistaServicios = new frmVistaServicios();
            _frmVistaServicios.servicio.setIdCliente(Convert.ToInt32(dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString()));
            _frmVistaServicios.StartPosition = FormStartPosition.CenterParent;
            _frmVistaServicios.ShowDialog();
        }

        public void CambiarEstado()
        {
            if (Validacion.seguroCambiarEstado())
            {
                if (dtgvClientes.CurrentRow.Cells["estado"].Value.ToString() == "Activo")
                {
                    cliente = new ClientesNeg(int.Parse(dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString()), "De Baja");
                }
                else
                {
                    cliente = new ClientesNeg(int.Parse(dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString()), "Activo");
                }
                if (cliente.CambiarEstado()) { MessageBox.Show("Estado Cambiado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Error al cambiar el Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
