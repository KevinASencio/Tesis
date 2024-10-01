using CapaNegocio.UsuarioNeg;
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
    public partial class frmVistaUsuarios : Form
    {
        BindingSource _usuarios = new BindingSource();
        frmGestionUsuarios _frmGestionUsuarios;
        public frmVistaUsuarios()
        {
            InitializeComponent();

        }

        private void frmVistaUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Editar()
        {
            _frmGestionUsuarios = new frmGestionUsuarios();
            _frmGestionUsuarios.accion = "editar";
            _frmGestionUsuarios.UsuarioAux = this.dtgvUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
            _frmGestionUsuarios.txbId.Text = this.dtgvUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
            _frmGestionUsuarios.txbNombres.Text = this.dtgvUsuarios.CurrentRow.Cells["nombres"].Value.ToString();
            _frmGestionUsuarios.txbApellidos.Text = this.dtgvUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
            _frmGestionUsuarios.cmbEstado.Text = this.dtgvUsuarios.CurrentRow.Cells["estado"].Value.ToString();
            _frmGestionUsuarios.cmbRol.SelectedValue = this.dtgvUsuarios.CurrentRow.Cells["idrol"].Value.ToString();
            _frmGestionUsuarios.txbContraseña.Text = this.dtgvUsuarios.CurrentRow.Cells["contraseña"].Value.ToString();
            _frmGestionUsuarios.StartPosition = FormStartPosition.CenterParent;
            _frmGestionUsuarios.ShowDialog();
            this.CargarDatos();
        }

        public void agregar() 
        {
            _frmGestionUsuarios = new frmGestionUsuarios();
            _frmGestionUsuarios.accion = "agregar";
            _frmGestionUsuarios.StartPosition = FormStartPosition.CenterParent;
            _frmGestionUsuarios.ShowDialog();
            this.CargarDatos();
        }

        public void CargarDatos() 
        {
            _usuarios.DataSource = UsuarioNeg.consultar();
            dtgvUsuarios.AutoGenerateColumns = false;
            dtgvUsuarios.DataSource = _usuarios;
        }
 
    }
}
