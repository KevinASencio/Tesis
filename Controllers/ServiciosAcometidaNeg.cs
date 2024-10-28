using CapaDatos.Entidades;
using System;

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
        public void setIdcuota(int id) { _Acometida.Idcuotaacometida = id; }
        public void setMonto(float monto) { _Acometida.Monto = monto; }
        public void setSaldo(float saldo) { _Acometida.Saldo = saldo; }
        public void setNCuotaspagadas(int cant) { _Acometida.Cuotaspagadas = cant; }
        public void setNCuotas(int cuotas) { _Acometida.Numeredecuotas = cuotas; }

        public int getIdServicioAcometida() { return _Acometida.Idserviciosacometida; }
        public int getIdcuota() { return _Acometida.Idcuotaacometida; }
        public float getMonto() { return _Acometida.Monto; }
        public float setSaldo() { return _Acometida.Saldo; }
        public int getNCuotaspagadas() { return _Acometida.Cuotaspagadas; }
        public int getNCuotas() { return _Acometida.Numeredecuotas; }

        public Boolean Procesar( float monto, float saldo, int cuotaspagadas, int Ncuotas, int idcuota)
        {
            _Acometida.Idcuotaacometida = idcuota;
            _Acometida.Saldo = saldo;
            _Acometida.Monto = monto;
            _Acometida.Cuotaspagadas = cuotaspagadas;
            _Acometida.Numeredecuotas = Ncuotas;
            try
            {
                if (_Acometida.Idserviciosacometida == 0)
                {
                    return _Acometida.Insertar();
                }
                else 
                {
                    return _Acometida.Actualizar();
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            return _Acometida.Insertar();
        }
        public Boolean ActualizarAcometida() 
        { 
            
            return _Acometida.Actualizar();
        }
    }
}
