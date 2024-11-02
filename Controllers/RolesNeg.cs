using CapaDatos.Entidades;
using System;
using System.Data;

namespace Controllers
{
    public class RolesNeg
    {
        Roles roles=new Roles();
        public static DataTable consultar()
        {
            return Roles.Consultar();
        }

        public Boolean Procesar(int idrol, string rol) 
        {
            if (idrol == 0)
            {
                roles.Rol = rol;
                return roles.AgregarRol();
            }
            else 
            {
                roles.Rol=rol;
                roles.IdRol = idrol;
                return roles.Actualizar();
            }
        }
    }
}
