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
using GUI.Clases;
namespace GUI.FormsGestion
{
    public partial class FrmLogin : Form
    {   
        UsuarioNeg _userActivo = new UsuarioNeg();
        bool _Autorizado = false;

        public FrmLogin()
        {
            InitializeComponent();
        }
        // atributo de solo lectura, para pasar la informacion del usuario logeado
        public UsuarioNeg UserActivo   { get => _userActivo; }
        public bool Autorizado { get => _Autorizado; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserActivo.Iniciar(txtUsuario.Text, txtPassword.Text))
            {
                   _Autorizado = true;
                Close();
            }
            else { lblError.Text= "¡CREDENCIALES ERRONEAS!"; lblError.ForeColor = Color.Red; }

        }
    }
}
