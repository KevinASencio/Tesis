using CapaNegocio.UsuarioNeg;
using Controllers;
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
    public partial class frmGestionUsuarios : Form
    {
        BindingSource _roles = new BindingSource();
        UsuarioNeg _usuario = new UsuarioNeg();
        public string accion = "";
        public frmGestionUsuarios()
        {
            InitializeComponent();
            CargarDatos();
            OrganizadorObj.Organizar(1, 7, this.pnlPrincipal, panel6.GetType());
        }

        public void CargarDatos()
        {
            _roles.DataSource = RolesNeg.consultar();
            cmbRol.DataSource = _roles;
            cmbRol.ValueMember = "idrol";
            cmbRol.DisplayMember = "rol";
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validacion.esVacio(this.pnlPrincipal, errorNotificador)) 
            {
                _usuario.Setusuario(txbId.Text.ToString());
                _usuario.Setnombres(txbNombres.Text.ToString());
                _usuario.Setapellidos(txbApellidos.Text.ToString());
                _usuario.Setidrol(int.Parse(cmbRol.SelectedValue.ToString()));
                _usuario.Setcontraseña(txbContraseña.Text.ToString());
                _usuario.Setestado(cmbEstado.Text.ToString());
                switch (accion)
                {
                    case "editar":
                        if (_usuario.Actualizar()) { MessageBox.Show("Resgistro actualizado!"); }
                        else { MessageBox.Show("Error al atualizar el registro"); }
                        this.Close();
                        break;
                    case "agregar":
                        if (_usuario.Agregar()) { MessageBox.Show("Resgistro gardado!"); }
                        else { MessageBox.Show("Error al guardar el registro"); }
                        this.Close();
                        break;
                }
                
            }
        }
    }
}
