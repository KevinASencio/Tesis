using CapaNegocio;
using Controllers;
using GUI.Clases;
using GUI.FormsGestion;
using GUI.FormsMessageBox;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.FormsProcesos
{
    public partial class frmCobroFacturas : Form
    {
        FacturasNeg factura = new FacturasNeg();
        ClientesNeg cliente = new ClientesNeg();
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
            buscar(txbFactura.Text.ToString());
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (factura.procesar(double.Parse(txbTotalPagar.Text.ToString()), double.Parse(txbDescuento.Text.ToString()), frmPrincipal.useractivo.usuario())) 
            { 
                Validacion.frmMessageBox("¡Cobro realizado!", "Exito");
                LimpiarInf();
            }
        }

        public void buscar(string idfactura) 
        {
            factura.ConsultarFactura(idfactura, this);
        }
        public void LimpiarInf() 
        {
            lblMes.Text = string.Empty;
            lblCliente.Text = string.Empty;
            lblMesesPen.Text = string.Empty;
            lblIdFactura.Text = string.Empty;
            lblMonto.Text = string.Empty;
            lblMora.Text = string.Empty;
            txbDescuento.Clear();
            txbFactura.Clear();
            txbTotalPagar.Clear();
        }
    
    }

}
