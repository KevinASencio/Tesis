using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
namespace CapaNegocio
{
    public class ClientesNeg
    {
        private Clientes cl;

        public ClientesNeg(int idcliente, string nombres, string apellidos, string direccion, string dui, string telefono, string estado)
        {
            this.cl = new Clientes();
            this.cl.IdCliente = idcliente;
            this.cl.Nombres = nombres;
            this.cl.Apellidos = apellidos;
            this.cl.Direecion = direccion;
            this.cl.Dui= dui;
            this.cl.Telefono = telefono;
            this.cl.Estado = estado;
        }
        public ClientesNeg(int idcliente, string estado) 
        {
            this.cl = new Clientes();
            this.cl.IdCliente = idcliente;
            this.cl.Estado = estado;
        }

        public Boolean guardar()
        {
            return this.cl.Guardar();
        }

        public Boolean Actualizar()
        {
            return this.cl.Actualizar();
        }

        public Boolean CambiarEstado() 
        {
           return this.cl.CambiarEstado();
        }


    }
}

