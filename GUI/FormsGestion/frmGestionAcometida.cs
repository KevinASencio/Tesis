using Controllers;
using GUI.Clases;
using System;

using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                _servicio.setIdColonia(int.Parse(cmbColonia.SelectedValue.ToString()));
                _servicio.setEstado(cmbEstado.Text.ToString());
                _servicio.setComentario(txbComentario.Text.ToString());
                _acometida.setIdcuota(int.Parse(cmbCuota.SelectedValue.ToString()));
                _acometida.setIdcuota(int.Parse(cmbCuota.SelectedValue.ToString()));
                _acometida.setMonto(float.Parse(txbMonto.Text.ToString()));
                _acometida.setSaldo(float.Parse(txbSaldo.Text.ToString()));
                _acometida.setNCuotaspagadas(int.Parse(txbCuotasPagadas.Text.ToString()));
                if (this.txbId.Text.Length <= 0)
                {
                    _acometida.setNCuotas(0);
                    _acometida.setSaldo(_acometida.getMonto());
                    if (!_acometida.InsertarAcometida()) { MessageBox.Show("¡Error al guardar la cuota!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        _servicio.setIdAcometida(_acometida.getIdServicioAcometida());
                        if (_servicio.insertarAcometida())
                        {
                            MessageBox.Show("Registro guardado con Exito", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("¡Error al guardar el registro!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    _servicio.setIdServicio(int.Parse(txbId.Text.ToString()));
                    if (!_acometida.ActualizarAcometida()) { MessageBox.Show("¡Error al actualizar la cuota!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        if (_servicio.actualizarServicio()) { MessageBox.Show("Registro actualizado con Exito", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                    }
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
            //cmbCuota.AutoCompleteSource;

            cmbCuota.DisplayMember = "monto";
            cmbCuota.ValueMember = "idcuotaacometida";
            cmbCuota.SelectedIndex = -1; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try {
                txbNCuotas.Text = (float.Parse(txbMonto.Text.ToString()) / float.Parse(cmbCuota.GetItemText(cmbCuota.SelectedItem))).ToString();
                txbNCuotas.Update();
            }catch(Exception ex){}
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
                txbNCuotas.Text = (float.Parse(txbMonto.Text.ToString()) / float.Parse(cmbCuota.GetItemText(cmbCuota.SelectedItem))).ToString();
                txbNCuotas.Update();
            }
            catch (Exception ex) { //Validacion.ErrorBox(ex);
                                   }
        }
    }
}
