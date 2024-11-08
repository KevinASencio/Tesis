namespace GUI.FormsGestion
{
    partial class frmVerFacturasCli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerFacturasCli));
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.idfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fachavencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cont_pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbCobrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.AllowUserToAddRows = false;
            this.dtgvFacturas.AllowUserToDeleteRows = false;
            this.dtgvFacturas.AllowUserToResizeColumns = false;
            this.dtgvFacturas.AllowUserToResizeRows = false;
            this.dtgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfactura,
            this.saldo,
            this.mora,
            this.mes,
            this.fachavencimiento,
            this.estado,
            this.estado_pago,
            this.cont_pendiente,
            this.comentario});
            this.dtgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFacturas.EnableHeadersVisualStyles = false;
            this.dtgvFacturas.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvFacturas.Location = new System.Drawing.Point(0, 25);
            this.dtgvFacturas.MultiSelect = false;
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvFacturas.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFacturas.ShowCellToolTips = false;
            this.dtgvFacturas.Size = new System.Drawing.Size(881, 478);
            this.dtgvFacturas.TabIndex = 10;
            // 
            // idfactura
            // 
            this.idfactura.DataPropertyName = "idfactura";
            this.idfactura.HeaderText = "No Factura";
            this.idfactura.Name = "idfactura";
            this.idfactura.ReadOnly = true;
            this.idfactura.Width = 87;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Width = 67;
            // 
            // mora
            // 
            this.mora.DataPropertyName = "mora";
            this.mora.HeaderText = "Mora";
            this.mora.Name = "mora";
            this.mora.ReadOnly = true;
            this.mora.Width = 64;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 60;
            // 
            // fachavencimiento
            // 
            this.fachavencimiento.DataPropertyName = "fecha_vencimiento";
            this.fachavencimiento.HeaderText = "Fecha Vencimiento";
            this.fachavencimiento.Name = "fachavencimiento";
            this.fachavencimiento.ReadOnly = true;
            this.fachavencimiento.Width = 121;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 73;
            // 
            // estado_pago
            // 
            this.estado_pago.DataPropertyName = "estado_pago";
            this.estado_pago.HeaderText = "Estado Pago";
            this.estado_pago.Name = "estado_pago";
            this.estado_pago.ReadOnly = true;
            this.estado_pago.Width = 94;
            // 
            // cont_pendiente
            // 
            this.cont_pendiente.DataPropertyName = "cont_pendiente";
            this.cont_pendiente.HeaderText = "Cuotas Pendientes";
            this.cont_pendiente.Name = "cont_pendiente";
            this.cont_pendiente.ReadOnly = true;
            this.cont_pendiente.Width = 119;
            // 
            // comentario
            // 
            this.comentario.DataPropertyName = "comentario";
            this.comentario.HeaderText = "Comentario";
            this.comentario.Name = "comentario";
            this.comentario.ReadOnly = true;
            this.comentario.Width = 93;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txbFiltro,
            this.toolStripCerrar,
            this.tsbCobrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 25);
            this.toolStrip1.TabIndex = 11;
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
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
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
            // tsbCobrar
            // 
            this.tsbCobrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCobrar.Image")));
            this.tsbCobrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCobrar.Name = "tsbCobrar";
            this.tsbCobrar.Size = new System.Drawing.Size(63, 22);
            this.tsbCobrar.Text = "Cobrar";
            this.tsbCobrar.Click += new System.EventHandler(this.tsbCobrar_Click);
            // 
            // frmVerFacturasCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 503);
            this.Controls.Add(this.dtgvFacturas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerFacturasCli";
            this.Text = "frmVerFacturasCli";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtgvFacturas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripTextBox txbFiltro;
        private System.Windows.Forms.ToolStripButton toolStripCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mora;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn fachavencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cont_pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.ToolStripButton tsbCobrar;
    }
}