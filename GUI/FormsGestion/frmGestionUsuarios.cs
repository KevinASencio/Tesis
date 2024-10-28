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
                if (_usuario.Procesar(txbId.Text.ToString(), txbNombres.Text.ToString(), txbApellidos.Text.ToString(),
                                      int.Parse(cmbRol.SelectedValue.ToString()), txbContraseña.Text.ToString(), cmbEstado.Text.ToString(), accion))
                {
                    Validacion.frmMessageBox("Registro Guardado", "¡Exito!");
                    this.Close();
                }
                else 
                {
                    Validacion.frmMessageBox("Error al Guardar", "¡Error!");
                }
            }
        }

      
    }
}
