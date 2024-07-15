using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
