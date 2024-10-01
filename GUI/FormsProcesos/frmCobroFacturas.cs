using Controllers;
using GUI.Clases;
using System;
using System.Data;
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
            OrganizadorObj.Organizar(1, 9, this, panel1.GetType());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscar();
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable factura = new DataTable();
            factura = FacturasNeg.ConsultarFactura(txbFactura.Text);
            lblCliente.Text = factura.Rows[0][1].ToString();
                
        }
    }
}
