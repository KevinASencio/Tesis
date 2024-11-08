using Controllers;
using GUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class frmGestionParametros : Form
    {
        ParametrosNeg parametros;
        public frmGestionParametros()
        {
            InitializeComponent();
            parametros = new ParametrosNeg();
        }

        private void frmGestionParametros_Load(object sender, EventArgs e)
        {
            parametros.PasarDatos(pnlPrincipal);
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validacion.esVacio(pnlPrincipal,ErrorNotificador))
            {
                if(parametros.Actualizar(int.Parse(txbMaxCuotas.Text.ToString()), double.Parse(txbMoraConsumo.Text.ToString()), double.Parse(txbMoraAcometida.Text.ToString())))
                {
                    Validacion.frmMessageBox("Cambios Guardados", "Exito");
                    parametros.PasarDatos(pnlPrincipal);
                }
            }
        }
    }
}
