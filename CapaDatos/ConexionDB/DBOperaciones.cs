using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos
{
    public class DBOperacion : DBConexion
    {
        public DataTable Consultar(String pConsulta, Dictionary<string, object> dic)
        {
            return EjecutarConsulta(pConsulta, dic);
        }
        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }

        public Boolean Insertar(String pSentencia,Dictionary<string,object>dic)
        {
            return EjecutarSentencia(pSentencia, dic);
        }
        public Boolean Actualizar(String pSentencia,Dictionary<string, object>dic)
        {
            return EjecutarSentencia(pSentencia, dic);
        }
        public Boolean Eliminar(String pSentencia, Dictionary<string, object> dic)
        {
            return EjecutarSentencia(pSentencia,dic);
        }
        public Boolean EjecutarProcedure(String pSentencia, Dictionary<string, object> dic)
        {
            return EjecutarSentencia(pSentencia,dic);
        }
        private Boolean EjecutarSentencia(String pSentencia, Dictionary<string, object> dic)
        {
            Int32 FilasAfectadas = 0;
            if (base.Conectar())
            {
                MySqlCommand Comando = new MySqlCommand();
                Comando.CommandText = pSentencia;
                Comando.Connection = base.oConexion;
                foreach (var parametro in dic)
                {
                    switch (parametro.Value)
                    {
                        case int value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case double value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case float value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case string value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case DateTime value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        default: throw new InvalidOperationException("Tipo de parámetro no soportado.");
                    }
                }
                FilasAfectadas = Comando.ExecuteNonQuery();
                base.Desconectar();
            }
            return FilasAfectadas > 0 ? true : false;
        }
        private DataTable EjecutarConsulta(String pConsulta, Dictionary<string, object> dic)
        {
            DataTable Resultado = new DataTable();
            if (base.Conectar())
            {
                MySqlDataAdapter Adaptador = new MySqlDataAdapter();
                MySqlCommand Comando = new MySqlCommand();
                Comando.CommandText = pConsulta;
                Comando.Connection = base.oConexion;
                foreach (var parametro in dic)
                {
                    switch (parametro.Value)
                    {
                        case int value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case double value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case float value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case string value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        case DateTime value:
                            Comando.Parameters.AddWithValue(parametro.Key, value);
                            break;
                        default: throw new InvalidOperationException("Tipo de parámetro no soportado.");
                    }
                }
                Adaptador.SelectCommand = Comando;
                Adaptador.Fill(Resultado);
                base.Desconectar();
            }
            return Resultado;
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
