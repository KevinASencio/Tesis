namespace GUI.Reportes
{
    partial class frmRepServicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepServicios));
            this.crvServicios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlCmb = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlCmb.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvServicios
            // 
            this.crvServicios.ActiveViewIndex = -1;
            this.crvServicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvServicios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvServicios.EnableDrillDown = false;
            this.crvServicios.EnableToolTips = false;
            this.crvServicios.Location = new System.Drawing.Point(0, 63);
            this.crvServicios.Name = "crvServicios";
            this.crvServicios.ShowCloseButton = false;
            this.crvServicios.ShowCopyButton = false;
            this.crvServicios.ShowGroupTreeButton = false;
            this.crvServicios.ShowLogo = false;
            this.crvServicios.ShowParameterPanelButton = false;
            this.crvServicios.ShowRefreshButton = false;
            this.crvServicios.ShowTextSearchButton = false;
            this.crvServicios.ShowZoomButton = false;
            this.crvServicios.Size = new System.Drawing.Size(752, 389);
            this.crvServicios.TabIndex = 12;
            this.crvServicios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pnlCmb
            // 
            this.pnlCmb.Controls.Add(this.cmbEstado);
            this.pnlCmb.Controls.Add(this.lblControl);
            this.pnlCmb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCmb.Location = new System.Drawing.Point(0, 25);
            this.pnlCmb.Name = "pnlCmb";
            this.pnlCmb.Size = new System.Drawing.Size(752, 38);
            this.pnlCmb.TabIndex = 13;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "De Baja"});
            this.cmbEstado.Location = new System.Drawing.Point(291, 6);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(285, 28);
            this.cmbEstado.TabIndex = 10;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(235, 12);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(50, 16);
            this.lblControl.TabIndex = 9;
            this.lblControl.Text = "Estado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscCerrar
            // 
            this.tscCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tscCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tscCerrar.Image")));
            this.tscCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscCerrar.Name = "tscCerrar";
            this.tscCerrar.Size = new System.Drawing.Size(23, 22);
            this.tscCerrar.Text = "toolStripButton1";
            // 
            // frmRepServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 452);
            this.Controls.Add(this.crvServicios);
            this.Controls.Add(this.pnlCmb);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRepServicios";
            this.Text = "frmRepServicios";
            this.pnlCmb.ResumeLayout(false);
            this.pnlCmb.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvServicios;
        private System.Windows.Forms.Panel pnlCmb;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tscCerrar;
    }
}