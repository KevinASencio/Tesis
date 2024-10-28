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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionRolesPermisos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.ptbAgregar = new System.Windows.Forms.PictureBox();
            this.ptbQuitar = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosCon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuitar)).BeginInit();
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
            // dtgvPermisosDen
            // 
            this.dtgvPermisosDen.AllowUserToAddRows = false;
            this.dtgvPermisosDen.AllowUserToDeleteRows = false;
            this.dtgvPermisosDen.AllowUserToResizeColumns = false;
            this.dtgvPermisosDen.AllowUserToResizeRows = false;
            this.dtgvPermisosDen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPermisosDen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPermisosDen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosDen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosDen.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPermisosDen.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosDen.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvPermisosCon.RowHeadersVisible = false;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPermisosCon.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // ptbQuitar
            // 
            this.ptbQuitar.Image = ((System.Drawing.Image)(resources.GetObject("ptbQuitar.Image")));
            this.ptbQuitar.Location = new System.Drawing.Point(167, 87);
            this.ptbQuitar.Name = "ptbQuitar";
            this.ptbQuitar.Size = new System.Drawing.Size(32, 32);
            this.ptbQuitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbQuitar.TabIndex = 12;
            this.ptbQuitar.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermisosCon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuitar)).EndInit();
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
    }
}