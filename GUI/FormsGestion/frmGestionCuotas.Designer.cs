namespace GUI.FormsGestion
{
    partial class frmGestionCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionCuotas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.splContenedor = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgtvConsumo = new System.Windows.Forms.DataGridView();
            this.idcuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuararCon = new System.Windows.Forms.Button();
            this.txbCuotaCon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIdCon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgtvAcometida = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardarAco = new System.Windows.Forms.Button();
            this.txbCuotaAco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIdAco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splContenedor)).BeginInit();
            this.splContenedor.Panel1.SuspendLayout();
            this.splContenedor.Panel2.SuspendLayout();
            this.splContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvConsumo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvAcometida)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.splContenedor);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 25);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 575);
            this.pnlContenedor.TabIndex = 6;
            // 
            // splContenedor
            // 
            this.splContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splContenedor.Location = new System.Drawing.Point(0, 0);
            this.splContenedor.Name = "splContenedor";
            // 
            // splContenedor.Panel1
            // 
            this.splContenedor.Panel1.Controls.Add(this.panel2);
            this.splContenedor.Panel1.Controls.Add(this.panel3);
            // 
            // splContenedor.Panel2
            // 
            this.splContenedor.Panel2.Controls.Add(this.panel8);
            this.splContenedor.Panel2.Controls.Add(this.panel4);
            this.splContenedor.Size = new System.Drawing.Size(800, 575);
            this.splContenedor.SplitterDistance = 392;
            this.splContenedor.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgtvConsumo);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(33, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 254);
            this.panel2.TabIndex = 3;
            // 
            // dgtvConsumo
            // 
            this.dgtvConsumo.AllowUserToAddRows = false;
            this.dgtvConsumo.AllowUserToDeleteRows = false;
            this.dgtvConsumo.AllowUserToResizeColumns = false;
            this.dgtvConsumo.AllowUserToResizeRows = false;
            this.dgtvConsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtvConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgtvConsumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtvConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvConsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcuota,
            this.monto});
            this.dgtvConsumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtvConsumo.EnableHeadersVisualStyles = false;
            this.dgtvConsumo.GridColor = System.Drawing.SystemColors.Control;
            this.dgtvConsumo.Location = new System.Drawing.Point(0, 49);
            this.dgtvConsumo.MultiSelect = false;
            this.dgtvConsumo.Name = "dgtvConsumo";
            this.dgtvConsumo.ReadOnly = true;
            this.dgtvConsumo.RowHeadersVisible = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtvConsumo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtvConsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtvConsumo.Size = new System.Drawing.Size(322, 205);
            this.dgtvConsumo.TabIndex = 10;
            this.dgtvConsumo.DoubleClick += new System.EventHandler(this.dgtvConsumo_DoubleClick);
            // 
            // idcuota
            // 
            this.idcuota.DataPropertyName = "idcuotaconsumo";
            this.idcuota.HeaderText = "Id Cuota";
            this.idcuota.Name = "idcuota";
            this.idcuota.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Cuota";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 49);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuotas Consumo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGuararCon);
            this.panel3.Controls.Add(this.txbCuotaCon);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbIdCon);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(33, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 254);
            this.panel3.TabIndex = 11;
            // 
            // btnGuararCon
            // 
            this.btnGuararCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuararCon.FlatAppearance.BorderSize = 0;
            this.btnGuararCon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnGuararCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuararCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuararCon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuararCon.Location = new System.Drawing.Point(106, 126);
            this.btnGuararCon.Name = "btnGuararCon";
            this.btnGuararCon.Size = new System.Drawing.Size(115, 32);
            this.btnGuararCon.TabIndex = 4;
            this.btnGuararCon.Text = "Guardar";
            this.btnGuararCon.UseVisualStyleBackColor = false;
            this.btnGuararCon.Click += new System.EventHandler(this.btnGuararCon_Click);
            // 
            // txbCuotaCon
            // 
            this.txbCuotaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCuotaCon.Location = new System.Drawing.Point(96, 84);
            this.txbCuotaCon.Name = "txbCuotaCon";
            this.txbCuotaCon.Size = new System.Drawing.Size(185, 24);
            this.txbCuotaCon.TabIndex = 3;
            this.txbCuotaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCuotaCon_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuota";
            // 
            // txbIdCon
            // 
            this.txbIdCon.Enabled = false;
            this.txbIdCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdCon.Location = new System.Drawing.Point(96, 32);
            this.txbIdCon.Name = "txbIdCon";
            this.txbIdCon.Size = new System.Drawing.Size(185, 24);
            this.txbIdCon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Cuota";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgtvAcometida);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Location = new System.Drawing.Point(41, 24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(322, 254);
            this.panel8.TabIndex = 13;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // dgtvAcometida
            // 
            this.dgtvAcometida.AllowUserToAddRows = false;
            this.dgtvAcometida.AllowUserToDeleteRows = false;
            this.dgtvAcometida.AllowUserToResizeColumns = false;
            this.dgtvAcometida.AllowUserToResizeRows = false;
            this.dgtvAcometida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtvAcometida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgtvAcometida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtvAcometida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgtvAcometida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvAcometida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgtvAcometida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtvAcometida.EnableHeadersVisualStyles = false;
            this.dgtvAcometida.GridColor = System.Drawing.SystemColors.Control;
            this.dgtvAcometida.Location = new System.Drawing.Point(0, 49);
            this.dgtvAcometida.MultiSelect = false;
            this.dgtvAcometida.Name = "dgtvAcometida";
            this.dgtvAcometida.ReadOnly = true;
            this.dgtvAcometida.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtvAcometida.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgtvAcometida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtvAcometida.Size = new System.Drawing.Size(322, 205);
            this.dgtvAcometida.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idcuotaacometida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id Cuota";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cuota";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(322, 49);
            this.panel6.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cuotas Acometida";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGuardarAco);
            this.panel4.Controls.Add(this.txbCuotaAco);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txbIdAco);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(41, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 254);
            this.panel4.TabIndex = 14;
            // 
            // btnGuardarAco
            // 
            this.btnGuardarAco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardarAco.FlatAppearance.BorderSize = 0;
            this.btnGuardarAco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnGuardarAco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAco.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardarAco.Location = new System.Drawing.Point(112, 126);
            this.btnGuardarAco.Name = "btnGuardarAco";
            this.btnGuardarAco.Size = new System.Drawing.Size(115, 32);
            this.btnGuardarAco.TabIndex = 4;
            this.btnGuardarAco.Text = "Guardar";
            this.btnGuardarAco.UseVisualStyleBackColor = false;
            this.btnGuardarAco.Click += new System.EventHandler(this.btnGuardarAco_Click);
            // 
            // txbCuotaAco
            // 
            this.txbCuotaAco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCuotaAco.Location = new System.Drawing.Point(89, 84);
            this.txbCuotaAco.Name = "txbCuotaAco";
            this.txbCuotaAco.Size = new System.Drawing.Size(185, 24);
            this.txbCuotaAco.TabIndex = 3;
            this.txbCuotaAco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCuotaAco_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cuota";
            // 
            // txbIdAco
            // 
            this.txbIdAco.Enabled = false;
            this.txbIdAco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdAco.Location = new System.Drawing.Point(89, 32);
            this.txbIdAco.Name = "txbIdAco";
            this.txbIdAco.Size = new System.Drawing.Size(185, 24);
            this.txbIdAco.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id Cuota";
            // 
            // ErrorNotificador
            // 
            this.ErrorNotificador.ContainerControl = this;
            // 
            // frmGestionCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionCuotas";
            this.Text = "frmGestionCuotas";
            this.Load += new System.EventHandler(this.frmGestionCuotas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.splContenedor.Panel1.ResumeLayout(false);
            this.splContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splContenedor)).EndInit();
            this.splContenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvConsumo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvAcometida)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripCerrar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.SplitContainer splContenedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbCuotaCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIdCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuararCon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGuardarAco;
        private System.Windows.Forms.TextBox txbCuotaAco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbIdAco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgtvAcometida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgtvConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider ErrorNotificador;
    }
}