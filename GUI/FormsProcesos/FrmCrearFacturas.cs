using Controllers;
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
    public partial class FrmCrearFacturas : Form
    {
        FacturasNeg fac = new FacturasNeg(); 
        ControlFechasNeg fecha= new ControlFechasNeg();
        public FrmCrearFacturas()
        {
            InitializeComponent();
        }


        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGnerar_Click(object sender, EventArgs e)
        {
            fecha.
        }
    }
}
