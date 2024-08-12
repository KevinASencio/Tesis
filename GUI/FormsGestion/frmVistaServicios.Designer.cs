namespace GUI.FormsGestion
{
    partial class frmVistaServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaServicios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.prbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlConsumo = new System.Windows.Forms.Panel();
            this.dtgvServiciosConsumo = new System.Windows.Forms.DataGridView();
            this.idservicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idconsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcolonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotas__ant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBtnConsumo = new System.Windows.Forms.Panel();
            this.btnCambiarEstadoCon = new System.Windows.Forms.Button();
            this.btnEditarCon = new System.Windows.Forms.Button();
            this.btnAgregarCon = new System.Windows.Forms.Button();
            this.pnlTitulo1 = new System.Windows.Forms.Panel();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.pnlAcometida = new System.Windows.Forms.Panel();
            this.dtgvServiciosAcometida = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCambiarEstadoAco = new System.Windows.Forms.Button();
            this.btnEditarAco = new System.Windows.Forms.Button();
            this.btnAgregarAco = new System.Windows.Forms.Button();
            this.pnlTitulo2 = new System.Windows.Forms.Panel();
            this.lblAcometida = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotas_restantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idacometida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServiciosConsumo)).BeginInit();
            this.pnlBtnConsumo.SuspendLayout();
            this.pnlTitulo1.SuspendLayout();
            this.pnlAcometida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServiciosAcometida)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlTitulo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.prbCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(881, 25);
            this.pnlTop.TabIndex = 14;
            // 
            // prbCerrar
            // 
            this.prbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("prbCerrar.Image")));
            this.prbCerrar.Location = new System.Drawing.Point(857, 1);
            this.prbCerrar.Name = "prbCerrar";
            this.prbCerrar.Size = new System.Drawing.Size(25, 25);
            this.prbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbCerrar.TabIndex = 0;
            this.prbCerrar.TabStop = false;
            this.prbCerrar.Click += new System.EventHandler(this.prbCerrar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlConsumo);
            this.pnlPrincipal.Controls.Add(this.pnlAcometida);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(881, 478);
            this.pnlPrincipal.TabIndex = 16;
            this.pnlPrincipal.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlPrincipal_ControlRemoved);
            // 
            // pnlConsumo
            // 
            this.pnlConsumo.Controls.Add(this.dtgvServiciosConsumo);
            this.pnlConsumo.Controls.Add(this.pnlBtnConsumo);
            this.pnlConsumo.Controls.Add(this.pnlTitulo1);
            this.pnlConsumo.Location = new System.Drawing.Point(0, 25);
            this.pnlConsumo.Name = "pnlConsumo";
            this.pnlConsumo.Size = new System.Drawing.Size(878, 214);
            this.pnlConsumo.TabIndex = 12;
            // 
            // dtgvServiciosConsumo
            // 
            this.dtgvServiciosConsumo.AllowUserToAddRows = false;
            this.dtgvServiciosConsumo.AllowUserToDeleteRows = false;
            this.dtgvServiciosConsumo.AllowUserToOrderColumns = true;
            this.dtgvServiciosConsumo.AllowUserToResizeColumns = false;
            this.dtgvServiciosConsumo.AllowUserToResizeRows = false;
            this.dtgvServiciosConsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvServiciosConsumo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvServiciosConsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvServiciosConsumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServiciosConsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvServiciosConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvServiciosConsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idservicio,
            this.idcuota,
            this.cliente,
            this.idconsumo,
            this.idcliente,
            this.idcolonia,
            this.fecha_apertura,
            this.cuotas__ant,
            this.colonia,
            this.cuota,
            this.estado,
            this.comentario});
            this.dtgvServiciosConsumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvServiciosConsumo.EnableHeadersVisualStyles = false;
            this.dtgvServiciosConsumo.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvServiciosConsumo.Location = new System.Drawing.Point(0, 30);
            this.dtgvServiciosConsumo.MultiSelect = false;
            this.dtgvServiciosConsumo.Name = "dtgvServiciosConsumo";
            this.dtgvServiciosConsumo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServiciosConsumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvServiciosConsumo.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServiciosConsumo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvServiciosConsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvServiciosConsumo.ShowCellToolTips = false;
            this.dtgvServiciosConsumo.Size = new System.Drawing.Size(751, 184);
            this.dtgvServiciosConsumo.TabIndex = 14;
            // 
            // idservicio
            // 
            this.idservicio.DataPropertyName = "idservicio";
            this.idservicio.HeaderText = "Id Servicio";
            this.idservicio.Name = "idservicio";
            this.idservicio.ReadOnly = true;
            // 
            // idcuota
            // 
            this.idcuota.DataPropertyName = "idcuotaconsumo";
            this.idcuota.HeaderText = "Id Cuota";
            this.idcuota.Name = "idcuota";
            this.idcuota.ReadOnly = true;
            this.idcuota.Visible = false;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // idconsumo
            // 
            this.idconsumo.DataPropertyName = "idconsumo";
            this.idconsumo.HeaderText = "idconsumo";
            this.idconsumo.Name = "idconsumo";
            this.idconsumo.ReadOnly = true;
            this.idconsumo.Visible = false;
            // 
            // idcliente
            // 
            this.idcliente.DataPropertyName = "idcliente";
            this.idcliente.HeaderText = "idcliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            // 
            // idcolonia
            // 
            this.idcolonia.DataPropertyName = "idcolonia";
            this.idcolonia.HeaderText = "idcolonia";
            this.idcolonia.Name = "idcolonia";
            this.idcolonia.ReadOnly = true;
            this.idcolonia.Visible = false;
            // 
            // fecha_apertura
            // 
            this.fecha_apertura.DataPropertyName = "fecha_apertura";
            this.fecha_apertura.HeaderText = "Fecha Apertura";
            this.fecha_apertura.Name = "fecha_apertura";
            this.fecha_apertura.ReadOnly = true;
            // 
            // cuotas__ant
            // 
            this.cuotas__ant.DataPropertyName = "cuotas_anticipadas";
            this.cuotas__ant.HeaderText = "Cuotas Anticipadas";
            this.cuotas__ant.Name = "cuotas__ant";
            this.cuotas__ant.ReadOnly = true;
            // 
            // colonia
            // 
            this.colonia.DataPropertyName = "colonia";
            this.colonia.HeaderText = "Colonia";
            this.colonia.Name = "colonia";
            this.colonia.ReadOnly = true;
            // 
            // cuota
            // 
            this.cuota.DataPropertyName = "monto";
            this.cuota.HeaderText = "Cuota";
            this.cuota.Name = "cuota";
            this.cuota.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // comentario
            // 
            this.comentario.DataPropertyName = "comentario";
            this.comentario.HeaderText = "Comentario";
            this.comentario.Name = "comentario";
            this.comentario.ReadOnly = true;
            this.comentario.Visible = false;
            // 
            // pnlBtnConsumo
            // 
            this.pnlBtnConsumo.Controls.Add(this.btnCambiarEstadoCon);
            this.pnlBtnConsumo.Controls.Add(this.btnEditarCon);
            this.pnlBtnConsumo.Controls.Add(this.btnAgregarCon);
            this.pnlBtnConsumo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBtnConsumo.Location = new System.Drawing.Point(751, 30);
            this.pnlBtnConsumo.Name = "pnlBtnConsumo";
            this.pnlBtnConsumo.Size = new System.Drawing.Size(127, 184);
            this.pnlBtnConsumo.TabIndex = 13;
            // 
            // btnCambiarEstadoCon
            // 
            this.btnCambiarEstadoCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiarEstadoCon.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstadoCon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCambiarEstadoCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstadoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoCon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCambiarEstadoCon.Location = new System.Drawing.Point(3, 106);
            this.btnCambiarEstadoCon.Name = "btnCambiarEstadoCon";
            this.btnCambiarEstadoCon.Size = new System.Drawing.Size(121, 46);
            this.btnCambiarEstadoCon.TabIndex = 2;
            this.btnCambiarEstadoCon.Text = "Cambiar Estado";
            this.btnCambiarEstadoCon.UseVisualStyleBackColor = false;
            this.btnCambiarEstadoCon.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnEditarCon
            // 
            this.btnEditarCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarCon.FlatAppearance.BorderSize = 0;
            this.btnEditarCon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnEditarCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarCon.Location = new System.Drawing.Point(3, 54);
            this.btnEditarCon.Name = "btnEditarCon";
            this.btnEditarCon.Size = new System.Drawing.Size(121, 46);
            this.btnEditarCon.TabIndex = 1;
            this.btnEditarCon.Text = "Editar";
            this.btnEditarCon.UseVisualStyleBackColor = false;
            this.btnEditarCon.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregarCon
            // 
            this.btnAgregarCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarCon.FlatAppearance.BorderSize = 0;
            this.btnAgregarCon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnAgregarCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarCon.Location = new System.Drawing.Point(3, 1);
            this.btnAgregarCon.Name = "btnAgregarCon";
            this.btnAgregarCon.Size = new System.Drawing.Size(121, 46);
            this.btnAgregarCon.TabIndex = 0;
            this.btnAgregarCon.Text = "Agregar";
            this.btnAgregarCon.UseVisualStyleBackColor = false;
            this.btnAgregarCon.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlTitulo1
            // 
            this.pnlTitulo1.Controls.Add(this.lblConsumo);
            this.pnlTitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo1.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo1.Name = "pnlTitulo1";
            this.pnlTitulo1.Size = new System.Drawing.Size(878, 30);
            this.pnlTitulo1.TabIndex = 0;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(407, 7);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(84, 20);
            this.lblConsumo.TabIndex = 0;
            this.lblConsumo.Text = "Consumo";
            // 
            // pnlAcometida
            // 
            this.pnlAcometida.Controls.Add(this.dtgvServiciosAcometida);
            this.pnlAcometida.Controls.Add(this.panel3);
            this.pnlAcometida.Controls.Add(this.pnlTitulo2);
            this.pnlAcometida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcometida.Location = new System.Drawing.Point(0, 233);
            this.pnlAcometida.Name = "pnlAcometida";
            this.pnlAcometida.Size = new System.Drawing.Size(881, 245);
            this.pnlAcometida.TabIndex = 13;
            // 
            // dtgvServiciosAcometida
            // 
            this.dtgvServiciosAcometida.AllowUserToAddRows = false;
            this.dtgvServiciosAcometida.AllowUserToDeleteRows = false;
            this.dtgvServiciosAcometida.AllowUserToOrderColumns = true;
            this.dtgvServiciosAcometida.AllowUserToResizeColumns = false;
            this.dtgvServiciosAcometida.AllowUserToResizeRows = false;
            this.dtgvServiciosAcometida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvServiciosAcometida.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvServiciosAcometida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvServiciosAcometida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServiciosAcometida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvServiciosAcometida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvServiciosAcometida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.monto,
            this.saldo,
            this.cuotas_restantes,
            this.idacometida});
            this.dtgvServiciosAcometida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvServiciosAcometida.EnableHeadersVisualStyles = false;
            this.dtgvServiciosAcometida.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvServiciosAcometida.Location = new System.Drawing.Point(0, 34);
            this.dtgvServiciosAcometida.MultiSelect = false;
            this.dtgvServiciosAcometida.Name = "dtgvServiciosAcometida";
            this.dtgvServiciosAcometida.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServiciosAcometida.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvServiciosAcometida.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServiciosAcometida.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvServiciosAcometida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvServiciosAcometida.ShowCellToolTips = false;
            this.dtgvServiciosAcometida.Size = new System.Drawing.Size(754, 211);
            this.dtgvServiciosAcometida.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCambiarEstadoAco);
            this.panel3.Controls.Add(this.btnEditarAco);
            this.panel3.Controls.Add(this.btnAgregarAco);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(754, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 211);
            this.panel3.TabIndex = 16;
            // 
            // btnCambiarEstadoAco
            // 
            this.btnCambiarEstadoAco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiarEstadoAco.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstadoAco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCambiarEstadoAco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstadoAco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoAco.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCambiarEstadoAco.Location = new System.Drawing.Point(3, 106);
            this.btnCambiarEstadoAco.Name = "btnCambiarEstadoAco";
            this.btnCambiarEstadoAco.Size = new System.Drawing.Size(121, 46);
            this.btnCambiarEstadoAco.TabIndex = 2;
            this.btnCambiarEstadoAco.Text = "Cambiar Estado";
            this.btnCambiarEstadoAco.UseVisualStyleBackColor = false;
            // 
            // btnEditarAco
            // 
            this.btnEditarAco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarAco.FlatAppearance.BorderSize = 0;
            this.btnEditarAco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnEditarAco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAco.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarAco.Location = new System.Drawing.Point(3, 54);
            this.btnEditarAco.Name = "btnEditarAco";
            this.btnEditarAco.Size = new System.Drawing.Size(121, 46);
            this.btnEditarAco.TabIndex = 1;
            this.btnEditarAco.Text = "Editar";
            this.btnEditarAco.UseVisualStyleBackColor = false;
            this.btnEditarAco.Click += new System.EventHandler(this.btnEditarAco_Click);
            // 
            // btnAgregarAco
            // 
            this.btnAgregarAco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarAco.FlatAppearance.BorderSize = 0;
            this.btnAgregarAco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnAgregarAco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAco.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarAco.Location = new System.Drawing.Point(3, 1);
            this.btnAgregarAco.Name = "btnAgregarAco";
            this.btnAgregarAco.Size = new System.Drawing.Size(121, 46);
            this.btnAgregarAco.TabIndex = 0;
            this.btnAgregarAco.Text = "Agregar";
            this.btnAgregarAco.UseVisualStyleBackColor = false;
            this.btnAgregarAco.Click += new System.EventHandler(this.btnAgregarAco_Click);
            // 
            // pnlTitulo2
            // 
            this.pnlTitulo2.Controls.Add(this.lblAcometida);
            this.pnlTitulo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo2.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo2.Name = "pnlTitulo2";
            this.pnlTitulo2.Size = new System.Drawing.Size(881, 34);
            this.pnlTitulo2.TabIndex = 0;
            // 
            // lblAcometida
            // 
            this.lblAcometida.AutoSize = true;
            this.lblAcometida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcometida.Location = new System.Drawing.Point(419, 8);
            this.lblAcometida.Name = "lblAcometida";
            this.lblAcometida.Size = new System.Drawing.Size(94, 20);
            this.lblAcometida.TabIndex = 0;
            this.lblAcometida.Text = "Acometida";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idservicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Servicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idcuota";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id Cuota";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idcliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "idcliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idcolonia";
            this.dataGridViewTextBoxColumn6.HeaderText = "idcolonia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_apertura";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha Apertura";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cuotas_anticipadas";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cuotas Anticipadas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "colonia";
            this.dataGridViewTextBoxColumn9.HeaderText = "Colonia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cuota";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "comentario";
            this.dataGridViewTextBoxColumn12.HeaderText = "Comentario";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "total";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // cuotas_restantes
            // 
            this.cuotas_restantes.DataPropertyName = "cuotas_restantes";
            this.cuotas_restantes.HeaderText = "Cuotas Restantes";
            this.cuotas_restantes.Name = "cuotas_restantes";
            this.cuotas_restantes.ReadOnly = true;
            // 
            // idacometida
            // 
            this.idacometida.DataPropertyName = "idserviciosacometida";
            this.idacometida.HeaderText = "idservicio";
            this.idacometida.Name = "idacometida";
            this.idacometida.ReadOnly = true;
            this.idacometida.Visible = false;
            // 
            // frmVistaServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 503);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVistaServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaSeervicios";
            this.Load += new System.EventHandler(this.frmVistaServicios_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.frmVistaServicios_ControlAdded);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlConsumo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServiciosConsumo)).EndInit();
            this.pnlBtnConsumo.ResumeLayout(false);
            this.pnlTitulo1.ResumeLayout(false);
            this.pnlTitulo1.PerformLayout();
            this.pnlAcometida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServiciosAcometida)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlTitulo2.ResumeLayout(false);
            this.pnlTitulo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox prbCerrar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlConsumo;
        private System.Windows.Forms.DataGridView dtgvServiciosConsumo;
        private System.Windows.Forms.Panel pnlBtnConsumo;
        private System.Windows.Forms.Button btnCambiarEstadoCon;
        private System.Windows.Forms.Button btnEditarCon;
        private System.Windows.Forms.Button btnAgregarCon;
        private System.Windows.Forms.Panel pnlTitulo1;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Panel pnlAcometida;
        private System.Windows.Forms.DataGridView dtgvServiciosAcometida;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCambiarEstadoAco;
        private System.Windows.Forms.Button btnEditarAco;
        private System.Windows.Forms.Button btnAgregarAco;
        private System.Windows.Forms.Panel pnlTitulo2;
        private System.Windows.Forms.Label lblAcometida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcolonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotas__ant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotas_restantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idacometida;
    }
}