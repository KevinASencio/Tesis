using Controllers;
using GUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace GUI.FormsGestion
{
    public partial class frmGestionCuotas : Form
    {
        BindingSource consumo = new BindingSource();
        BindingSource acometida = new BindingSource();
        const string patronDecimal = @"\.";
        CuotasNeg cuota= new CuotasNeg();
        Boolean punto = false;
        Regex validar;
        public frmGestionCuotas()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGestionCuotas_Load(object sender, EventArgs e)
        {
            cargardatos();
            OrganizadorObj.Organizar(1, 2, splContenedor.Panel1, panel1.GetType());
        }

        public void cargardatos() 
        {
            dgtvAcometida.DataSource = CuotasNeg.consultarCuotasAcometida();
            dgtvAcometida.AutoGenerateColumns=false;
            dgtvConsumo.DataSource = CuotasNeg.consultarCuotasConsumo();
            dgtvConsumo.AutoGenerateColumns = false;
        }

        private void dgtvConsumo_DoubleClick(object sender, EventArgs e)
        {
            txbIdCon.Text=dgtvConsumo.CurrentRow.Cells["idcuota"].Value.ToString();
            txbCuotaCon.Text = dgtvConsumo.CurrentRow.Cells["monto"].Value.ToString();
        }

        private void txbCuotaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDecimales(e, this.txbCuotaCon);
        }

        private void toolStripCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuararCon_Click(object sender, EventArgs e)
        {
            if (txbCuotaCon.Text.Length == 0)
            {
                ErrorNotificador.SetError(txbCuotaCon, "Este Campo no Puede Quedar Vacío!");
            }
            else 
            {
                if (String.IsNullOrEmpty(txbIdCon.Text)) { txbIdCon.Text = "0"; }
                if (cuota.ProcesarCuotaConsumo(int.Parse(txbIdCon.Text.ToString()), float.Parse(txbCuotaCon.Text.ToString())))
                {
                    Validacion.frmMessageBox("¡Registro Guardado!", "¡Exito!");
                    txbIdCon.Clear();
                    txbCuotaCon.Clear();
                    cargardatos();
                }
            }
        }

        private void txbCuotaAco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDecimales(e, txbCuotaAco);
        }

        public void ValidarDecimales(KeyPressEventArgs e, TextBox text)
        {
            try
            {
                punto = false;
                punto = Regex.IsMatch(text.Text.ToString(), patronDecimal) ? true : false;
                Validacion.Decimales(e, punto);
            }
            catch (Exception ex)
            { //Validacion.ErrorBox(ex);
            }
        }

        private void btnGuardarAco_Click(object sender, EventArgs e)
        {
            if (txbCuotaAco.Text.Length == 0)
            {
                ErrorNotificador.SetError(txbCuotaAco, "Este Campo no Puede Quedar Vacío!");
            }
            else
            {
                if (String.IsNullOrEmpty(txbIdAco.Text)) {txbIdAco.Text = "0"; }
                if (cuota.ProcesarCuotaConsumo(int.Parse(txbIdAco.Text.ToString()), float.Parse(txbCuotaAco.Text.ToString())))
                {
                    Validacion.frmMessageBox("¡Registro Guardado!", "¡Exito!");
                    txbCuotaAco.Clear();
                    txbIdAco.Clear();
                    cargardatos();
                }
            }
        }
    }
}
