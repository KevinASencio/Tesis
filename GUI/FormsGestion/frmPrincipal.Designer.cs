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
            this.pnlMenuDetalles = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnLosFacturas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlMenuInicio = new System.Windows.Forms.Panel();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnParametro = new System.Windows.Forms.Button();
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnGenerarFac = new System.Windows.Forms.Button();
            this.btnCorte = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.btnCobro = new System.Windows.Forms.Button();
            this.btnServiciosMora = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).BeginInit();
            this.pnlMenus.SuspendLayout();
            this.pnlMenuDetalles.SuspendLayout();
            this.pnlMenuInicio.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlMenus.Controls.Add(this.pnlMenuDetalles);
            this.pnlMenus.Controls.Add(this.pnlUser);
            this.pnlMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenus.Location = new System.Drawing.Point(0, 48);
            this.pnlMenus.Name = "pnlMenus";
            this.pnlMenus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlMenus.Size = new System.Drawing.Size(221, 720);
            this.pnlMenus.TabIndex = 2;
            // 
            // pnlMenuDetalles
            // 
            this.pnlMenuDetalles.Controls.Add(this.btnEliminar);
            this.pnlMenuDetalles.Controls.Add(this.btnServicios);
            this.pnlMenuDetalles.Controls.Add(this.btnLosFacturas);
            this.pnlMenuDetalles.Controls.Add(this.button1);
            this.pnlMenuDetalles.Controls.Add(this.btnEditar);
            this.pnlMenuDetalles.Controls.Add(this.pnlMenuInicio);
            this.pnlMenuDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuDetalles.Enabled = false;
            this.pnlMenuDetalles.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuDetalles.Name = "pnlMenuDetalles";
            this.pnlMenuDetalles.Size = new System.Drawing.Size(221, 620);
            this.pnlMenuDetalles.TabIndex = 27;
            this.pnlMenuDetalles.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(3, 413);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(219, 51);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            this.btnServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(3, 158);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(219, 51);
            this.btnServicios.TabIndex = 5;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnLosFacturas
            // 
            this.btnLosFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLosFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLosFacturas.FlatAppearance.BorderSize = 0;
            this.btnLosFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnLosFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLosFacturas.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLosFacturas.ForeColor = System.Drawing.Color.White;
            this.btnLosFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLosFacturas.Location = new System.Drawing.Point(2, 228);
            this.btnLosFacturas.Name = "btnLosFacturas";
            this.btnLosFacturas.Size = new System.Drawing.Size(219, 51);
            this.btnLosFacturas.TabIndex = 4;
            this.btnLosFacturas.Text = "Facturas";
            this.btnLosFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLosFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLosFacturas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambiar Estado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1, 288);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(219, 51);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlMenuInicio
            // 
            this.pnlMenuInicio.Controls.Add(this.pnlAcciones);
            this.pnlMenuInicio.Controls.Add(this.btnParametro);
            this.pnlMenuInicio.Controls.Add(this.btnCuotas);
            this.pnlMenuInicio.Controls.Add(this.btnUsuarios);
            this.pnlMenuInicio.Controls.Add(this.btnFacturas);
            this.pnlMenuInicio.Enabled = false;
            this.pnlMenuInicio.Location = new System.Drawing.Point(34, 116);
            this.pnlMenuInicio.Name = "pnlMenuInicio";
            this.pnlMenuInicio.Size = new System.Drawing.Size(221, 458);
            this.pnlMenuInicio.TabIndex = 3;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.pnlAcciones.Controls.Add(this.btnGuardar);
            this.pnlAcciones.Enabled = false;
            this.pnlAcciones.Location = new System.Drawing.Point(29, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(221, 458);
            this.pnlAcciones.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 51);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(1, 204);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(219, 51);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
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
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblRol);
            this.pnlUser.Controls.Add(this.lblCerrarSesion);
            this.pnlUser.Controls.Add(this.lblUsuario);
            this.pnlUser.Controls.Add(this.pictureBox1);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUser.Location = new System.Drawing.Point(0, 620);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(221, 100);
            this.pnlUser.TabIndex = 26;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(98, 43);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(46, 18);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "label1";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.lblCerrarSesion.Location = new System.Drawing.Point(98, 65);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(83, 13);
            this.lblCerrarSesion.TabIndex = 2;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(98, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 18);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.PnlPrincipal.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnlPrincipal_ControlRemoved);
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
            this.pnlBotones.Enter += new System.EventHandler(this.pnlBotones_Enter);
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
            this.btnCobro.Click += new System.EventHandler(this.btnCobro_Click);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            this.ResizeBegin += new System.EventHandler(this.GestionClientes_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.GestionClientes_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.GestionClientes_SizeChanged);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).EndInit();
            this.pnlMenus.ResumeLayout(false);
            this.pnlMenuDetalles.ResumeLayout(false);
            this.pnlMenuInicio.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnServiciosMora;
        private System.Windows.Forms.Button btnGenerarFac;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.Button btnCobro;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel pnlMenuDetalles;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMenuInicio;
        public System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnParametro;
        private System.Windows.Forms.Button btnLosFacturas;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Panel pnlMenus;
    }
}