using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
namespace CapaNegocio
{
    public static class ClientesNeg
    {
        public static DataTable ConsultarClientes()
        {
            DataTable lista = new DataTable();
            lista = Clientes.Consultar();
            return lista;
        }
    }
}

