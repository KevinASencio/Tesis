using Controllers;
using GUI.FormsProcesos;
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
    
    public partial class frmVerFacturasCli : Form
    {
        public int idcliente;
        BindingSource facturas= new BindingSource();
        FacturasNeg fac= new FacturasNeg();
        public frmVerFacturasCli()
        {
            InitializeComponent();
        }

        public void cargardatos() 
        {
            facturas.DataSource = fac.ConsultarFactuServ(idcliente);
            dtgvFacturas.AutoGenerateColumns = false;
            dtgvFacturas.DataSource = facturas;
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Filtrar() 
        {
            if (txbFiltro.Text.Length > 0)
            {
                facturas.Filter = String.Format("Convert(idfactura, 'System.String') LIKE '%{0}%' OR mes LIKE '%{0}%' OR Convert(fecha_vencimiento, 'System.String') LIKE '%{0}%'", txbFiltro.Text);
            }
            else { facturas.RemoveFilter(); }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void tsbCobrar_Click(object sender, EventArgs e)
        {
            frmCobroFacturas frm = new frmCobroFacturas();
            frm.buscar(dtgvFacturas.CurrentRow.Cells["idfactura"].Value.ToString());
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Normal;
            frm.Size = new Size(500, 500);
            frm.Refresh();
            frm.ShowDialog();
        }
    }
}
