using System;
using System.Data;

namespace CapaDatos.Entidades
{
    public class Colonias
    {
        int _IdColonia;
        string _Colonia;

        public int IdColonia { get => _IdColonia; set => _IdColonia = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }

        public static DataTable consultar()
        {
            DBOperacion operacion = new DBOperacion();
            string sentencia = "select idcolonia, colonia from colonias;";
            try
            {
                return operacion.Consultar(sentencia);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }
    }
}
