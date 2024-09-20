using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Entidades
{
    public class Roles
    {

        int _IdRol;
        string _Rol;

        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string Rol { get => _Rol; set => _Rol = value; }

        public static DataTable Consultar()
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            try 
            {
                sentencia.Append(@"select idrol, rol from roles;");
                return operacion.Consultar(sentencia.ToString());
            }catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); return null;}
            
        }
    }
}
