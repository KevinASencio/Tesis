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
namespace GUI
{
    public partial class Form1 : Form
    {
        ClientesNeg Cliente;
        BindingSource _Clientes;
        public Form1()
        {
            Cliente = new ClientesNeg();
            _Clientes = new BindingSource();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAbrirClientes_Click(object sender, EventArgs e)
        {
            FormsGestion.frmPrincipal frmCliente = new FormsGestion.frmPrincipal();
            AbrirEnContenedor(frmCliente);
        }

        //abrir el formularion dentro del panel Contenedor
        private void AbrirEnContenedor(object frm)
        {
            if (this.Contenedor.Controls.Count > 1)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
            Form aux = frm as Form;
            aux.TopLevel = false;
            aux.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(aux);
            this.Contenedor.Tag = aux;
            aux.BringToFront();
            aux.Show();

        }
    }


}
