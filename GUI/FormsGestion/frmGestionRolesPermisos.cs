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
        public frmGestionRolesPermisos()
        {
            InitializeComponent();
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {

        }
        private void CargarDatos() 
        {
            cmbRoles.DataSource = RolesNeg.consultar();
            cmbRoles.DisplayMember = "rol";
            cmbRoles.ValueMember = "idrol";
            cmbRoles.SelectedIndex = -1;


        }
    }
}
