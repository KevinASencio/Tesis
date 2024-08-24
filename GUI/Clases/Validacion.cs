﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace GUI.Clases
{
    public static class Validacion
    {

        public static Boolean esVacio(System.Windows.Forms.Control contenedor, System.Windows.Forms.ErrorProvider notificador)
        {
            bool esVacio = false;
            try
            {
                foreach (System.Windows.Forms.Control item in contenedor.Controls)
                {
                    foreach (System.Windows.Forms.Control aux in item.Controls)
                    {
                        try
                        {
                            if (aux.Text.Length <= 0 && aux.Name != "txbId" && aux.Name != "txbComentario")
                            {
                                notificador.SetError(aux, "Este campo no puede queda vacío");
                                esVacio = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString() + " no se completo la validación desde el inicio");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " no se completo la validación desde el inicio");
            }
            return esVacio;
        }

        public static Boolean seguroModificar() 
        {
             return MessageBox.Show("Realmente desea Guardar los Cambios?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ?  true : false;
        }

        public static Boolean seguroCambiarEstado()
        {
            return MessageBox.Show("Realmente desea Cambiar el Estado del Servicio?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? true : false;
        }

        public static bool Decimales(KeyPressEventArgs v, Boolean a)
        {
            if (char.IsDigit(v.KeyChar) || char.IsControl(v.KeyChar) || (v.KeyChar == '.' && !a)) { v.Handled = false; }
            else{ v.Handled = true; return false;}
            return true;
        }
    }
}