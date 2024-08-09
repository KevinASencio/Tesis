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

            _datosConsumo.DataSource = CapaNegocio.SistemCache.ConsultarServiciosCon(id);
            this.dtgvServiciosConsumo.AutoGenerateColumns = false;
            this.dtgvServiciosConsumo.DataSource = _datosConsumo;

            this.dtgvServiciosConsumo.Update();
            pnlConsumo.Dock = DockStyle.Bottom;
            pnlConsumo.Size = new Size(this.Width, (this.Size.Height / 2) - 25);
            pnlConsumo.Update();
            pnlAcometida.Dock = DockStyle.Bottom;
            pnlAcometida.Size = new Size(this.Width, this.Size.Height / 2);
            pnlAcometida.Update();
            _datosAcometida.DataSource = CapaNegocio.SistemCache.ConsultarServiciosAco(id);
            this.dtgvServiciosAcometida.AutoGenerateColumns = false;
            this.dtgvServiciosAcometida.DataSource = _datosAcometida;
            this.dtgvServiciosAcometida.Update();


        }
        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _frmGestionConsumo = new frmGestionConsumo();
            this.Controls.RemoveByKey("pnlTop");
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            _frmGestionConsumo.TopLevel = false;
            pnlPrincipal.Controls.Add(_frmGestionConsumo);
            _frmGestionConsumo.BringToFront();
            agregando = true;
            _frmGestionConsumo._servicio.setIdCliente(this.servicio.getIdCliente());
            _frmGestionConsumo.Show();
        }

        private void pnlPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (agregando)
            {
                pnlPrincipal.BorderStyle = BorderStyle.None;
                this.Controls.Add(pnlTop);
                pnlPrincipal.Controls.Add(pnlConsumo);
                pnlPrincipal.Controls.Add(pnlAcometida);
                agregando = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _frmGestionConsumo = new frmGestionConsumo();
            this.Controls.RemoveByKey("pnlTop");
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            _frmGestionConsumo.TopLevel = false;
            pnlPrincipal.Controls.Add(_frmGestionConsumo);
            _frmGestionConsumo.BringToFront();
            agregando = true;
            _frmGestionConsumo._servicio.setIdCliente(this.servicio.getIdCliente());
            _frmGestionConsumo.txbComentario.Text = dtgvServiciosConsumo.CurrentRow.Cells["comentario"].Value.ToString();
            _frmGestionConsumo.txbId.Text = dtgvServiciosConsumo.CurrentRow.Cells["idcliente"].Value.ToString();
            _frmGestionConsumo.cmbColonia.SelectedItem = dtgvServiciosConsumo.CurrentRow.Cells["idcolonia"].Value.ToString();
            _frmGestionConsumo.cmbCuota.SelectedItem = dtgvServiciosConsumo.CurrentRow.Cells["idcuota"].Value.ToString();
            _frmGestionConsumo.cmbEstado.Text = dtgvServiciosConsumo.CurrentRow.Cells["estado"].Value.ToString();
            _frmGestionConsumo._consumo = new ServiciosConsumoNeg(int.Parse(dtgvServiciosConsumo.CurrentRow.Cells["idconsumo"].Value.ToString()), int.Parse(dtgvServiciosConsumo.CurrentRow.Cells["idcuota"].Value.ToString()));
            _frmGestionConsumo.Show();
        }
    }
}
