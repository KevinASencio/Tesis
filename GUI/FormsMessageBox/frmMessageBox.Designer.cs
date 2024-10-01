namespace GUI.FormsMessageBox
{
    partial class frmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.prbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenuInicio = new System.Windows.Forms.Panel();
            this.btnParametro = new System.Windows.Forms.Button();
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).BeginInit();
            this.pnlMenuInicio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Controls.Add(this.prbCerrar);
            this.pnlTop.Controls.Add(this.pnlMenuInicio);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(310, 30);
            this.pnlTop.TabIndex = 2;
            // 
            // prbCerrar
            // 
            this.prbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("prbCerrar.Image")));
            this.prbCerrar.Location = new System.Drawing.Point(281, 1);
            this.prbCerrar.Name = "prbCerrar";
            this.prbCerrar.Size = new System.Drawing.Size(26, 27);
            this.prbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbCerrar.TabIndex = 0;
            this.prbCerrar.TabStop = false;
            this.prbCerrar.Click += new System.EventHandler(this.prbCerrar_Click);
            // 
            // pnlMenuInicio
            // 
            this.pnlMenuInicio.Controls.Add(this.btnParametro);
            this.pnlMenuInicio.Controls.Add(this.btnCuotas);
            this.pnlMenuInicio.Controls.Add(this.btnUsuarios);
            this.pnlMenuInicio.Controls.Add(this.btnFacturas);
            this.pnlMenuInicio.Enabled = false;
            this.pnlMenuInicio.Location = new System.Drawing.Point(153, 48);
            this.pnlMenuInicio.Name = "pnlMenuInicio";
            this.pnlMenuInicio.Size = new System.Drawing.Size(221, 458);
            this.pnlMenuInicio.TabIndex = 3;
            // 
            // btnParametro
            // 
            this.btnParametro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParametro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametro.FlatAppearance.BorderSize = 0;
            this.btnParametro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametro.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametro.ForeColor = System.Drawing.Color.White;
            this.btnParametro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametro.Location = new System.Drawing.Point(2, 378);
            this.btnParametro.Name = "btnParametro";
            this.btnParametro.Size = new System.Drawing.Size(219, 51);
            this.btnParametro.TabIndex = 5;
            this.btnParametro.Text = "Parametros";
            this.btnParametro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParametro.UseVisualStyleBackColor = true;
            // 
            // btnCuotas
            // 
            this.btnCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuotas.FlatAppearance.BorderSize = 0;
            this.btnCuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuotas.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuotas.ForeColor = System.Drawing.Color.White;
            this.btnCuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuotas.Location = new System.Drawing.Point(1, 321);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(219, 51);
            this.btnCuotas.TabIndex = 4;
            this.btnCuotas.Text = "Gestion Cuotas";
            this.btnCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuotas.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(1, 264);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(219, 51);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Gestion Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnFacturas
            // 
            this.btnFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(1, 204);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(219, 51);
            this.btnFacturas.TabIndex = 2;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturas.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(6, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(53, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(130, 40);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 16);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label2";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(122, 121);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(67, 29);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 79);
            this.panel1.TabIndex = 5;
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 162);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageBox";
            this.Text = "frmMessageBox";
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).EndInit();
            this.pnlMenuInicio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox prbCerrar;
        public System.Windows.Forms.Panel pnlMenuInicio;
        private System.Windows.Forms.Button btnParametro;
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
    }
}