using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
namespace Controllers
{
    public class ControlCajaNeg
    {
        ControlMensualCaja _ControlCaja;

        public Boolean CierreCaja() 
        {
            _ControlCaja = new ControlMensualCaja();
            _ControlCaja.Consultar();
            if (_ControlCaja.CierreCaja())
            {
                ControlMensualCaja nuevo = new ControlMensualCaja();
                nuevo.FechaInicio = DateTime.Now.AddDays(1);
                nuevo.SaldoInicial = _ControlCaja.SaldoFinal;
                nuevo.SaldoFinal = _ControlCaja.SaldoFinal;
                return nuevo.insertar();
            }
            return false;
        }
    }
}
