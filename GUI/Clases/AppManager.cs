using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.UsuarioNeg;
using GUI.FormsGestion;

namespace GUI.Clases
{
     class AppManager:ApplicationContext
    {
        public static UsuarioNeg _usuario =new UsuarioNeg();
        public frmPrincipal FrmPrincipal= new frmPrincipal();
        public pruebainterfas frm = new pruebainterfas();
        public AppManager() {
            //ejecutar splash
            frm.ShowDialog();
           /* if (login())
            {
                frmPrincipal.UserActivo = _usuario;
                FrmPrincipal.ShowDialog();
                string j = "no se que pex";
                Application.Exit();
            }
            else 
            {
                Application.Exit();
            }*/
        }    

        Boolean login() {
            FrmLogin f= new FrmLogin();
            f.ShowDialog();
            _usuario = f.UserActivo;
            return f.Autorizado;
        }
    }
}
