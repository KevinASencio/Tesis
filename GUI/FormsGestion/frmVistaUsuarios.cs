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
        BindingSource _usuarios= new BindingSource();
        public frmVistaUsuarios()
        {
            InitializeComponent();

        }

        private void frmVistaUsuarios_Load(object sender, EventArgs e)
        {
            _usuarios.DataSource = UsuarioNeg.consultar();
            dtgvUsuarios.AutoGenerateColumns = false;
            dtgvUsuarios.DataSource = _usuarios;
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
