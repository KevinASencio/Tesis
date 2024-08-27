using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ServiciosAcometidaNeg
    {
        ServiciosAcometida _Acometida;
        public ServiciosAcometidaNeg() 
        {
            this._Acometida = new ServiciosAcometida();
        }

        public void setIdAcometida(int id) { _Acometida.Idserviciosacometida = id; }
        public void setIdcuota(int id) {_Acometida.Idcuotaacometida = id;}
        public void setMonto(float monto){_Acometida.Monto = monto;}
        public void setSaldo(float saldo){_Acometida.Saldo = saldo;}
        public void setNCuotaspagadas(int cant) {_Acometida.Cuotaspagadas = cant; }
        public void setNCuotas(int cuotas) { _Acometida.Numeredecuotas = cuotas;}

        public int getIdServicioAcometida() { return _Acometida.Idserviciosacometida; }
        public int getIdcuota(){return _Acometida.Idcuotaacometida;}
        public float getMonto() {return _Acometida.Monto;}
        public float setSaldo(){return _Acometida.Saldo;}
        public int getNCuotaspagadas() {return _Acometida.Cuotaspagadas;}
        public int getNCuotas(){return _Acometida.Numeredecuotas;}

        public Boolean InsertarAcometida() 
        {
            return _Acometida.agregar();
        }
        public Boolean ActualizarAcometida() { return _Acometida.Actualizar(); }
    }
}
