using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.UsuarioNeg;
namespace GUI.FormsGestion
{
    public partial class FrmLogin : Form
    {   
        UsuarioNeg user = new UsuarioNeg();
        Program.
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Iniciar(txtUsuario.Text, txtPassword.Text).Rows.Count>=1)
            {
                MessageBox.Show("Se Inicio lml");
            }
            else { MessageBox.Show("no se inicio putito .l."); }

        }
    }
}
