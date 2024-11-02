namespace GUI.FormsGestion
{
    partial class frmGestionRolesPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionRolesPermisos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbQuitar = new System.Windows.Forms.PictureBox();
            this.ptbAgregar = new System.Windows.Forms.PictureBox();
            this.dtgvPermisosDen = new System.Windows.Forms.DataGridView();
            this.acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvPermisosCon = new System.Windows.Forms.DataGridView();
            this.accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDirreccion = new System.Windows.Forms.Panel();
            this.txbRol = new System.Windows.Forms.TextBox();
            this.lblDirreccion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbIdRol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.errorNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosCon)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDirreccion.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlBoton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNotificador)).BeginInit();
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
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.splitContainer1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 25);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(800, 425);
            this.pnlPrincipal.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlBoton);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.pnlDirreccion);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbQuitar);
            this.panel2.Controls.Add(this.ptbAgregar);
            this.panel2.Controls.Add(this.dtgvPermisosDen);
            this.panel2.Controls.Add(this.dtgvPermisosCon);
            this.panel2.Location = new System.Drawing.Point(23, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 253);
            this.panel2.TabIndex = 2;
            // 
            // ptbQuitar
            // 
            this.ptbQuitar.Image = ((System.Drawing.Image)(resources.GetObject("ptbQuitar.Image")));
            this.ptbQuitar.Location = new System.Drawing.Point(167, 87);
            this.ptbQuitar.Name = "ptbQuitar";
            this.ptbQuitar.Size = new System.Drawing.Size(32, 32);
            this.ptbQuitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbQuitar.TabIndex = 12;
            this.ptbQuitar.TabStop = false;
            this.ptbQuitar.Click += new System.EventHandler(this.ptbQuitar_Click);
            // 
            // ptbAgregar
            // 
            this.ptbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAgregar.Image")));
            this.ptbAgregar.Location = new System.Drawing.Point(167, 49);
            this.ptbAgregar.Name = "ptbAgregar";
            this.ptbAgregar.Size = new System.Drawing.Size(32, 32);
            this.ptbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbAgregar.TabIndex = 11;
            this.ptbAgregar.TabStop = false;
            this.ptbAgregar.Click += new System.EventHandler(this.ptbAgregar_Click);
            // 
            // dtgvPermisosDen
            // 
            this.dtgvPermisosDen.AllowUserToAddRows = false;
            this.dtgvPermisosDen.AllowUserToDeleteRows = false;
            this.dtgvPermisosDen.AllowUserToResizeColumns = false;
            this.dtgvPermisosDen.AllowUserToResizeRows = false;
            this.dtgvPermisosDen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPermisosDen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPermisosDen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosDen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvPermisosDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPermisosDen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acciones});
            this.dtgvPermisosDen.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgvPermisosDen.EnableHeadersVisualStyles = false;
            this.dtgvPermisosDen.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvPermisosDen.Location = new System.Drawing.Point(216, 0);
            this.dtgvPermisosDen.MultiSelect = false;
            this.dtgvPermisosDen.Name = "dtgvPermisosDen";
            this.dtgvPermisosDen.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosDen.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvPermisosDen.RowHeadersVisible = false;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosDen.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvPermisosDen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPermisosDen.ShowCellToolTips = false;
            this.dtgvPermisosDen.Size = new System.Drawing.Size(152, 253);
            this.dtgvPermisosDen.TabIndex = 8;
            // 
            // acciones
            // 
            this.acciones.DataPropertyName = "accion";
            this.acciones.HeaderText = "Permisos Sin Conceder";
            this.acciones.Name = "acciones";
            this.acciones.ReadOnly = true;
            // 
            // dtgvPermisosCon
            // 
            this.dtgvPermisosCon.AllowUserToAddRows = false;
            this.dtgvPermisosCon.AllowUserToDeleteRows = false;
            this.dtgvPermisosCon.AllowUserToResizeColumns = false;
            this.dtgvPermisosCon.AllowUserToResizeRows = false;
            this.dtgvPermisosCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPermisosCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPermisosCon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvPermisosCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPermisosCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accion,
            this.idpermiso,
            this.idaccion});
            this.dtgvPermisosCon.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvPermisosCon.EnableHeadersVisualStyles = false;
            this.dtgvPermisosCon.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvPermisosCon.Location = new System.Drawing.Point(0, 0);
            this.dtgvPermisosCon.MultiSelect = false;
            this.dtgvPermisosCon.Name = "dtgvPermisosCon";
            this.dtgvPermisosCon.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvPermisosCon.RowHeadersVisible = false;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosCon.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvPermisosCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPermisosCon.ShowCellToolTips = false;
            this.dtgvPermisosCon.Size = new System.Drawing.Size(150, 253);
            this.dtgvPermisosCon.TabIndex = 7;
            // 
            // accion
            // 
            this.accion.DataPropertyName = "accion";
            this.accion.HeaderText = "Permisos Concedidos";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            // 
            // idpermiso
            // 
            this.idpermiso.DataPropertyName = "idpermiso";
            this.idpermiso.HeaderText = "idpermiso";
            this.idpermiso.Name = "idpermiso";
            this.idpermiso.ReadOnly = true;
            this.idpermiso.Visible = false;
            // 
            // idaccion
            // 
            this.idaccion.DataPropertyName = "idaccion";
            this.idaccion.HeaderText = "idaccion";
            this.idaccion.Name = "idaccion";
            this.idaccion.ReadOnly = true;
            this.idaccion.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRoles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(71, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 50);
            this.panel1.TabIndex = 1;
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(48, 14);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(182, 28);
            this.cmbRoles.TabIndex = 1;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roles";
            // 
            // pnlDirreccion
            // 
            this.pnlDirreccion.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDirreccion.Controls.Add(this.txbRol);
            this.pnlDirreccion.Controls.Add(this.lblDirreccion);
            this.pnlDirreccion.Location = new System.Drawing.Point(9, 193);
            this.pnlDirreccion.Name = "pnlDirreccion";
            this.pnlDirreccion.Size = new System.Drawing.Size(372, 43);
            this.pnlDirreccion.TabIndex = 3;
            // 
            // txbRol
            // 
            this.txbRol.Location = new System.Drawing.Point(0, 23);
            this.txbRol.Name = "txbRol";
            this.txbRol.Size = new System.Drawing.Size(350, 20);
            this.txbRol.TabIndex = 1;
            // 
            // lblDirreccion
            // 
            this.lblDirreccion.AutoSize = true;
            this.lblDirreccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirreccion.Location = new System.Drawing.Point(4, 4);
            this.lblDirreccion.Name = "lblDirreccion";
            this.lblDirreccion.Size = new System.Drawing.Size(33, 20);
            this.lblDirreccion.TabIndex = 0;
            this.lblDirreccion.Text = "Rol";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txbIdRol);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(11, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 43);
            this.panel3.TabIndex = 3;
            // 
            // txbIdRol
            // 
            this.txbIdRol.Enabled = false;
            this.txbIdRol.Location = new System.Drawing.Point(0, 23);
            this.txbIdRol.Name = "txbIdRol";
            this.txbIdRol.Size = new System.Drawing.Size(344, 20);
            this.txbIdRol.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id Rol";
            // 
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnCancelar);
            this.pnlBoton.Controls.Add(this.btnAgregar);
            this.pnlBoton.Location = new System.Drawing.Point(61, 259);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Size = new System.Drawing.Size(266, 43);
            this.pnlBoton.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(142, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 46);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(3, -1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 46);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorNotificador
            // 
            this.errorNotificador.ContainerControl = this;
            // 
            // frmGestionRolesPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionRolesPermisos";
            this.Text = "frmGestionRolesPermisos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosCon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDirreccion.ResumeLayout(false);
            this.pnlDirreccion.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlBoton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorNotificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripCerrar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dtgvPermisosCon;
        public System.Windows.Forms.DataGridView dtgvPermisosDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn acciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaccion;
        private System.Windows.Forms.PictureBox ptbAgregar;
        private System.Windows.Forms.PictureBox ptbQuitar;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox txbIdRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDirreccion;
        internal System.Windows.Forms.TextBox txbRol;
        private System.Windows.Forms.Label lblDirreccion;
        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider errorNotificador;
    }
}