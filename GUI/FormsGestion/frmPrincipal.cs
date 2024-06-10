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
using CapaNegocio.UsuarioNeg;
namespace GUI.FormsGestion
{
    public partial class frmPrincipal : Form
    {
        static UsuarioNeg _UserActivo= new UsuarioNeg();
        BindingSource listclientes ;
        ClientesNeg clientes;
        int alto;
        int aux;
        public frmPrincipal()
        {
            listclientes = new BindingSource();
            clientes = new ClientesNeg();
            InitializeComponent();
            alto = this.Location.Y;
        }

        public static UsuarioNeg UserActivo { get => _UserActivo; set => _UserActivo = value; }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            dtgvClientes.AutoGenerateColumns = false;
            listclientes.DataSource = clientes.ConsultarClientes();
            dtgvClientes.DataSource = listclientes;
            MessageBox.Show(_UserActivo.Permisos()[0].ToString());
            lblprueba.Text = "el usuario es " + _UserActivo.usuario() + " el nombre es " + _UserActivo.nombres() + " el estado es "+ _UserActivo.estado(); 
            MessageBox.Show("el usuario es " + _UserActivo.usuario());

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
