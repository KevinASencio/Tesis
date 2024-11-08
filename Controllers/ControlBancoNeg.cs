using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ControlBancoNeg
    {
        ControlMensualBanco _ControlBanco;

        public Boolean CierreCaja() 
        {
            _ControlBanco = new ControlMensualBanco();
            _ControlBanco.Consultar();
            if (_ControlBanco.CierreMes()) 
            {
                ControlMensualBanco nuevo= new ControlMensualBanco();
                nuevo.SaldoFinal = _ControlBanco.SaldoFinal;
                nuevo.SaldoInicial = _ControlBanco.SaldoFinal;
                nuevo.FechaInicio = DateTime.Now.AddDays(1);
                return nuevo.insertar();
            }
            return false;
        }
    }
}
