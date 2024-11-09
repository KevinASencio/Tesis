using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ControlBancoNeg
    {
        ControlMensualBanco _ControlBanco;

        public void getCtBanco() 
        {
            _ControlBanco= new ControlMensualBanco();
            _ControlBanco.Consultar();
        }
        public int getid() { return this._ControlBanco.IdControlBanco; }
        public Boolean CierreCaja()
        {
            _ControlBanco = new ControlMensualBanco();
            _ControlBanco.Consultar();
            if (_ControlBanco.CierreMes())
            {
                ControlMensualBanco nuevo = new ControlMensualBanco();
                nuevo.SaldoFinal = _ControlBanco.SaldoFinal;
                nuevo.SaldoInicial = _ControlBanco.SaldoFinal;
                nuevo.FechaInicio = DateTime.Now.AddDays(1);
                return nuevo.insertar();
            }
            return false;
        }
        public System.Data.DataTable ConsultarLista()
        {
            _ControlBanco = new ControlMensualBanco();
            return _ControlBanco.ConsultarLista();
        }

        public DataTable Consultar(int id)
        {
            _ControlBanco = new ControlMensualBanco();
            _ControlBanco.IdControlBanco = id;
            return _ControlBanco.ConsultarRep();
        }
    }
}
