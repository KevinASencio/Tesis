namespace GUI.FormsGestion
{
    partial class frmGestionAcometida
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
            this.pnlID = new System.Windows.Forms.Panel();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlCuotas = new System.Windows.Forms.Panel();
            this.cmbCuota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlColonias = new System.Windows.Forms.Panel();
            this.cmbColonia = new System.Windows.Forms.ComboBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlComentario = new System.Windows.Forms.Panel();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlMonto = new System.Windows.Forms.Panel();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSaldo = new System.Windows.Forms.Panel();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCuotasPagadas = new System.Windows.Forms.Panel();
            this.txbCuotasPagadas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlNcuotas = new System.Windows.Forms.Panel();
            this.txbNCuotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.ErrorNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlID.SuspendLayout();
            this.pnlCuotas.SuspendLayout();
            this.pnlColonias.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.pnlComentario.SuspendLayout();
            this.pnlBoton.SuspendLayout();
            this.pnlMonto.SuspendLayout();
            this.pnlSaldo.SuspendLayout();
            this.pnlCuotasPagadas.SuspendLayout();
            this.pnlNcuotas.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlID
            // 
            this.pnlID.BackColor = System.Drawing.SystemColors.Control;
            this.pnlID.Controls.Add(this.txbId);
            this.pnlID.Controls.Add(this.lblId);
            this.pnlID.Location = new System.Drawing.Point(17, 12);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(416, 44);
            this.pnlID.TabIndex = 11;
            // 
            // txbId
            // 
            this.txbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(0, 20);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(392, 24);
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
            // pnlCuotas
            // 
            this.pnlCuotas.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCuotas.Controls.Add(this.cmbCuota);
            this.pnlCuotas.Controls.Add(this.label1);
            this.pnlCuotas.Location = new System.Drawing.Point(17, 214);
            this.pnlCuotas.Name = "pnlCuotas";
            this.pnlCuotas.Size = new System.Drawing.Size(416, 44);
            this.pnlCuotas.TabIndex = 13;
            // 
            // cmbCuota
            // 
            this.cmbCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCuota.FormattingEnabled = true;
            this.cmbCuota.Location = new System.Drawing.Point(0, 18);
            this.cmbCuota.Name = "cmbCuota";
            this.cmbCuota.Size = new System.Drawing.Size(395, 26);
            this.cmbCuota.TabIndex = 1;
            this.cmbCuota.SelectedIndexChanged += new System.EventHandler(this.cmbCuota_SelectedIndexChanged);
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
            // pnlColonias
            // 
            this.pnlColonias.BackColor = System.Drawing.SystemColors.Control;
            this.pnlColonias.Controls.Add(this.cmbColonia);
            this.pnlColonias.Controls.Add(this.lblColonia);
            this.pnlColonias.Location = new System.Drawing.Point(445, 12);
            this.pnlColonias.Name = "pnlColonias";
            this.pnlColonias.Size = new System.Drawing.Size(416, 44);
            this.pnlColonias.TabIndex = 12;
            // 
            // cmbColonia
            // 
            this.cmbColonia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColonia.FormattingEnabled = true;
            this.cmbColonia.Location = new System.Drawing.Point(0, 18);
            this.cmbColonia.Name = "cmbColonia";
            this.cmbColonia.Size = new System.Drawing.Size(392, 26);
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
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEstado.Controls.Add(this.cmbEstado);
            this.pnlEstado.Controls.Add(this.label2);
            this.pnlEstado.Location = new System.Drawing.Point(445, 143);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(416, 44);
            this.pnlEstado.TabIndex = 14;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstado.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "DE BAJA"});
            this.cmbEstado.Location = new System.Drawing.Point(0, 18);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(395, 26);
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
            // pnlComentario
            // 
            this.pnlComentario.BackColor = System.Drawing.SystemColors.Control;
            this.pnlComentario.Controls.Add(this.txbComentario);
            this.pnlComentario.Controls.Add(this.label3);
            this.pnlComentario.Location = new System.Drawing.Point(445, 214);
            this.pnlComentario.Name = "pnlComentario";
            this.pnlComentario.Size = new System.Drawing.Size(416, 44);
            this.pnlComentario.TabIndex = 15;
            // 
            // txbComentario
            // 
            this.txbComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComentario.Location = new System.Drawing.Point(0, 20);
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(395, 24);
            this.txbComentario.TabIndex = 1;
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
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnCancelar);
            this.pnlBoton.Controls.Add(this.btnAgregar);
            this.pnlBoton.Location = new System.Drawing.Point(303, 30);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Size = new System.Drawing.Size(266, 55);
            this.pnlBoton.TabIndex = 16;
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
            // pnlMonto
            // 
            this.pnlMonto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMonto.Controls.Add(this.txbMonto);
            this.pnlMonto.Controls.Add(this.label4);
            this.pnlMonto.Location = new System.Drawing.Point(17, 79);
            this.pnlMonto.Name = "pnlMonto";
            this.pnlMonto.Size = new System.Drawing.Size(416, 44);
            this.pnlMonto.TabIndex = 16;
            // 
            // txbMonto
            // 
            this.txbMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMonto.Location = new System.Drawing.Point(0, 20);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(395, 24);
            this.txbMonto.TabIndex = 1;
            this.txbMonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMonto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monto: ";
            // 
            // pnlSaldo
            // 
            this.pnlSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSaldo.Controls.Add(this.txbSaldo);
            this.pnlSaldo.Controls.Add(this.label5);
            this.pnlSaldo.Location = new System.Drawing.Point(445, 79);
            this.pnlSaldo.Name = "pnlSaldo";
            this.pnlSaldo.Size = new System.Drawing.Size(416, 44);
            this.pnlSaldo.TabIndex = 17;
            // 
            // txbSaldo
            // 
            this.txbSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaldo.Location = new System.Drawing.Point(0, 20);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(395, 24);
            this.txbSaldo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saldo: ";
            // 
            // pnlCuotasPagadas
            // 
            this.pnlCuotasPagadas.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCuotasPagadas.Controls.Add(this.txbCuotasPagadas);
            this.pnlCuotasPagadas.Controls.Add(this.label6);
            this.pnlCuotasPagadas.Location = new System.Drawing.Point(17, 277);
            this.pnlCuotasPagadas.Name = "pnlCuotasPagadas";
            this.pnlCuotasPagadas.Size = new System.Drawing.Size(416, 44);
            this.pnlCuotasPagadas.TabIndex = 18;
            // 
            // txbCuotasPagadas
            // 
            this.txbCuotasPagadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCuotasPagadas.Enabled = false;
            this.txbCuotasPagadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCuotasPagadas.Location = new System.Drawing.Point(0, 20);
            this.txbCuotasPagadas.Name = "txbCuotasPagadas";
            this.txbCuotasPagadas.Size = new System.Drawing.Size(395, 24);
            this.txbCuotasPagadas.TabIndex = 1;
            this.txbCuotasPagadas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cuotas Pagadas";
            // 
            // pnlNcuotas
            // 
            this.pnlNcuotas.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNcuotas.Controls.Add(this.txbNCuotas);
            this.pnlNcuotas.Controls.Add(this.label7);
            this.pnlNcuotas.Location = new System.Drawing.Point(17, 143);
            this.pnlNcuotas.Name = "pnlNcuotas";
            this.pnlNcuotas.Size = new System.Drawing.Size(416, 44);
            this.pnlNcuotas.TabIndex = 20;
            // 
            // txbNCuotas
            // 
            this.txbNCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNCuotas.Location = new System.Drawing.Point(0, 20);
            this.txbNCuotas.Name = "txbNCuotas";
            this.txbNCuotas.Size = new System.Drawing.Size(395, 24);
            this.txbNCuotas.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cuotas";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotones.Controls.Add(this.pnlBoton);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 347);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(891, 109);
            this.pnlBotones.TabIndex = 21;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPrincipal.Controls.Add(this.pnlID);
            this.pnlPrincipal.Controls.Add(this.pnlColonias);
            this.pnlPrincipal.Controls.Add(this.pnlMonto);
            this.pnlPrincipal.Controls.Add(this.pnlNcuotas);
            this.pnlPrincipal.Controls.Add(this.pnlCuotas);
            this.pnlPrincipal.Controls.Add(this.pnlSaldo);
            this.pnlPrincipal.Controls.Add(this.pnlCuotasPagadas);
            this.pnlPrincipal.Controls.Add(this.pnlEstado);
            this.pnlPrincipal.Controls.Add(this.pnlComentario);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(891, 347);
            this.pnlPrincipal.TabIndex = 22;
            // 
            // ErrorNotificador
            // 
            this.ErrorNotificador.ContainerControl = this;
            // 
            // frmGestionAcometida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 456);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionAcometida";
            this.Text = "GestionServicios";
            this.Load += new System.EventHandler(this.frmGestionServicios_Load);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlCuotas.ResumeLayout(false);
            this.pnlCuotas.PerformLayout();
            this.pnlColonias.ResumeLayout(false);
            this.pnlColonias.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            this.pnlComentario.ResumeLayout(false);
            this.pnlComentario.PerformLayout();
            this.pnlBoton.ResumeLayout(false);
            this.pnlMonto.ResumeLayout(false);
            this.pnlMonto.PerformLayout();
            this.pnlSaldo.ResumeLayout(false);
            this.pnlSaldo.PerformLayout();
            this.pnlCuotasPagadas.ResumeLayout(false);
            this.pnlCuotasPagadas.PerformLayout();
            this.pnlNcuotas.ResumeLayout(false);
            this.pnlNcuotas.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlID;
        public System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlCuotas;
        public System.Windows.Forms.ComboBox cmbCuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlColonias;
        public System.Windows.Forms.ComboBox cmbColonia;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Panel pnlEstado;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlComentario;
        public System.Windows.Forms.TextBox txbComentario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlMonto;
        public System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSaldo;
        public System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCuotasPagadas;
        public System.Windows.Forms.TextBox txbCuotasPagadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlNcuotas;
        public System.Windows.Forms.TextBox txbNCuotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ErrorProvider ErrorNotificador;
    }
}