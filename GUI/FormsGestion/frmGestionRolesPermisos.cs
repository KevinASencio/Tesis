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
    public partial class frmGestionRolesPermisos : Form
    {
        RolesNeg rol = new RolesNeg();
        PermisosNeg permiso = new PermisosNeg();
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
            cmbRoles.SelectedIndex = -1;
        }
        public void CargarPermisos()
        {
            dtgvPermisosCon.DataSource = permiso.ConsultarPermisosCon();
            dtgvPermisosDen.DataSource = permiso.ConsultarPErmisosden();
        }
        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                permiso = new PermisosNeg(int.Parse(cmbRoles.SelectedValue.ToString()));
                dtgvPermisosCon.DataSource = permiso.ConsultarPermisosCon();
                dtgvPermisosDen.DataSource = permiso.ConsultarPErmisosden();
            }
            catch { }
        }

        private void ptbAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                permiso.EliminarPermisos(int.Parse(dtgvPermisosCon.CurrentRow.Cells["idpermiso"].Value.ToString()));
                CargarPermisos();
                CargarPermisos();
                frmPrincipal.fr.RefescarPermisos();
            }
            catch { Validacion.frmMessageBox("Error!", "Error"); }
        }

        private void ptbQuitar_Click(object sender, EventArgs e)
        {
            
            try
            {
                permiso.AgregarPermiso(int.Parse(cmbRoles.SelectedValue.ToString()), int.Parse(dtgvPermisosDen.CurrentRow.Cells["idaccion"].Value.ToString()));
                CargarPermisos();
                frmPrincipal.fr.RefescarPermisos();
            }
            catch { Validacion.frmMessageBox("Error!", "Error"); }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbIdRol.Text)) { txbIdRol.Text = "0"; }
            if (!Validacion.esVacio(splitContainer1.Panel2, errorNotificador) && Validacion.seguroModificar())
            {
                if (rol.Procesar(int.Parse(txbIdRol.Text.ToString()), txbRol.Text.ToString())) { Validacion.frmMessageBox("Registro Guardado", "¡Exito!"); }
                else { Validacion.frmMessageBox("Error al guardar el resgistro", "¡Error!"); }
                OrganizadorObj.LimpiarControles(splitContainer1.Panel2);
                CargarDatos();
                dtgvPermisosCon.DataSource = new DataTable();
                dtgvPermisosDen.DataSource = new DataTable();
            }
        }

        private void frmGestionRolesPermisos_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = this.Width / 2;
            splitContainer1.Panel1.Margin = new Padding(Convert.ToInt16(this.Width*0.2));
            splitContainer1.Update();
        }
    }
}
