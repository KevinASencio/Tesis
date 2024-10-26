namespace GUI.FormsProcesos
{
    partial class frmMovimientos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientos));
            this.errorNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.lblId = new System.Windows.Forms.Label();
            this.txbFactura = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbConcepto = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbLugarPago = new System.Windows.Forms.ComboBox();
            this.lblLugarPago = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbEmisor = new System.Windows.Forms.TextBox();
            this.lblEmisor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorNotificador)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlBoton.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorNotificador
            // 
            this.errorNotificador.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 25);
            this.toolStrip1.TabIndex = 9;
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
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(86, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "No. Factura";
            // 
            // txbFactura
            // 
            this.txbFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFactura.Location = new System.Drawing.Point(0, 20);
            this.txbFactura.Name = "txbFactura";
            this.txbFactura.Size = new System.Drawing.Size(419, 24);
            this.txbFactura.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbFactura);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(198, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 44);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Location = new System.Drawing.Point(198, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 44);
            this.panel2.TabIndex = 9;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Ingreso",
            "Egreso"});
            this.cmbTipo.Location = new System.Drawing.Point(0, 17);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(419, 26);
            this.cmbTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(3, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 18);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.txbConcepto);
            this.panel3.Controls.Add(this.lblConcepto);
            this.panel3.Location = new System.Drawing.Point(198, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 50);
            this.panel3.TabIndex = 10;
            // 
            // txbConcepto
            // 
            this.txbConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConcepto.Location = new System.Drawing.Point(0, 21);
            this.txbConcepto.Multiline = true;
            this.txbConcepto.Name = "txbConcepto";
            this.txbConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbConcepto.Size = new System.Drawing.Size(419, 26);
            this.txbConcepto.TabIndex = 1;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(3, 0);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(77, 18);
            this.lblConcepto.TabIndex = 0;
            this.lblConcepto.Text = "Concepto:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbMonto);
            this.panel4.Controls.Add(this.lblMonto);
            this.panel4.Location = new System.Drawing.Point(198, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 44);
            this.panel4.TabIndex = 11;
            // 
            // txbMonto
            // 
            this.txbMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMonto.Location = new System.Drawing.Point(0, 20);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(419, 24);
            this.txbMonto.TabIndex = 1;
            this.txbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(3, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(59, 18);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbLugarPago);
            this.panel5.Controls.Add(this.lblLugarPago);
            this.panel5.Location = new System.Drawing.Point(198, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(443, 44);
            this.panel5.TabIndex = 10;
            // 
            // cmbLugarPago
            // 
            this.cmbLugarPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLugarPago.FormattingEnabled = true;
            this.cmbLugarPago.Items.AddRange(new object[] {
            "Caja Local",
            "Caja de Credito"});
            this.cmbLugarPago.Location = new System.Drawing.Point(0, 17);
            this.cmbLugarPago.Name = "cmbLugarPago";
            this.cmbLugarPago.Size = new System.Drawing.Size(419, 26);
            this.cmbLugarPago.TabIndex = 1;
            // 
            // lblLugarPago
            // 
            this.lblLugarPago.AutoSize = true;
            this.lblLugarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarPago.Location = new System.Drawing.Point(3, 0);
            this.lblLugarPago.Name = "lblLugarPago";
            this.lblLugarPago.Size = new System.Drawing.Size(49, 18);
            this.lblLugarPago.TabIndex = 0;
            this.lblLugarPago.Text = "Lugar ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpFecha);
            this.panel6.Controls.Add(this.lblFecha);
            this.panel6.Location = new System.Drawing.Point(198, 134);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(443, 44);
            this.panel6.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(0, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(419, 24);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(3, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 18);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "No. Factura";
            // 
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnCancelar);
            this.pnlBoton.Controls.Add(this.btnAgregar);
            this.pnlBoton.Location = new System.Drawing.Point(290, 570);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Size = new System.Drawing.Size(266, 55);
            this.pnlBoton.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(142, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 46);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 46);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbEmisor);
            this.panel7.Controls.Add(this.lblEmisor);
            this.panel7.Location = new System.Drawing.Point(198, 488);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(443, 44);
            this.panel7.TabIndex = 14;
            // 
            // txbEmisor
            // 
            this.txbEmisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmisor.Location = new System.Drawing.Point(0, 20);
            this.txbEmisor.Name = "txbEmisor";
            this.txbEmisor.Size = new System.Drawing.Size(419, 24);
            this.txbEmisor.TabIndex = 1;
            // 
            // lblEmisor
            // 
            this.lblEmisor.AutoSize = true;
            this.lblEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmisor.Location = new System.Drawing.Point(3, 0);
            this.lblEmisor.Name = "lblEmisor";
            this.lblEmisor.Size = new System.Drawing.Size(64, 18);
            this.lblEmisor.TabIndex = 0;
            this.lblEmisor.Text = "Emisor: ";
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 766);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnlBoton);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovimientos";
            this.Text = "frmMovimientos";
            this.Load += new System.EventHandler(this.frmMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNotificador)).EndInit();
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
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlBoton.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorNotificador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txbFactura;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbLugarPago;
        private System.Windows.Forms.Label lblLugarPago;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txbConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox txbEmisor;
        private System.Windows.Forms.Label lblEmisor;
    }
}