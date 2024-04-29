using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool nuevaInstancia;
            using (Mutex mu= new Mutex(true, Process.GetCurrentProcess().ProcessName, out nuevaInstancia))
            {
                if (nuevaInstancia)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());

                }
                else
                {
                    MessageBox.Show("YA hay una Instancia de este programa");
                }
            }
        }
    }
}
