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
    public partial class frmVerClientes : Form
    {
        BindingSource _clientes = new BindingSource();

        public frmVerClientes()
        {
            InitializeComponent();
            _clientes.DataSource = CapaNegocio.ClientesNeg.ConsultarClientes();
            dtgvClientes.DataSource = _clientes;
        }

        public void editar() 
        {
            MessageBox.Show(dtgvClientes.SelectedRows.Count.ToString());
        }
    }
}
