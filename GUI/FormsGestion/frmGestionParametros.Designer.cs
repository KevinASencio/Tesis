namespace GUI.FormsGestion
{
    partial class frmGestionParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionParametros));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.prbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMaxCuotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMoraAcometida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMonto = new System.Windows.Forms.Panel();
            this.txbMoraConsumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlBoton.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMonto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.prbCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(387, 25);
            this.pnlTop.TabIndex = 24;
            // 
            // prbCerrar
            // 
            this.prbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("prbCerrar.Image")));
            this.prbCerrar.Location = new System.Drawing.Point(364, -2);
            this.prbCerrar.Name = "prbCerrar";
            this.prbCerrar.Size = new System.Drawing.Size(25, 25);
            this.prbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbCerrar.TabIndex = 0;
            this.prbCerrar.TabStop = false;
            this.prbCerrar.Click += new System.EventHandler(this.prbCerrar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlBoton);
            this.pnlPrincipal.Controls.Add(this.panel3);
            this.pnlPrincipal.Controls.Add(this.panel2);
            this.pnlPrincipal.Controls.Add(this.pnlMonto);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(387, 364);
            this.pnlPrincipal.TabIndex = 25;
            // 
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnCancelar);
            this.pnlBoton.Controls.Add(this.btnAgregar);
            this.pnlBoton.Location = new System.Drawing.Point(65, 284);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Size = new System.Drawing.Size(266, 55);
            this.pnlBoton.TabIndex = 20;
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txbMaxCuotas);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(41, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 50);
            this.panel3.TabIndex = 19;
            // 
            // txbMaxCuotas
            // 
            this.txbMaxCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMaxCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaxCuotas.Location = new System.Drawing.Point(0, 20);
            this.txbMaxCuotas.Name = "txbMaxCuotas";
            this.txbMaxCuotas.Size = new System.Drawing.Size(306, 24);
            this.txbMaxCuotas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximas Cuotas Pendientes:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txbMoraAcometida);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(41, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 50);
            this.panel2.TabIndex = 18;
            // 
            // txbMoraAcometida
            // 
            this.txbMoraAcometida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMoraAcometida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoraAcometida.Location = new System.Drawing.Point(0, 20);
            this.txbMoraAcometida.Name = "txbMoraAcometida";
            this.txbMoraAcometida.Size = new System.Drawing.Size(306, 24);
            this.txbMoraAcometida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mora Acometida:";
            // 
            // pnlMonto
            // 
            this.pnlMonto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMonto.Controls.Add(this.txbMoraConsumo);
            this.pnlMonto.Controls.Add(this.label4);
            this.pnlMonto.Location = new System.Drawing.Point(41, 23);
            this.pnlMonto.Name = "pnlMonto";
            this.pnlMonto.Size = new System.Drawing.Size(327, 50);
            this.pnlMonto.TabIndex = 17;
            // 
            // txbMoraConsumo
            // 
            this.txbMoraConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMoraConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoraConsumo.Location = new System.Drawing.Point(0, 20);
            this.txbMoraConsumo.Name = "txbMoraConsumo";
            this.txbMoraConsumo.Size = new System.Drawing.Size(306, 24);
            this.txbMoraConsumo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mora Consumo: ";
            // 
            // ErrorNotificador
            // 
            this.ErrorNotificador.ContainerControl = this;
            // 
            // frmGestionParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 389);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionParametros";
            this.Text = "frmGestionParametros";
            this.Load += new System.EventHandler(this.frmGestionParametros_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlBoton.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMonto.ResumeLayout(false);
            this.pnlMonto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox prbCerrar;
        private System.Windows.Forms.Panel pnlMonto;
        public System.Windows.Forms.TextBox txbMoraConsumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txbMaxCuotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txbMoraAcometida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider ErrorNotificador;
        public System.Windows.Forms.Panel pnlPrincipal;
    }
}