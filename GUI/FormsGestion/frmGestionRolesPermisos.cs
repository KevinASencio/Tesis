using Controllers;
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
    public partial class frmGestionRolesPermisos : Form
    {
        RolesNeg rol=new RolesNeg();
        PermisosNeg permiso;
        public frmGestionRolesPermisos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarDatos() 
        {
            cmbRoles.DataSource = RolesNeg.consultar();
            cmbRoles.DisplayMember = "rol";
            cmbRoles.ValueMember = "idrol";
            //cmbRoles.SelectedIndex = -1;
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {*/
                permiso = new PermisosNeg(int.Parse(cmbRoles.SelectedValue.ToString()));
                dtgvPermisosCon.DataSource = permiso.ConsultarPermisosCon();
                dtgvPermisosDen.DataSource = permiso.ConsultarPErmisosden();
          /*  }
            catch { }*/
        }

        private void ptbAgregar_Click(object sender, EventArgs e)
        {
            permiso
        }
    }
}
