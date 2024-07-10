using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUI.Clases
{
    public static class OrganizadorObj
    {
        public static void Organizar(int cantx, int canty, System.Windows.Forms.Control contenedor, Type a)
        {
            int PosX = 0, PosY = 0;
            Int16 cont = 0;
            Int16 linea = 0;


            foreach (System.Windows.Forms.Control cr in contenedor.Controls)
            {
                if (a == cr.GetType())
                {
                    try
                    {
                        PosX = (contenedor.Width - cr.Width * cantx) / (cantx + 1);
                        PosY = (contenedor.Height - cr.Height * canty) / (canty + 1);
                        if (cont < canty)
                        {
                            cr.Location = new Point((cr.Width * cont) + PosX * (cont + 1), (cr.Height * linea) + PosY * (linea + 1));
                        }
                        else
                        {
                            cr.Location = new Point((cr.Width * cont) + PosX * (cont + 1), (cr.Height * linea) + PosY * (linea + 1));
                        }
                        cr.Update();
                        if (cont >= cantx - 1) { cont = 0; linea++; } else { cont++; };

                    }
                    catch (Exception ex)
                    { Console.WriteLine(ex.Message); }
                }
            }
        }
    }
}
