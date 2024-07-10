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
    public partial class frmVistaClientes : Form
    {
       BindingSource ListaClientes = new BindingSource();
        public frmVistaClientes()
        {
            InitializeComponent();
        }

        private void frmVistaClientes_Load(object sender, EventArgs e)
        {

            ListaClientes.DataSource = CapaNegocio.ClientesNeg.ConsultarClientes();
            //dgtvClientes.AutoGenerateColumns = false;
            //dgtvClientes.DataSource = ListaClientes;
            //txbFiltro
           
        }
    }
}
