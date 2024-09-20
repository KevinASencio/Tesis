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
    }
}
