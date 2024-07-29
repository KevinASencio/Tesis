using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Servicios
    {
        int _IdServicio;
        int _IdCliente;
        int _IdColonia;
        DateTime _FechaApertura;
        int _CuotasAnticipadas;
        StringBuilder _Comentario;
        int _IdCuotaConsumo;
        int _IdCuotaAcometida;
        string _Estado;

        public int IdServicio { get => _IdServicio; set => _IdServicio = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdColonia { get => _IdColonia; set => _IdColonia = value; }
        public DateTime FechaApertura { get => _FechaApertura; set => _FechaApertura = value; }
        public int CuotasAnticipadas { get => _CuotasAnticipadas; set => _CuotasAnticipadas = value; }
        public StringBuilder Comentario { get => _Comentario; set => _Comentario = value; }
        public int IdCuotaConsumo { get => _IdCuotaConsumo; set => _IdCuotaConsumo = value; }
        public int IdCuotaAcometida { get => _IdCuotaAcometida; set => _IdCuotaAcometida = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        public static DataTable Consultar() 
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("Select * from servicios;");
            try 
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }

        public static DataTable Consultar(int idcliente)
        {
            DBOperacion operacion = new DBOperacion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("Select * from servicios ");
            sentencia.Append("where idcliente = " + idcliente +";");
            try
            {
                return operacion.Consultar(sentencia.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return null;
            }
        }
    }
}
