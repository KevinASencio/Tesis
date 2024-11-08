namespace GUI.Reportes
{
    partial class frmRepResumenCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepResumenCaja));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscCerrar = new System.Windows.Forms.ToolStripButton();
            this.crvResumenCaja = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlCmb = new System.Windows.Forms.Panel();
            this.cmbControl = new System.Windows.Forms.ComboBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.pnlCmb.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
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
            this.tscCerrar.Click += new System.EventHandler(this.tscCerrar_Click);
            // 
            // crvResumenCaja
            // 
            this.crvResumenCaja.ActiveViewIndex = -1;
            this.crvResumenCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResumenCaja.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResumenCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResumenCaja.EnableDrillDown = false;
            this.crvResumenCaja.EnableToolTips = false;
            this.crvResumenCaja.Location = new System.Drawing.Point(0, 0);
            this.crvResumenCaja.Name = "crvResumenCaja";
            this.crvResumenCaja.ShowCloseButton = false;
            this.crvResumenCaja.ShowCopyButton = false;
            this.crvResumenCaja.ShowGroupTreeButton = false;
            this.crvResumenCaja.ShowLogo = false;
            this.crvResumenCaja.ShowParameterPanelButton = false;
            this.crvResumenCaja.ShowRefreshButton = false;
            this.crvResumenCaja.ShowTextSearchButton = false;
            this.crvResumenCaja.ShowZoomButton = false;
            this.crvResumenCaja.Size = new System.Drawing.Size(800, 450);
            this.crvResumenCaja.TabIndex = 6;
            this.crvResumenCaja.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pnlCmb
            // 
            this.pnlCmb.Controls.Add(this.cmbControl);
            this.pnlCmb.Controls.Add(this.lblControl);
            this.pnlCmb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCmb.Location = new System.Drawing.Point(0, 25);
            this.pnlCmb.Name = "pnlCmb";
            this.pnlCmb.Size = new System.Drawing.Size(800, 38);
            this.pnlCmb.TabIndex = 7;
            // 
            // cmbControl
            // 
            this.cmbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbControl.FormattingEnabled = true;
            this.cmbControl.Location = new System.Drawing.Point(291, 6);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(285, 28);
            this.cmbControl.TabIndex = 10;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(193, 11);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(92, 16);
            this.lblControl.TabIndex = 9;
            this.lblControl.Text = "Elija el Control";
            // 
            // frmRepResumenCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvResumenCaja);
            this.Controls.Add(this.pnlCmb);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRepResumenCaja";
            this.Text = "RepResumenCaja";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlCmb.ResumeLayout(false);
            this.pnlCmb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tscCerrar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResumenCaja;
        private System.Windows.Forms.Panel pnlCmb;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.ComboBox cmbControl;
    }
}