using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PermisosNeg
    {
        Roles Rol;
        Permisos Permiso;
        public PermisosNeg(int idrol) 
        {
            Permiso = new Permisos();
            Permiso.IdRol = idrol;
        }
        public DataTable ConsultarPermisosCon() 
        {
            return Permiso.ConsultarPermisosCon();
        }

        public DataTable ConsultarPErmisosden() 
        {
            return Permiso.ConsultarPermisosDen();
        }

        public Boolean EliminarPermisos(int idpermiso) {
            Permiso.IdPermiso = idpermiso;
            return Permiso.Eliminar();
        }
        

    }
}
