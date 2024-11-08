
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
    public class ParametrosNeg
    {
        Parametros _parametros;



        public Boolean Actualizar(int contCuotas, double moraconsumo, double moraacometida)
        {
            _parametros.CuotasPenMax = contCuotas;
            _parametros.MoraConsumo= moraconsumo;
            _parametros.MoraAcometida = moraacometida;
            return _parametros.Actualizar();
        }

        public void PasarDatos(Panel pnl)
        {
            _parametros = new Parametros();
            _parametros = _parametros.Consultar();
            pnl.Controls.Find("txbMoraConsumo", true)[0].Text = _parametros.MoraConsumo.ToString();
            pnl.Controls.Find("txbMoraAcometida", true)[0].Text = _parametros.MoraAcometida.ToString();
            pnl.Controls.Find("txbMaxCuotas", true)[0].Text = _parametros.CuotasPenMax.ToString();
        }
    }
}
