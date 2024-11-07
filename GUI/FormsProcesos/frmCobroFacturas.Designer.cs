namespace GUI.FormsProcesos
{
    partial class frmCobroFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobroFacturas));
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txbFactura = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMesesPen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbTotalPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbDescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.printreport = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFactura.Location = new System.Drawing.Point(3, 3);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(96, 20);
            this.lblIdFactura.TabIndex = 0;
            this.lblIdFactura.Text = "No.  Factura";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.txbFactura);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblIdFactura);
            this.panel1.Location = new System.Drawing.Point(177, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(599, 30);
            this.panel1.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(553, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(41, 24);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txbFactura
            // 
            this.txbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbFactura.Location = new System.Drawing.Point(99, 3);
            this.txbFactura.Margin = new System.Windows.Forms.Padding(5);
            this.txbFactura.Name = "txbFactura";
            this.txbFactura.Size = new System.Drawing.Size(363, 24);
            this.txbFactura.TabIndex = 3;
            this.txbFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(466, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 24);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(177, 101);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(596, 27);
            this.panel2.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(69, 3);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 20);
            this.lblCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMonto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(177, 158);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(596, 27);
            this.panel3.TabIndex = 3;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(65, 3);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(0, 20);
            this.lblMonto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monto: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMora);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(177, 221);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(596, 27);
            this.panel4.TabIndex = 3;
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora.Location = new System.Drawing.Point(68, 3);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(0, 20);
            this.lblMora.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mora:    ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblMes);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(177, 300);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(596, 27);
            this.panel5.TabIndex = 3;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(127, 3);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(0, 20);
            this.lblMes.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mes Facturado: ";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.lblMesesPen);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(177, 370);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(596, 27);
            this.panel6.TabIndex = 3;
            // 
            // lblMesesPen
            // 
            this.lblMesesPen.AutoEllipsis = true;
            this.lblMesesPen.AutoSize = true;
            this.lblMesesPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesPen.Location = new System.Drawing.Point(151, 3);
            this.lblMesesPen.Name = "lblMesesPen";
            this.lblMesesPen.Size = new System.Drawing.Size(0, 20);
            this.lblMesesPen.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Meses Pendientes: ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbTotalPagar);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(174, 423);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(599, 30);
            this.panel7.TabIndex = 4;
            // 
            // txbTotalPagar
            // 
            this.txbTotalPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbTotalPagar.Location = new System.Drawing.Point(113, 3);
            this.txbTotalPagar.Margin = new System.Windows.Forms.Padding(5);
            this.txbTotalPagar.Name = "txbTotalPagar";
            this.txbTotalPagar.Size = new System.Drawing.Size(483, 24);
            this.txbTotalPagar.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total a pagar: ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbDescuento);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(174, 480);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(599, 30);
            this.panel8.TabIndex = 5;
            // 
            // txbDescuento
            // 
            this.txbDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txbDescuento.Location = new System.Drawing.Point(114, 3);
            this.txbDescuento.Margin = new System.Windows.Forms.Padding(5);
            this.txbDescuento.Name = "txbDescuento";
            this.txbDescuento.Size = new System.Drawing.Size(482, 24);
            this.txbDescuento.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Descuento:     ";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProcesar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(0, 0);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(129, 37);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnCancelar);
            this.panel9.Controls.Add(this.btnProcesar);
            this.panel9.Location = new System.Drawing.Point(308, 571);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(322, 37);
            this.panel9.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(188, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 25);
            this.toolStrip1.TabIndex = 8;
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
            // printreport
            // 
            this.printreport.UseEXDialog = true;
            // 
            // frmCobroFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 550);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCobroFacturas";
            this.Text = "frmCobroFacturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCobroFacturas_Load);
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripCerrar;
        public System.Windows.Forms.TextBox txbFactura;
        public System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Label lblMonto;
        public System.Windows.Forms.Label lblMora;
        public System.Windows.Forms.Label lblMes;
        public System.Windows.Forms.TextBox txbTotalPagar;
        public System.Windows.Forms.TextBox txbDescuento;
        public System.Windows.Forms.Label lblMesesPen;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printreport;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}