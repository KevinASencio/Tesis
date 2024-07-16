namespace GUI.FormsGestion
{
    partial class frmVistaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaUsuarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txbFiltro,
            this.toolStripCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // txbFiltro
            // 
            this.txbFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripCerrar
            // 
            this.toolStripCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCerrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCerrar.Image")));
            this.toolStripCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCerrar.Name = "toolStripCerrar";
            this.toolStripCerrar.Size = new System.Drawing.Size(23, 22);
            this.toolStripCerrar.Text = "toolStripButton1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(133, 17);
            this.lblRegistro.Text = "0 Registros encontrados";
            // 
            // frmVistaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVistaUsuarios";
            this.Text = "frmVistaUsuarios";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripTextBox txbFiltro;
        private System.Windows.Forms.ToolStripButton toolStripCerrar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistro;
    }
}