using CapaDatos.Entidades;
using System;
namespace CapaNegocio
{
    public class ClientesNeg
    {
        private Clientes cl;

        public ClientesNeg( string nombres, string apellidos, string direccion, string dui, string telefono, string estado)
        {
            this.cl = new Clientes();
            this.cl.Nombres = nombres;
            this.cl.Apellidos = apellidos;
            this.cl.Direecion = direccion;
            this.cl.Dui = dui;
            this.cl.Telefono = telefono;
            this.cl.Estado = estado;
        }
        public ClientesNeg(int idcliente, string estado)
        {
            this.cl = new Clientes();
            this.cl.IdCliente = idcliente;
            this.cl.Estado = estado;
        }
        public void setDui(string i)
        {
            this.cl.Dui = i;
        }
        public void SetIdclilente(int idcliente) { this.cl.IdCliente = idcliente; }
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

