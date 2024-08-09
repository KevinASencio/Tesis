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
        ServiciosNeg _servicio;
        ServiciosConsumoNeg _consumo;
        BindingSource cuotasConsumo = new BindingSource();
        public frmGestionConsumo()
        {
            InitializeComponent();
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
            if (!esVacio())
            {
               
                _consumo.insertar(int.Parse(cmbCuota.SelectedValue.ToString()));
                _servicio.setIdConsumo(_consumo.getIdServicioConsumo());
                _servicio.setIdColonia(int.Parse(cmbColonia.SelectedValue.ToString()));
                _servicio.setEstado(cmbEstado.SelectedText.ToString());
                _servicio.setComentario(txbComentario.Text.ToString());
                if (_servicio.insertarConsumo()) 
                {
                    MessageBox.Show("Regsitro guardado con Exito", "¡Exito!", MessageBoxButtons.OK);
                }

            }
        }

        public Boolean esVacio()
        {
            try
            {
                foreach (System.Windows.Forms.Control item in this.pnlPrincipal.Controls)
                {
                    foreach (System.Windows.Forms.Control aux in item.Controls)
                    {
                        try
                        {
                            if (aux.Text.Length <= 0 && aux.Name != "txbId")
                            {
                                MessageBox.Show("el elemento " + aux.Name.ToString() + "esta vacio!");
                                return true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString() + " no se completo la validación en el bucle");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " no se completo la validación desde el inicio");
                return true;
            }
            return false;
        }
    }
}
