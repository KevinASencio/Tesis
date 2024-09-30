using CapaNegocio.UsuarioNeg;
using GUI.FormsGestion;
using System;
using System.Windows.Forms;

namespace GUI.Clases
{
    class AppManager : ApplicationContext
    {
        public static UsuarioNeg _usuario = new UsuarioNeg();
        public frmPrincipal FrmPrincipal = new frmPrincipal();
        public pruebainterfas frm = new pruebainterfas();
        public AppManager()
        {
            //ejecutar splash
            /*if (login())
              {
                  frmPrincipal.useractivo = _usuario;
                  FrmPrincipal.ShowDialog();
                  Application.Exit();
              }
              else 
              {
                  Application.Exit();
              }*/

            FrmPrincipal.ShowDialog();
            Application.Exit();
        }

        public static void Exit()
        {
            Application.Exit();
        }
        Boolean login()
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
            _usuario = f.UserActivo;
            return f.Autorizado;
        }
    }
}
