using CapaDatos.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    public static class SistemCache
    {
        public static DataTable ConsultarClientes() { return Clientes.Consultar(); }

        public static DataTable ConsultarUsuarios() { return Usuario.Consultar(); }

        public static DataTable ConsultarServiciosCon() { return Servicios.ConsultarCon(); }

        public static DataTable ConsultarServiciosCon(int idcliente) { return Servicios.ConsultarCon(idcliente); }

        public static DataTable ConsultarServiciosAco() { return Servicios.ConsultarAco(); }

        public static DataTable ConsultarServiciosAco(int idcliente) { return Servicios.ConsultarAco(idcliente); }

        public static Boolean seguro()
        {

            return MessageBox.Show("¿Esta seguro de modificar el resgistro?", "Advertencia", MessageBoxButtons.YesNo).Equals(DialogResult.Yes) == true ? true : false;
        }


    }
}
