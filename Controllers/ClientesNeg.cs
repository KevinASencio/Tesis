using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
namespace CapaNegocio.ClientesNeg
{
    public class ClientesNeg
    {
        Clientes Cliente= new Clientes();

        public DataTable ConsultarClientes() { 
            DataTable lista = new DataTable();
            lista = Cliente.Consultar();
            return lista;   
        }
    }
}
