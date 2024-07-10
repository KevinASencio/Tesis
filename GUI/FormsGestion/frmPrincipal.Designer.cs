namespace GUI.FormsGestion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbRestaurar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.prbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenus = new System.Windows.Forms.Panel();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.btnCorte = new System.Windows.Forms.Button();
            this.btnServiciosMora = new System.Windows.Forms.Button();
            this.btnGenerarFac = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.btnCobro = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).BeginInit();
            this.PnlPrincipal.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTop.Controls.Add(this.ptbRestaurar);
            this.pnlTop.Controls.Add(this.ptbMaximizar);
            this.pnlTop.Controls.Add(this.ptbMinimizar);
            this.pnlTop.Controls.Add(this.prbCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1024, 48);
            this.pnlTop.TabIndex = 1;
            // 
            // ptbRestaurar
            // 
            this.ptbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("ptbRestaurar.Image")));
            this.ptbRestaurar.Location = new System.Drawing.Point(973, 1);
            this.ptbRestaurar.Name = "ptbRestaurar";
            this.ptbRestaurar.Size = new System.Drawing.Size(26, 27);
            this.ptbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRestaurar.TabIndex = 3;
            this.ptbRestaurar.TabStop = false;
            this.ptbRestaurar.Visible = false;
            this.ptbRestaurar.Click += new System.EventHandler(this.ptbRestaurar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(973, 1);
            this.ptbMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(26, 27);
            this.ptbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximizar.TabIndex = 2;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(950, 1);
            this.ptbMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(26, 27);
            this.ptbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimizar.TabIndex = 1;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // prbCerrar
            // 
            this.prbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("prbCerrar.Image")));
            this.prbCerrar.Location = new System.Drawing.Point(995, 1);
            this.prbCerrar.Name = "prbCerrar";
            this.prbCerrar.Size = new System.Drawing.Size(26, 27);
            this.prbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbCerrar.TabIndex = 0;
            this.prbCerrar.TabStop = false;
            this.prbCerrar.Click += new System.EventHandler(this.prbCerrar_Click);
            // 
            // pnlMenus
            // 
            this.pnlMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenus.Location = new System.Drawing.Point(0, 48);
            this.pnlMenus.Name = "pnlMenus";
            this.pnlMenus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlMenus.Size = new System.Drawing.Size(221, 720);
            this.pnlMenus.TabIndex = 2;
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.PnlPrincipal.Controls.Add(this.pnlBotones);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(221, 48);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(803, 720);
            this.PnlPrincipal.TabIndex = 6;
            this.PnlPrincipal.MouseHover += new System.EventHandler(this.PnlPrincipal_MouseHover);
            // 
            // btnCorte
            // 
            this.btnCorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCorte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnCorte.FlatAppearance.BorderSize = 0;
            this.btnCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorte.ForeColor = System.Drawing.Color.Black;
            this.btnCorte.Image = ((System.Drawing.Image)(resources.GetObject("btnCorte.Image")));
            this.btnCorte.Location = new System.Drawing.Point(40, 264);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(170, 150);
            this.btnCorte.TabIndex = 61;
            this.btnCorte.Text = "Corte de Mes";
            this.btnCorte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCorte.UseVisualStyleBackColor = true;
            // 
            // btnServiciosMora
            // 
            this.btnServiciosMora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnServiciosMora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiciosMora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnServiciosMora.FlatAppearance.BorderSize = 0;
            this.btnServiciosMora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnServiciosMora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiciosMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiciosMora.ForeColor = System.Drawing.Color.Black;
            this.btnServiciosMora.Image = ((System.Drawing.Image)(resources.GetObject("btnServiciosMora.Image")));
            this.btnServiciosMora.Location = new System.Drawing.Point(242, 47);
            this.btnServiciosMora.Name = "btnServiciosMora";
            this.btnServiciosMora.Size = new System.Drawing.Size(170, 150);
            this.btnServiciosMora.TabIndex = 61;
            this.btnServiciosMora.Text = "Servicios en Mora";
            this.btnServiciosMora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServiciosMora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnServiciosMora.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFac
            // 
            this.btnGenerarFac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarFac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnGenerarFac.FlatAppearance.BorderSize = 0;
            this.btnGenerarFac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnGenerarFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFac.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarFac.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarFac.Image")));
            this.btnGenerarFac.Location = new System.Drawing.Point(442, 47);
            this.btnGenerarFac.Name = "btnGenerarFac";
            this.btnGenerarFac.Size = new System.Drawing.Size(170, 150);
            this.btnGenerarFac.TabIndex = 61;
            this.btnGenerarFac.Text = "Generar e Imprimir Facturas";
            this.btnGenerarFac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarFac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerarFac.UseVisualStyleBackColor = true;
            this.btnGenerarFac.MouseEnter += new System.EventHandler(this.btnGenerarFac_MouseEnter);
            this.btnGenerarFac.MouseLeave += new System.EventHandler(this.btnGenerarFac_MouseLeave);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.Black;
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.Location = new System.Drawing.Point(574, 244);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(170, 150);
            this.btnImportar.TabIndex = 61;
            this.btnImportar.Text = "Importar Recibos de Caja de Credito";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransacciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransacciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnTransacciones.FlatAppearance.BorderSize = 0;
            this.btnTransacciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacciones.ForeColor = System.Drawing.Color.Black;
            this.btnTransacciones.Image = ((System.Drawing.Image)(resources.GetObject("btnTransacciones.Image")));
            this.btnTransacciones.Location = new System.Drawing.Point(398, 263);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(170, 150);
            this.btnTransacciones.TabIndex = 61;
            this.btnTransacciones.Text = "Registrar Contabilidad";
            this.btnTransacciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransacciones.UseVisualStyleBackColor = true;
            // 
            // btnCobro
            // 
            this.btnCobro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnCobro.FlatAppearance.BorderSize = 0;
            this.btnCobro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobro.ForeColor = System.Drawing.Color.Black;
            this.btnCobro.Image = ((System.Drawing.Image)(resources.GetObject("btnCobro.Image")));
            this.btnCobro.Location = new System.Drawing.Point(242, 264);
            this.btnCobro.Name = "btnCobro";
            this.btnCobro.Size = new System.Drawing.Size(170, 150);
            this.btnCobro.TabIndex = 61;
            this.btnCobro.Text = "Procesar Pago";
            this.btnCobro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCobro.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(40, 47);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(170, 150);
            this.btnClientes.TabIndex = 61;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnClientes);
            this.pnlBotones.Controls.Add(this.btnGenerarFac);
            this.pnlBotones.Controls.Add(this.btnCorte);
            this.pnlBotones.Controls.Add(this.btnImportar);
            this.pnlBotones.Controls.Add(this.btnReportes);
            this.pnlBotones.Controls.Add(this.btnTransacciones);
            this.pnlBotones.Controls.Add(this.btnCobro);
            this.pnlBotones.Controls.Add(this.btnServiciosMora);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(803, 720);
            this.pnlBotones.TabIndex = 68;
            // 
            // btnReportes
            // 
            this.btnReportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.Location = new System.Drawing.Point(608, 47);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(170, 150);
            this.btnReportes.TabIndex = 61;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.pnlMenus);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            this.ResizeBegin += new System.EventHandler(this.GestionClientes_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.GestionClientes_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.GestionClientes_SizeChanged);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).EndInit();
            this.PnlPrincipal.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox ptbRestaurar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox prbCerrar;
        private System.Windows.Forms.Panel pnlMenus;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnServiciosMora;
        private System.Windows.Forms.Button btnGenerarFac;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.Button btnCobro;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnReportes;
    }
}