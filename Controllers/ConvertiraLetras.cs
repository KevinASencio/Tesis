using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class ConvertiraLetras
    {
        string[] letras = { "", "UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE",
                        "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE", "VEINTE",
                        "VEINTIUN", "VEINTIDOS", "VEINTITRES", "VEINTICUATRO", "VEINTICINCO", "VEINTISEIS", "VEINTISIETE", "VEINTIOCHO", "VEINTINUEVE" };

        Dictionary<int, string> Unidades;
        Dictionary<int, string> Centenas;
        Dictionary<int, string> Decenas;
        public ConvertiraLetras()
        {
            //rellenar diccionario para las unidades
            Unidades = new Dictionary<int, string>();
            for (int i = 0; i < letras.Length; i++)
            {
                Unidades.Add(i, letras[i]);
            }
            //rellenar dicionario para las centenas
            Centenas = new Dictionary<int, string>{{ 1, "CIEN" }, { 2, "DOSCIENTOS" }, { 3, "TRESCIENTOS" }, { 4, "CUATROCIENTOS" },
                                                  { 5, "QUINIENTOS" }, { 6, "SEISCIENTOS" }, { 7, "SETECIENTOS" }, { 8, "OCHOCIENTOS" }, { 9, "NOVECIENTOS" }};
            //rellenar diccionario para decenas
            Decenas = new Dictionary<int, string> { { 3, "TREINTA" }, { 4, "CUARENTA" }, { 5, "CINCUENTA" }, { 6, "SESENTA" },
                                                    { 7, "SETENTA" }, { 8, "OCHENTA" }, { 9, "NOVENTA" } };
        }
        public string Convertir(double monto)
        {
            string cadena = string.Empty;
            int unidades = 0;
            int decenas = 0;
            int centenas = 0;
            int centavos = 0;
            //se divide entre 100 para saber las centenas ej: 320/100 => 3 centenas
            centenas = (int)monto / 100;
            //se resta el valor de las centenas para que queden las decenas ej: 300-(3*100)
            monto = monto - (centenas * 100);

            if (monto >= 30)
            {
                //divido entre 100 para saber las decenas ej: 35/10 => 3 decenas, pero se hace esto solo si es mayor o igual a 30
                decenas = (int)monto / 10;
                //
                monto = monto - (decenas * 10);
            }
            //queda separar los unidades de los decimales
            unidades = (int)monto;
            //restamos las unidades dejando unicacomente los decimales si los hubiere ej 0.2
            monto = monto - unidades;

            if (centenas>=1)
            {
                if (centenas == 1 && (decenas > 0 || unidades > 0))
                {
                    cadena = "CIENTO";
                }
                else { cadena += this.Centenas[centenas]; }
            }

            if (decenas > 0)
            {
                cadena += " ";
                if (decenas >= 3)
                {
                    cadena += this.Decenas[decenas];
                    if (unidades > 0) cadena += " Y ";
                };
            }
            if(unidades>=1)
            {
                cadena += letras[unidades];
            }
            centavos=Convert.ToInt32(monto*100);
            cadena += " " + centavos + "/100 DOLARES";
            
            return cadena;
        }


    }
}


