﻿using CapaDatos.Entidades;
using System;

namespace Controllers
{
    public class ServiciosNeg
    {
        Servicios _Servicio;

        public ServiciosNeg()
        {
            _Servicio = new Servicios();
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
        public Boolean insertarConsumo()
        {
            return this._Servicio.InsertarServicio("consumo");
        }
        public Boolean insertarAcometida()
        {
            return this._Servicio.InsertarServicio("acometida");
        }
        public Boolean actualizarServicio() { return this._Servicio.ActualizarServicio(); }
        public Boolean cambiarEstado()
        {
            return _Servicio.CambiarEstado();
        }
    }
}
