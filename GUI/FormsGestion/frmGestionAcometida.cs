using Controllers;
using GUI.Clases;
using System;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class frmGestionAcometida : Form
    {
        public CuotasNeg cuotas;
        public ServiciosNeg _servicio;
        public ServiciosAcometidaNeg _acometida;
        const string patronDecimal = @"\.";
        Boolean punto = false;
        Regex validar;
        int auxalcular;
        public frmGestionAcometida()
        {
            InitializeComponent();
            CargarDatos();
            cuotas = new CuotasNeg();
            _servicio = new ServiciosNeg();
            _acometida = new ServiciosAcometidaNeg();
        }

        private void frmGestionServicios_Load(object sender, EventArgs e)
        {
            OrganizadorObj.Organizar(2, 5, this.pnlPrincipal, pnlBoton.GetType());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validacion.seguroModificar() && !Validacion.esVacio(this.pnlPrincipal, this.ErrorNotificador))
            {
                if (string.IsNullOrEmpty(txbId.Text)) { txbId.Text = "0"; }
                if (_servicio.InsertarAcometida(int.Parse(txbId.Text.ToString()), int.Parse(cmbColonia.SelectedValue.ToString()),
                                            int.Parse(cmbCuota.SelectedValue.ToString()), float.Parse(txbMonto.Text.ToString()),
                                            float.Parse(txbSaldo.Text.ToString()), int.Parse(txbCuotasPagadas.Text.ToString()),
                                            int.Parse(txbNCuotas.Text.ToString()), cmbEstado.Text.ToString(), txbComentario.Text.ToString())) 
                {
                    Validacion.frmMessageBox("Registro Guardado", "¡Exito!");
                    this.Close();
                }
            }
        } 
        public void CargarDatos()
        {
            this.cmbColonia.DataSource = ColoniasNeg.consultar();
            this.cmbCuota.DataSource = CuotasNeg.consultarCuotasAcometida();
            cmbColonia.ValueMember = "idcolonia";
            cmbColonia.DisplayMember = "colonia";
            cmbColonia.SelectedIndex = -1;
            cmbCuota.DisplayMember = "monto";
            cmbCuota.ValueMember = "idcuotaacometida";
            cmbCuota.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txbNCuotas.Text = (float.Parse(txbMonto.Text.ToString()) / float.Parse(cmbCuota.GetItemText(cmbCuota.SelectedItem))).ToString();
                txbNCuotas.Update();
            }
            catch (Exception ex) { }
        }

        private void cmbCuota_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbNCuotas.Text = (float.Parse(txbMonto.Text.ToString()) / float.Parse(cmbCuota.GetItemText(cmbCuota.SelectedItem))).ToString();
                txbNCuotas.Update();
            }
            catch (Exception ex) { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                punto = Regex.IsMatch(this.txbMonto.Text.ToString(), patronDecimal) ? true : false;
                Validacion.Decimales(e, punto);
                if (cmbColonia.SelectedIndex > 0)
                {
                    auxalcular = int.Parse(txbMonto.Text.ToString()) / int.Parse(cmbCuota.GetItemText(cmbCuota.SelectedItem));
                    txbNCuotas.Text = auxalcular.ToString();
                }
                txbNCuotas.Update();
            }
            catch (Exception ex)
            { 
                Validacion.ErrorBox(ex);
            }
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
