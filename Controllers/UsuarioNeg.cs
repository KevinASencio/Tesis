using CapaDatos.Entidades;
using Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace CapaNegocio.UsuarioNeg
{
    public class UsuarioNeg
    {

        private Usuario user = new Usuario();

        Dictionary<string, int> permisos = new Dictionary<string, int>();

        public static DataTable consultar() { return Usuario.Consultar(); }

        public Boolean Iniciar(string usuario, string pass)
        {
            DataTable result = new DataTable();
            user.Uusuario = usuario;
            user.Contraseña = pass;
            result = user.Validar(usuario, pass);
            if (result.Rows.Count > 0)
            {
                user.Nombres = result.Rows[0]["nombres"].ToString();
                user.Apellidos = result.Rows[0]["apellidos"].ToString();
                user.Uusuario = usuario;
                user.Estado = result.Rows[0]["estado"].ToString();
                user.IdRol = int.Parse(result.Rows[0]["idrol"].ToString());
                user.Rol = result.Rows[0]["rol"].ToString();
                return true;
            }
            return false;
        }

        public string usuario() { return user.Uusuario; }
        public string nombres() { return user.Nombres; }
        public string rol() { return user.Rol; }
        public Dictionary<string, int> Permisos()
        {
            Dictionary<string, int> lista = new Dictionary<string, int>();
            DataTable permisos = new DataTable();
            PermisosNeg per = new PermisosNeg(user.IdRol);
            permisos = per.ConsultarPErmisosden();
            foreach(DataRow rw in permisos.Rows)
            {
                lista.Add(rw["accion"].ToString(), Convert.ToInt16(rw["idaccion"].ToString()));
            }
            return lista;
        }


        //se pasa como parametro el usuario y oldusuario el cual puede 
        public Boolean Procesar(string usuario, string nombres, string apellidos, int idrol, string contraseña, string estado, string accion)
        {
            user.Uusuario = usuario;
            user.Nombres = nombres;
            user.Apellidos = apellidos;
            user.IdRol = idrol;
            user.Contraseña = contraseña;
            user.Estado = estado;
            switch (accion)
            {
                case "agregar":
                    return user.Insertar();

                case "editar":
                    return user.Actualizar();

            }
            return false;
        }

        public Boolean CambiarEstado(string estado)
        {
            if (estado == "Activo")
            {
                user.Estado = "De Bajaa";
            }
            else
            {
                user.Estado = "Activo";
            }
            return user.CambiarEstado();
        }


    }
}
