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

namespace GUI.FormsMessageBox
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            OrganizadorObj.Organizar(1, 1, this.panel1, lblMensaje.GetType());
        }
    }
}
