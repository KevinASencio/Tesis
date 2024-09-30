using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    public class DBOperacion : DBConexion
    {
        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }

        public Boolean Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Boolean Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Boolean Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Boolean EjecutarProcedure(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        private Boolean EjecutarSentencia(String pSentencia)
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

            return FilasAfectadas > 0 ? true : false;
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
