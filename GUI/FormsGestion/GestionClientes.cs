using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.ClientesNeg;
namespace GUI.FormsGestion
{
    public partial class GestionClientes : Form
    {
        BindingSource listclientes ;
        ClientesNeg clientes;
        int alto;
        int aux;
        public GestionClientes()
        {
            listclientes = new BindingSource();
            clientes = new ClientesNeg();
            InitializeComponent();
            alto = this.Location.Y;

        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            dtgvClientes.AutoGenerateColumns = false;
            listclientes.DataSource = clientes.ConsultarClientes();
            dtgvClientes.DataSource = listclientes;

        }

        private void GestionClientes_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void GestionClientes_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        private void GestionClientes_SizeChanged(object sender, EventArgs e)
        {
           
        }
    }
}
