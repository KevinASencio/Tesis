using MySql.Data.MySqlClient;
using System;

namespace CapaDatos
{
    public class DBConexion
    {
        protected MySqlConnection oConexion;
        String CadenaConexion = "Server=localhost;Port=3306;Database=db_acacuvan;Uid=root;Pwd=admin";

        protected Boolean Conectar()
        {
            Boolean Conectado = false;
            try
            {
                oConexion = new MySqlConnection();
                oConexion.ConnectionString = CadenaConexion;
                oConexion.Open();
                Conectado = true;
            }
            catch
            {
                Conectado = false;
            }
            return Conectado;
        }
        protected void Desconectar()
        {
            try
            {
                if (oConexion.State == System.Data.ConnectionState.Open)
                {
                    oConexion.Close();
                }
            }
            catch
            {

            }
        }
    }
}
