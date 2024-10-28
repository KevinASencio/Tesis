using Controllers;
using GUI.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace GUI.FormsGestion
{
    public partial class frmVistaServicios : Form
    {
        BindingSource _datosConsumo = new BindingSource();
        BindingSource _datosAcometida = new BindingSource();
        public ServiciosNeg servicio = new ServiciosNeg();
        frmGestionConsumo _frmGestionConsumo;
        frmGestionAcometida _frmGestionAcometida;
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
            _frmGestionConsumo.txbId.Text = dtgvServiciosConsumo.CurrentRow.Cells["idservicio"].Value.ToString();
            _frmGestionConsumo.cmbColonia.SelectedValue = dtgvServiciosConsumo.CurrentRow.Cells["idcolonia"].Value.ToString();
            _frmGestionConsumo.cmbCuota.SelectedValue = dtgvServiciosConsumo.CurrentRow.Cells["idcuota"].Value.ToString();
            _frmGestionConsumo.cmbEstado.Text = dtgvServiciosConsumo.CurrentRow.Cells["estado"].Value.ToString();
            _frmGestionConsumo._consumo = new ServiciosConsumoNeg(int.Parse(dtgvServiciosConsumo.CurrentRow.Cells["idconsumo"].Value.ToString()), int.Parse(dtgvServiciosConsumo.CurrentRow.Cells["idcuota"].Value.ToString()));
            _frmGestionConsumo.Show();
        }

        private void frmVistaServicios_ControlAdded(object sender, ControlEventArgs e)
        {
            CargarDatos(this.servicio.getIdCliente());
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            cabiarestado(int.Parse(dtgvServiciosConsumo.CurrentRow.Cells["idservicio"].Value.ToString()), dtgvServiciosConsumo.CurrentRow.Cells["estado"].Value.ToString());
        }

        private void btnAgregarAco_Click(object sender, EventArgs e)
        {
            _frmGestionAcometida = new frmGestionAcometida();
            this.Controls.RemoveByKey("pnlTop");
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            _frmGestionAcometida.TopLevel = false;
            pnlPrincipal.Controls.Add(_frmGestionAcometida);
            _frmGestionAcometida.BringToFront();
            _frmGestionAcometida.Size = new Size(this.Width, this.Height);
            agregando = true;
            _frmGestionAcometida._acometida.setIdAcometida(0);
            _frmGestionAcometida._servicio.setIdCliente(this.servicio.getIdCliente());
            _frmGestionAcometida.Show();
        }


        private void btnEditarAco_Click(object sender, EventArgs e)
        {
            _frmGestionAcometida = new frmGestionAcometida();
            this.Controls.RemoveByKey("pnlTop");
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            _frmGestionAcometida.TopLevel = false;
            pnlPrincipal.Controls.Add(_frmGestionAcometida);
            _frmGestionAcometida.BringToFront();
            _frmGestionAcometida.Size = new Size(this.Width, this.Height);
            agregando = true;
            _frmGestionAcometida._servicio.setIdCliente(this.servicio.getIdCliente());
            _frmGestionAcometida._acometida.setIdAcometida(int.Parse(dtgvServiciosAcometida.CurrentRow.Cells["idacometida"].Value.ToString()));
            _frmGestionAcometida.txbId.Text = dtgvServiciosAcometida.CurrentRow.Cells["idservicioA"].Value.ToString();
            _frmGestionAcometida.txbComentario.Text = dtgvServiciosAcometida.CurrentRow.Cells["comentarioA"].Value.ToString();
            _frmGestionAcometida.txbMonto.Text = dtgvServiciosAcometida.CurrentRow.Cells["monto"].Value.ToString();
            _frmGestionAcometida.cmbCuota.SelectedValue = dtgvServiciosAcometida.CurrentRow.Cells["idcuotaA"].Value.ToString();
            _frmGestionAcometida.cmbColonia.SelectedValue = dtgvServiciosAcometida.CurrentRow.Cells["idcoloniaA"].Value.ToString();
            _frmGestionAcometida.cmbEstado.Text = dtgvServiciosAcometida.CurrentRow.Cells["estadoA"].Value.ToString();
            _frmGestionAcometida.txbSaldo.Text = dtgvServiciosAcometida.CurrentRow.Cells["saldo"].Value.ToString();
            _frmGestionAcometida.cmbCuota.Enabled = false;
            _frmGestionAcometida.txbSaldo.Enabled = false;
            _frmGestionAcometida.txbMonto.Enabled = false;
            _frmGestionAcometida.txbNCuotas.Enabled = false;
            _frmGestionAcometida.Show();
        }

        private void btnCambiarEstadoAco_Click(object sender, EventArgs e)
        {
            cabiarestado(int.Parse(dtgvServiciosAcometida.CurrentRow.Cells["idservicioA"].Value.ToString()), dtgvServiciosAcometida.CurrentRow.Cells["estadoA"].Value.ToString());
        }

        public void cabiarestado(int id, string estado)
        {
            if (Validacion.seguroCambiarEstado())
            {
                servicio.setIdServicio(id);
                if (estado == "ACTIVO") { servicio.setEstado("DE BAJA"); }
                else { servicio.setEstado("ACTIVO"); }

                if (servicio.cambiarEstado()) { MessageBox.Show("Estado Cambiado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("No se ha podido cambiar el estado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            CargarDatos(this.servicio.getIdCliente());
        }

        public void algo()
        {
        }
    }
}
