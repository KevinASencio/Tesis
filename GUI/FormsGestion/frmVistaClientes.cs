using CapaNegocio;
using Controllers;
using GUI.Clases;
using System;
using System.Windows.Forms;
namespace GUI.FormsGestion
{
    public partial class frmVistaClientes : Form
    {
        BindingSource ListaClientes = new BindingSource();
        frmGestionClientes _frmGestionClientes;
        frmVistaServicios _frmVistaServicios;
        ClientesNeg cliente= new ClientesNeg();

        //nada mas prueba

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
        public void agregar() 
        {
            _frmGestionClientes = new frmGestionClientes();
            _frmGestionClientes.StartPosition = FormStartPosition.CenterParent;
            _frmGestionClientes.ShowDialog();
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
            _frmGestionClientes.cmbEstado.Text = dtgvClientes.CurrentRow.Cells["estado"].Value.ToString();
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
            ListaClientes.DataSource =cliente.ConsultarClientes();
            dtgvClientes.AutoGenerateColumns = false;
            dtgvClientes.DataSource = ListaClientes;
            dtgvClientes.Refresh();
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
            cliente = new ClientesNeg(int.Parse(dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString()));
            if (cliente.CambiarEstado(dtgvClientes.CurrentRow.Cells[6].Value.ToString()))
            {
                Validacion.frmMessageBox("Estado Cambiado", "Exito");
            }
            else
            {
                Validacion.frmMessageBox("Error al Cambiar Estado", "Error");
            }
        }
        public void AbrirFactuasCliente() 
        {
            frmVerFacturasCli frm = new frmVerFacturasCli();
            frm.idcliente = int.Parse(dtgvClientes.CurrentRow.Cells["idcliente"].Value.ToString());
            frm.cargardatos();
            frm.StartPosition= FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        public void Filtrar() 
        {
            if (txbFiltro.Text.Length > 0)
            {
                ListaClientes.Filter = String.Format("Convert(idcliente, 'System.String') LIKE '%{0}%' OR nombres LIKE '%{0}%' OR apellidos LIKE '%{0}%' OR direccion LIKE '%{0}%' OR estado LIKE '%{0}%'", txbFiltro.Text);
            }
            else { ListaClientes.RemoveFilter(); }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
