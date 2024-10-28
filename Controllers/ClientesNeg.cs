using CapaDatos.Entidades;
using System;
namespace CapaNegocio
{
    public class ClientesNeg
    {
        private Clientes cl;

        public ClientesNeg() { }
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
        public ClientesNeg(int idcliente)
        {
            this.cl = new Clientes();
            this.cl.IdCliente = idcliente;
        }
        public void setDui(string i)
        {
            this.cl.Dui = i;
        }
        public void SetIdclilente(int idcliente) { this.cl.IdCliente = idcliente; }

        public Boolean Procesar(int idcliente) 
        {
            if (idcliente == 0)
            {
                return cl.Insertar();
            }
            else 
            {
                cl.IdCliente = idcliente;
                return cl.Actualizar();
            }
        }

        public Boolean CambiarEstado(string estado)
        {
            if (estado == "activo")
            {
                cl.Estado = "De Baja";
            }
            else
            {
                cl.Estado = "activo";
            }
            return cl.CambiarEstado();

        }


    }
}

