using CapaDatos.Entidades;
using System;
using System.Data;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Controllers
{
    public class ServiciosNeg
    {
        Servicios _Servicio;
        ServiciosConsumoNeg consumo = new ServiciosConsumoNeg();
        ServiciosAcometidaNeg acometida = new ServiciosAcometidaNeg();
        public ServiciosNeg()
        {
            _Servicio = new Servicios();
        }
        public ServiciosNeg(int idcliente)
        {
            _Servicio = new Servicios(idcliente);
        }

        public ServiciosNeg(ServiciosConsumoNeg con,ServiciosAcometidaNeg aco,int idcliente) 
        {
            _Servicio = new Servicios(idcliente);
            this.consumo = con;
            this.acometida = aco;
        }

        public ServiciosNeg(int idservicio, int idCliente, int idColonia)
        {
            this._Servicio = new Servicios();
            this._Servicio.IdServicio = idservicio;
            this._Servicio.IdCliente = idCliente;
            this._Servicio.IdColonia = idColonia;
        }
        public int getIdCliente() { return this._Servicio.IdCliente; }
        public void setIdCliente(int id) { this._Servicio.IdCliente = id; }
        public void setIdServicio(int id) { this._Servicio.IdServicio = id; }
        public void setIdColonia(int id) { this._Servicio.IdColonia = id; }
        public void setIdConsumo(int id) { this._Servicio.IdConsumo = id; }
        public void setIdAcometida(int id) { this._Servicio.IdAcometida = id; }
        public void setComentario(string comentario) { this._Servicio.Comentario = comentario; }
        public void setEstado(string estado) { this._Servicio.Estado = estado; }
        
        
        
        public Boolean insertarAcometida()
        {
            _Servicio.FechaApertura = DateTime.Now;
            return this._Servicio.InsertarServicio("acometida");
        }

        public Boolean InsertarAcometida(int idservicio, int idcolonia, int idcuota, float monto, float saldo, int cuotaspagadas, int ncuotas, string estado, string comentario) 
        {
            _Servicio.Estado = estado;
            _Servicio.IdColonia = idcolonia;
            _Servicio.Comentario = comentario;
            
            try 
            {
                //validar si el id es igual o menor a cero lo que se esta procesando es una insercion
                if (idservicio <= 0)
                {
                    if (acometida.Procesar( monto, saldo, cuotaspagadas, ncuotas, idcuota))
                    {
                        _Servicio.IdAcometida = acometida.getIdServicioAcometida();
                        return _Servicio.InsertarServicio("acometida");
                    }
                    else { return false; }
                }
                else 
                {
                    _Servicio.IdServicio= idservicio;
                    if (acometida.Procesar( monto, saldo, cuotaspagadas, ncuotas, idcuota)) 
                    {
                       return _Servicio.ActualizarServicio();
                    }
                }
            }catch(Exception ex){ Console.WriteLine("Error " + ex.Message); }    

            return false; 
        }

        public bool InsertarConsumo(int idServicio, int idCuota,  string comentario, string estado, int idColonia)
        {
            _Servicio.Estado = estado;
            _Servicio.IdColonia = idColonia;
            _Servicio.Comentario = comentario;

            try
            {
                if (idServicio <= 0)
                {
                    if (consumo.insertar(idCuota))
                    {
                        _Servicio.IdConsumo = consumo.getIdCuotaConsumo();
                        return _Servicio.InsertarServicio("consumo");
                    }
                }
                else
                {
                    _Servicio.IdServicio = idServicio;
                    if (consumo.actualizar())
                    {
                        return _Servicio.ActualizarServicio();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones 
                Console.WriteLine("Error: " + ex.Message);
            }

            return false;
        }


        public Boolean actualizarServicio() { return this._Servicio.ActualizarServicio(); }
        public Boolean cambiarEstado()
        {
            return _Servicio.CambiarEstado();
        }
        public DataTable ConsultarCon(int idcliente) 
        {
            return _Servicio.ConsultarCon(idcliente);
        }

        public DataTable ConsultarAco(int idcliente) 
        {
            return _Servicio.ConsultarAco(idcliente);
        }

        public DataTable ConsulatRep( String estado) 
        {
            return _Servicio.ConsulatRep(estado);
        }
    }
}
