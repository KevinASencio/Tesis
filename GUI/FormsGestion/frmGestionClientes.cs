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
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
            
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            Clases.OrganizadorObj.Organizar(1, 7, this,pnlApellidos.GetType());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
