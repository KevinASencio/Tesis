namespace GUI.FormsGestion
{
    partial class FrmCrearFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearFacturas));
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pgbCrear = new System.Windows.Forms.ProgressBar();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.prbCerrar = new System.Windows.Forms.PictureBox();
            this.gbCrear = new System.Windows.Forms.GroupBox();
            this.pnlFFinal = new System.Windows.Forms.Panel();
            this.dtpFinalConsumo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMes = new System.Windows.Forms.Panel();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFVencimiento = new System.Windows.Forms.Panel();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnGnerar = new System.Windows.Forms.Button();
            this.gbImprimir = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImpimir = new System.Windows.Forms.Button();
            this.cmbColonia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlButtom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).BeginInit();
            this.gbCrear.SuspendLayout();
            this.pnlFFinal.SuspendLayout();
            this.pnlMes.SuspendLayout();
            this.pnlFVencimiento.SuspendLayout();
            this.pnlBoton.SuspendLayout();
            this.gbImprimir.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtom
            // 
            this.pnlButtom.Controls.Add(this.lblTotal);
            this.pnlButtom.Controls.Add(this.pgbCrear);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 365);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(802, 90);
            this.pnlButtom.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoEllipsis = true;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(576, 39);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 17);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "/0";
            // 
            // pgbCrear
            // 
            this.pgbCrear.Location = new System.Drawing.Point(179, 36);
            this.pgbCrear.Name = "pgbCrear";
            this.pgbCrear.Size = new System.Drawing.Size(394, 23);
            this.pgbCrear.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbCrear.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.prbCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(802, 25);
            this.pnlTop.TabIndex = 16;
            // 
            // prbCerrar
            // 
            this.prbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("prbCerrar.Image")));
            this.prbCerrar.Location = new System.Drawing.Point(778, 1);
            this.prbCerrar.Name = "prbCerrar";
            this.prbCerrar.Size = new System.Drawing.Size(25, 25);
            this.prbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prbCerrar.TabIndex = 0;
            this.prbCerrar.TabStop = false;
            this.prbCerrar.Click += new System.EventHandler(this.prbCerrar_Click);
            // 
            // gbCrear
            // 
            this.gbCrear.BackColor = System.Drawing.Color.Transparent;
            this.gbCrear.Controls.Add(this.pnlFFinal);
            this.gbCrear.Controls.Add(this.pnlMes);
            this.gbCrear.Controls.Add(this.pnlFVencimiento);
            this.gbCrear.Controls.Add(this.pnlBoton);
            this.gbCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCrear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCrear.Location = new System.Drawing.Point(0, 0);
            this.gbCrear.Margin = new System.Windows.Forms.Padding(10);
            this.gbCrear.Name = "gbCrear";
            this.gbCrear.Size = new System.Drawing.Size(382, 328);
            this.gbCrear.TabIndex = 17;
            this.gbCrear.TabStop = false;
            this.gbCrear.Text = "Crear Facturas";
            // 
            // pnlFFinal
            // 
            this.pnlFFinal.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFFinal.Controls.Add(this.dtpFinalConsumo);
            this.pnlFFinal.Controls.Add(this.label1);
            this.pnlFFinal.Location = new System.Drawing.Point(6, 83);
            this.pnlFFinal.Name = "pnlFFinal";
            this.pnlFFinal.Size = new System.Drawing.Size(368, 50);
            this.pnlFFinal.TabIndex = 7;
            // 
            // dtpFinalConsumo
            // 
            this.dtpFinalConsumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinalConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalConsumo.Location = new System.Drawing.Point(3, 23);
            this.dtpFinalConsumo.Name = "dtpFinalConsumo";
            this.dtpFinalConsumo.Size = new System.Drawing.Size(347, 20);
            this.dtpFinalConsumo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha final de consumo";
            // 
            // pnlMes
            // 
            this.pnlMes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMes.Controls.Add(this.cmbMes);
            this.pnlMes.Controls.Add(this.label4);
            this.pnlMes.Location = new System.Drawing.Point(6, 148);
            this.pnlMes.Name = "pnlMes";
            this.pnlMes.Size = new System.Drawing.Size(368, 50);
            this.pnlMes.TabIndex = 10;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE ",
            "DICIEMBRE"});
            this.cmbMes.Location = new System.Drawing.Point(3, 26);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(347, 21);
            this.cmbMes.TabIndex = 11;
            this.cmbMes.SelectedValueChanged += new System.EventHandler(this.cmbMes_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mes";
            // 
            // pnlFVencimiento
            // 
            this.pnlFVencimiento.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFVencimiento.Controls.Add(this.dtpVencimiento);
            this.pnlFVencimiento.Controls.Add(this.label2);
            this.pnlFVencimiento.Location = new System.Drawing.Point(6, 212);
            this.pnlFVencimiento.Name = "pnlFVencimiento";
            this.pnlFVencimiento.Size = new System.Drawing.Size(368, 50);
            this.pnlFVencimiento.TabIndex = 8;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Location = new System.Drawing.Point(3, 23);
            this.dtpVencimiento.MinDate = new System.DateTime(2024, 9, 13, 0, 0, 0, 0);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(347, 20);
            this.dtpVencimiento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de vencimiento";
            // 
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnGnerar);
            this.pnlBoton.Location = new System.Drawing.Point(9, 268);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Size = new System.Drawing.Size(365, 55);
            this.pnlBoton.TabIndex = 9;
            // 
            // btnGnerar
            // 
            this.btnGnerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGnerar.FlatAppearance.BorderSize = 0;
            this.btnGnerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnGnerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGnerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGnerar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGnerar.Location = new System.Drawing.Point(121, 6);
            this.btnGnerar.Name = "btnGnerar";
            this.btnGnerar.Size = new System.Drawing.Size(121, 46);
            this.btnGnerar.TabIndex = 1;
            this.btnGnerar.Text = "Generar";
            this.btnGnerar.UseVisualStyleBackColor = false;
            this.btnGnerar.Click += new System.EventHandler(this.btnGnerar_Click);
            // 
            // gbImprimir
            // 
            this.gbImprimir.Controls.Add(this.panel3);
            this.gbImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbImprimir.Location = new System.Drawing.Point(0, 0);
            this.gbImprimir.Margin = new System.Windows.Forms.Padding(10);
            this.gbImprimir.Name = "gbImprimir";
            this.gbImprimir.Size = new System.Drawing.Size(411, 328);
            this.gbImprimir.TabIndex = 18;
            this.gbImprimir.TabStop = false;
            this.gbImprimir.Text = "Imprimir Facturas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnImpimir);
            this.panel3.Controls.Add(this.cmbColonia);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 116);
            this.panel3.TabIndex = 7;
            // 
            // btnImpimir
            // 
            this.btnImpimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImpimir.FlatAppearance.BorderSize = 0;
            this.btnImpimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnImpimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpimir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImpimir.Location = new System.Drawing.Point(123, 53);
            this.btnImpimir.Name = "btnImpimir";
            this.btnImpimir.Size = new System.Drawing.Size(121, 46);
            this.btnImpimir.TabIndex = 1;
            this.btnImpimir.Text = "Imprimir";
            this.btnImpimir.UseVisualStyleBackColor = false;
            this.btnImpimir.Click += new System.EventHandler(this.btnImpimir_Click);
            // 
            // cmbColonia
            // 
            this.cmbColonia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColonia.FormattingEnabled = true;
            this.cmbColonia.Location = new System.Drawing.Point(3, 23);
            this.cmbColonia.Name = "cmbColonia";
            this.cmbColonia.Size = new System.Drawing.Size(347, 21);
            this.cmbColonia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione la colonia";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gbCrear);
            this.panel5.Location = new System.Drawing.Point(0, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(382, 328);
            this.panel5.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.gbImprimir);
            this.panel7.Location = new System.Drawing.Point(388, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(411, 328);
            this.panel7.TabIndex = 21;
            // 
            // FrmCrearFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 455);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearFacturas";
            this.Text = "FrmCrearFacturas";
            this.Load += new System.EventHandler(this.FrmCrearFacturas_Load);
            this.Resize += new System.EventHandler(this.FrmCrearFacturas_Resize);
            this.pnlButtom.ResumeLayout(false);
            this.pnlButtom.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).EndInit();
            this.gbCrear.ResumeLayout(false);
            this.pnlFFinal.ResumeLayout(false);
            this.pnlFFinal.PerformLayout();
            this.pnlMes.ResumeLayout(false);
            this.pnlMes.PerformLayout();
            this.pnlFVencimiento.ResumeLayout(false);
            this.pnlFVencimiento.PerformLayout();
            this.pnlBoton.ResumeLayout(false);
            this.gbImprimir.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox prbCerrar;
        private System.Windows.Forms.GroupBox gbCrear;
        private System.Windows.Forms.GroupBox gbImprimir;
        private System.Windows.Forms.Panel pnlFVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFFinal;
        private System.Windows.Forms.DateTimePicker dtpFinalConsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Button btnGnerar;
        private System.Windows.Forms.Button btnImpimir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbColonia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Panel pnlMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ProgressBar pgbCrear;
        private System.Windows.Forms.Label lblTotal;
    }
}