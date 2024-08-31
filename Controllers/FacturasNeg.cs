using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class FacturasNeg
    {
        Facturas fac= new Facturas();

        public DataTable Generar(int idcontrol, double mora) 
        {
            return fac.GenerarFacturasConsumo(idcontrol, mora);
        }

    }
}
