using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DBOperacion : DBConexion
    {
        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }

        public Int32 Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Int32 EjecutarProcedure(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        private Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 FilasAfectadas = 0;
            if (base.Conectar())
            {
                MySqlCommand Comando = new MySqlCommand();
                Comando.CommandText = pSentencia;
                Comando.Connection = base.oConexion;
                FilasAfectadas = Comando.ExecuteNonQuery();
                base.Desconectar();
            }
            return FilasAfectadas;
        }
        private DataTable EjecutarConsulta(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            if (base.Conectar())
            {
                MySqlDataAdapter Adaptador = new MySqlDataAdapter();
                MySqlCommand Comando = new MySqlCommand();
                Comando.CommandText = pConsulta;
                Comando.Connection = base.oConexion;
                Adaptador.SelectCommand = Comando;
                Adaptador.Fill(Resultado);
                base.Desconectar();
            }
            return Resultado;
        }

    }
}
