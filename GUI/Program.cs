﻿using System;
using System.Diagnostics;
using System.Threading;
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
            int a;
            bool nuevaInstancia;
            using (Mutex mu = new Mutex(true, Process.GetCurrentProcess().ProcessName, out nuevaInstancia))
            {
                if (nuevaInstancia)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Clases.AppManager());

                }
                else
                {
                    MessageBox.Show("YA hay una instancia de este programa");
                }
            }
        }
    }
}
