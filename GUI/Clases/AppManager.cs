using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.UsuarioNeg;
using GUI.FormsGestion;

namespace GUI.Clases
{
    internal class AppManager
    {
        public static UsuarioNeg _usuario =new UsuarioNeg();
        
        AppManager() {
            //ejecutar splash
            if (login())
            {

            }
            else 
            {
                
            }
        }    

        Boolean login() {
            bool autorizado = false;
            FrmLogin f= new FrmLogin();
            f.Show();

        }
    }
}
