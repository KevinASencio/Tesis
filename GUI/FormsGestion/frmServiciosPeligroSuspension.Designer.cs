namespace GUI.FormsGestion
{
    partial class frmServiciosPeligroSuspension
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiciosPeligroSuspension));
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.tsbCobrar = new System.Windows.Forms.ToolStripButton();
            this.idfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cont_pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fachavencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfactura,
            this.idcontrol,
            this.cliente,
            this.colonia,
            this.idservicio,
            this.cont_pendiente,
            this.saldo,
            this.mora,
            this.mes,
            this.fachavencimiento});
            this.dtgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFacturas.EnableHeadersVisualStyles = false;
            this.dtgvFacturas.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvFacturas.Location = new System.Drawing.Point(0, 25);
            this.dtgvFacturas.MultiSelect = false;
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvFacturas.RowHeadersVisible = false;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFacturas.ShowCellToolTips = false;
            this.dtgvFacturas.Size = new System.Drawing.Size(800, 425);
            this.dtgvFacturas.TabIndex = 12;
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 13;
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
            this.toolStripCerrar.Click += new System.EventHandler(this.toolStripCerrar_Click);
            // 
            // tsbCobrar
            // 
            this.tsbCobrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCobrar.Image")));
            this.tsbCobrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCobrar.Name = "tsbCobrar";
            this.tsbCobrar.Size = new System.Drawing.Size(63, 22);
            this.tsbCobrar.Text = "Cobrar";
            // 
            // idfactura
            // 
            this.idfactura.DataPropertyName = "idfactura";
            this.idfactura.HeaderText = "No Factura";
            this.idfactura.Name = "idfactura";
            this.idfactura.ReadOnly = true;
            // 
            // idcontrol
            // 
            this.idcontrol.DataPropertyName = "idcontrol";
            this.idcontrol.HeaderText = "idcontrol";
            this.idcontrol.Name = "idcontrol";
            this.idcontrol.ReadOnly = true;
            this.idcontrol.Visible = false;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // colonia
            // 
            this.colonia.DataPropertyName = "colonia";
            this.colonia.HeaderText = "Colonia";
            this.colonia.Name = "colonia";
            this.colonia.ReadOnly = true;
            // 
            // idservicio
            // 
            this.idservicio.DataPropertyName = "idservicio";
            this.idservicio.HeaderText = "idservicio";
            this.idservicio.Name = "idservicio";
            this.idservicio.ReadOnly = true;
            this.idservicio.Visible = false;
            // 
            // cont_pendiente
            // 
            this.cont_pendiente.DataPropertyName = "cont_pendiente";
            this.cont_pendiente.HeaderText = "Cuotas Pendientes";
            this.cont_pendiente.Name = "cont_pendiente";
            this.cont_pendiente.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // mora
            // 
            this.mora.DataPropertyName = "mora";
            this.mora.HeaderText = "Mora";
            this.mora.Name = "mora";
            this.mora.ReadOnly = true;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // fachavencimiento
            // 
            this.fachavencimiento.DataPropertyName = "fecha_vencimiento";
            this.fachavencimiento.HeaderText = "Fecha Vencimiento";
            this.fachavencimiento.Name = "fachavencimiento";
            this.fachavencimiento.ReadOnly = true;
            // 
            // frmServiciosPeligroSuspension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvFacturas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServiciosPeligroSuspension";
            this.Text = "frmServiciosPeligroSuspension";
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
        private System.Windows.Forms.ToolStripButton tsbCobrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cont_pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mora;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn fachavencimiento;
    }
}