using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
     public static class  SistemCache
    {
        public static DataTable ConsultarClientes()
        {
            DataTable lista = new DataTable();
            lista = Clientes.Consultar();
            return lista;
        }

        public static Boolean seguro() 
        {

            return MessageBox.Show("¿Esta seguro de modificar el resgistro?", "Advertencia", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)==true ?  true : false;
        }


    }
}
