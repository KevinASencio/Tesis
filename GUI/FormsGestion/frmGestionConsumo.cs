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
    public partial class frmGestionConsumo : Form
    {
        public frmGestionConsumo()
        {
            InitializeComponent();
            MessageBox.Show("si inicia");
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
