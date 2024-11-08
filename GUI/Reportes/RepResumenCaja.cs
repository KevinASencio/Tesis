﻿using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Reportes
{
    public partial class frmRepResumenCaja : Form
    {
        ControlCajaNeg control = new ControlCajaNeg();
        MovimientosNeg movimiento = new MovimientosNeg();
        public frmRepResumenCaja()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos() 
        {
            cmbControl.DataSource = control.ConsultarLista();
            cmbControl.DisplayMember = "periodo";
            cmbControl.ValueMember = "idcontrol_caja";
        }


        private void tscCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbControl_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Reportes.RepResumenCaja repResumen = new RepResumenCaja();
                repResumen.SetDataSource(movimiento.ConsultarRepCaja(int.Parse(cmbControl.SelectedValue.ToString())));
                repResumen.SetParameterValue("mes", cmbControl.GetItemText(cmbControl.SelectedItem));
                crvResumenCaja.ReportSource = repResumen;
                
            }
            catch { }
        }
    }
}
