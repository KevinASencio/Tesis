namespace GUI.FormsGestion
{
    partial class frmGestionConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionConsumo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbColonia = new System.Windows.Forms.ComboBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCuota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripCerrar.Click += new System.EventHandler(this.toolStripCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbId);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(250, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 44);
            this.panel1.TabIndex = 6;
            // 
            // txbId
            // 
            this.txbId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(0, 20);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(422, 24);
            this.txbId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(84, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id Servicio: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbColonia);
            this.panel2.Controls.Add(this.lblColonia);
            this.panel2.Location = new System.Drawing.Point(250, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 44);
            this.panel2.TabIndex = 7;
            // 
            // cmbColonia
            // 
            this.cmbColonia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColonia.FormattingEnabled = true;
            this.cmbColonia.Location = new System.Drawing.Point(0, 18);
            this.cmbColonia.Name = "cmbColonia";
            this.cmbColonia.Size = new System.Drawing.Size(422, 26);
            this.cmbColonia.TabIndex = 1;
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.Location = new System.Drawing.Point(3, 0);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(67, 18);
            this.lblColonia.TabIndex = 0;
            this.lblColonia.Text = "Colonia: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbCuota);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(247, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 44);
            this.panel3.TabIndex = 8;
            // 
            // cmbCuota
            // 
            this.cmbCuota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCuota.FormattingEnabled = true;
            this.cmbCuota.Location = new System.Drawing.Point(0, 18);
            this.cmbCuota.Name = "cmbCuota";
            this.cmbCuota.Size = new System.Drawing.Size(422, 26);
            this.cmbCuota.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuota: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbEstado);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(247, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 44);
            this.panel4.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(0, 18);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(422, 26);
            this.cmbEstado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbComentario);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(247, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(422, 44);
            this.panel5.TabIndex = 9;
            // 
            // txbComentario
            // 
            this.txbComentario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbComentario.Enabled = false;
            this.txbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComentario.Location = new System.Drawing.Point(0, 20);
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(422, 24);
            this.txbComentario.TabIndex = 1;
            this.txbComentario.Text = "Comentario}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Comentario: ";
            // 
            // frmGestionConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionConsumo";
            this.Text = "frmGestionConsumo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbId;
        public System.Windows.Forms.ComboBox cmbColonia;
        public System.Windows.Forms.ComboBox cmbCuota;
        public System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.TextBox txbComentario;
    }
}