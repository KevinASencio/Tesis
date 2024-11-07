using Controllers;
using GUI.Clases;
using System;
using System.Windows.Forms;

namespace GUI.FormsGestion
{
    public partial class frmGestionConsumo : Form
    {
        public ServiciosNeg _servicio;
        public ServiciosConsumoNeg _consumo;
        public ColoniasNeg _colonias;
        BindingSource cuotasConsumo = new BindingSource();
        public frmGestionConsumo()
        {
            InitializeComponent();
            this.ErrorNotificador = new ErrorProvider();
            _consumo = new ServiciosConsumoNeg();
            _servicio = new ServiciosNeg();
            CargarDatos();
            OrganizadorObj.Organizar(1, 8, pnlPrincipal, panel1.GetType());
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            _colonias = new ColoniasNeg();
            this.cmbColonia.DataSource = _colonias.consultar();

            this.cmbCuota.DataSource = CuotasNeg.consultarCuotasConsumo();
            cmbColonia.ValueMember = "idcolonia";
            cmbColonia.DisplayMember = "colonia";
            cmbColonia.SelectedIndex = -1;
            //cmbCuota.AutoCompleteSource;

            cmbCuota.DisplayMember = "monto";
            cmbCuota.ValueMember = "idcuotaconsumo";
            cmbCuota.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validacion.seguroModificar() && !Validacion.esVacio(this.pnlPrincipal, this.ErrorNotificador))
            {
                if (String.IsNullOrEmpty(txbId.Text)) { txbId.Text = "0";}
                if (_servicio.InsertarConsumo(int.Parse(txbId.Text.ToString()), int.Parse(cmbCuota.SelectedValue.ToString()),
                   txbComentario.Text.ToString(), cmbEstado.Text.ToString(), int.Parse(cmbColonia.SelectedValue.ToString()))) 
                {
                    Validacion.frmMessageBox("¡Regsitro Guardado!", "Exito");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
