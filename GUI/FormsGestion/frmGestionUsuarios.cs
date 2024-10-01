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
using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class frmGestionUsuarios : Form
    {
        BindingSource _roles = new BindingSource();
        UsuarioNeg _usuario = new UsuarioNeg();
        public string accion = "";
        //variable para guardar el usuario orignal en caso que el resgistro este siendo modificado 
        public string UsuarioAux = "";
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
                        if (_usuario.Actualizar(UsuarioAux)) { Validacion.frmMessageBox("¡Cambios Guardados!", "Exito"); }
                        else { Validacion.frmMessageBox("¡Error al Guardar los Cambios!", "Error"); }
                        this.Close();
                        break;
                    case "agregar":
                        if (_usuario.Agregar()) { Validacion.frmMessageBox("¡Usuario Guardado!", "Exito"); }
                        else { Validacion.frmMessageBox("¡Error al Guardar el Usuario!", "Error"); }
                        this.Close();
                        break;
                }
                
            }
        }
    }
}
