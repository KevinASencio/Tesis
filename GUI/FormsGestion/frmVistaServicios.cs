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
using GUI.Clases;
namespace GUI.FormsGestion
{
    public partial class frmVistaServicios : Form
    {
        BindingSource _datosConsumo = new BindingSource();
        BindingSource _datosAcometida = new BindingSource();
        public ServiciosNeg servicio = new ServiciosNeg();
        frmGestionConsumo _frmGestionConsumo;
        ServiciosConsumoNeg aa = new ServiciosConsumoNeg();
        bool agregando = false;
        public frmVistaServicios()
        {
            InitializeComponent();
        }
        private void frmVistaServicios_Load(object sender, EventArgs e)
        {
            CargarDatos(this.servicio.getIdCliente());
            OrganizadorObj.Organizar(1, 1, this.pnlTitulo1, lblConsumo.GetType());
            OrganizadorObj.Organizar(1, 1, this.pnlTitulo2, lblAcometida.GetType());
            
        }
        public void CargarDatos(int id) 
        {
            if (id == 0)
            {
                _datosConsumo.DataSource = CapaNegocio.SistemCache.ConsultarServiciosCon();
                this.dtgvServiciosConsumo.AutoGenerateColumns = false;
                this.dtgvServiciosConsumo.DataSource = _datosConsumo;
                this.dtgvServiciosConsumo.Update();
                _datosAcometida.DataSource= CapaNegocio.SistemCache.ConsultarServiciosAco();
                this.dtgvServiciosAcometida.AutoGenerateColumns=false;
                this.dtgvServiciosAcometida.DataSource = _datosAcometida;
                this.dtgvServiciosAcometida.Update();

            }
            else
            {
                _datosConsumo.DataSource = CapaNegocio.SistemCache.ConsultarServiciosCon(id);
                this.dtgvServiciosConsumo.AutoGenerateColumns = false;
                this.dtgvServiciosConsumo.DataSource = _datosConsumo;
                
                this.dtgvServiciosConsumo.Update();
                panel1.Dock = DockStyle.Bottom;
                panel1.Size = new Size(this.Width, (this.Size.Height/2)-25);
                panel1.Update();
                panel2.Dock = DockStyle.Bottom;
                panel2.Size = new Size(this.Width, this.Size.Height/2);
                panel2.Update();
                _datosAcometida.DataSource = CapaNegocio.SistemCache.ConsultarServiciosAco(id);
                this.dtgvServiciosAcometida.AutoGenerateColumns = false;
                this.dtgvServiciosAcometida.DataSource = _datosAcometida;
                this.dtgvServiciosAcometida.Update();
            }
            
        }
        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _frmGestionConsumo = new frmGestionConsumo();
            pnlPrincipal.Controls.Clear();
            _frmGestionConsumo.TopLevel = false;
            pnlPrincipal.Controls.Add(_frmGestionConsumo);
           // _frmGestionConsumo.Size= new Size(pnlPrincipal.Width,pnlPrincipal.Height);
            _frmGestionConsumo.BringToFront();
            agregando = true;
            _frmGestionConsumo.Show();
        }

        private void pnlPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (agregando)
            {
                pnlPrincipal.Controls.Add(panel1);
                pnlPrincipal.Controls.Add(panel2);
                agregando = false;
            }
        }
    }
}
