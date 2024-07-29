using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
namespace GUI.FormsGestion
{
    public partial class frmVistaServicios : Form
    {
        BindingSource _datos = new BindingSource();
        ServiciosNeg servicio = new ServiciosNeg();
        public frmVistaServicios()
        {
            InitializeComponent();
        }

        private void frmVistaServicios_Load(object sender, EventArgs e)
        {
            //CargarDatos(0);
        }

        public void CargarDatos(int id) 
        {
            if (id == 0)
            {
                _datos.DataSource = CapaNegocio.SistemCache.ConsultarServicios();
                this.dtgvServicios.AutoGenerateColumns = false;
                this.dtgvServicios.DataSource = _datos;
                this.dtgvServicios.Update();
                statusStrip1.Text = _datos.Count.ToString() + " Regsitros Encontrados";
            }
            else
            {
                _datos.DataSource = CapaNegocio.SistemCache.ConsultarServicios(id);
                this.dtgvServicios.AutoGenerateColumns = false;
                this.dtgvServicios.DataSource = _datos;
                this.dtgvServicios.Update();
                statusStrip1.Text = _datos.Count.ToString() + " Regsitros Encontrados";
            }
            
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
