using Controllers;
using GUI.Clases;
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
    public partial class frmGestionConsumo : Form
    {
        public ServiciosNeg _servicio;
        public ServiciosConsumoNeg _consumo;
        BindingSource cuotasConsumo = new BindingSource();
        public frmGestionConsumo()
        {
            InitializeComponent();
            this.ErrorNotificador = new ErrorProvider();
            _consumo = new ServiciosConsumoNeg();
            _servicio = new ServiciosNeg();
            CargarDatos();
            OrganizadorObj.Organizar(1, 7, pnlPrincipal, panel1.GetType());
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            this.cmbColonia.DataSource = ColoniasNeg.consultar();

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
                _servicio.setIdColonia(int.Parse(cmbColonia.SelectedValue.ToString()));
                _servicio.setEstado(cmbEstado.Text.ToString());
                _servicio.setComentario(txbComentario.Text.ToString());
                if (this.txbId.Text.Length <= 0)
                {
                    if (!_consumo.insertar(int.Parse(cmbCuota.SelectedValue.ToString()))) { MessageBox.Show("¡Error al guardar la cuota!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        _servicio.setIdConsumo(_consumo.getIdServicioConsumo());
                        if (_servicio.insertarConsumo())
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
                    _consumo.setIdCuotaConsumo(int.Parse(cmbCuota.SelectedValue.ToString()));
                    if (!_consumo.actualizar()) { MessageBox.Show("¡Error al actualizar la cuota!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        if (_servicio.actualizarServicio()) { MessageBox.Show("Registro actualizado con Exito", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                    }
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
