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

namespace GUI.FormsProcesos
{
    public partial class frmCobroFacturas : Form
    {
        public frmCobroFacturas()
        {
            InitializeComponent();
        }

        private void frmCobroFacturas_Load(object sender, EventArgs e)
        {
            OrganizadorObj.Organizar(1,9,this,panel1.GetType());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscar();
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
