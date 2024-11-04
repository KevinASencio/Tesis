using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Reportes
{
    public partial class frmRepFacturasColonia : Form
    {

        public frmRepFacturasColonia()
        {
            InitializeComponent();
        }

        public void CargarDatos() 
        {
            FacturasNeg fac = new FacturasNeg();
            DataTable listafacturas = new DataTable();
            listafacturas = fac.ConsultarReporteGen(1);
            Reportes.RepFacturasColonia facturas= new RepFacturasColonia();
            facturas.SetDataSource(listafacturas);
            crystalReportViewer1.ReportSource = facturas;
            //facturas.PrintToPrinter( new PrinterSettings(), new PageSettings(),false ); 
        }

        private void frmRepFacturasColonia_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
