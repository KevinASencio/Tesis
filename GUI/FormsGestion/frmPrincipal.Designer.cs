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
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbRestaurar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.prbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenus = new System.Windows.Forms.Panel();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCierre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbCerrar)).BeginInit();
            this.PnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarios.Location = new System.Drawing.Point(39, 173);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(170, 36);
            this.lblUsuarios.TabIndex = 58;
            this.lblUsuarios.Text = "Usuarios";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.PnlPrincipal.BackColor = System.Drawing.Color.RosyBrown;
            this.PnlPrincipal.Controls.Add(this.label9);
            this.PnlPrincipal.Controls.Add(this.label8);
            this.PnlPrincipal.Controls.Add(this.lblUsuarios);
            this.PnlPrincipal.Controls.Add(this.label4);
            this.PnlPrincipal.Controls.Add(this.btn6);
            this.PnlPrincipal.Controls.Add(this.label5);
            this.PnlPrincipal.Controls.Add(this.btn5);
            this.PnlPrincipal.Controls.Add(this.label6);
            this.PnlPrincipal.Controls.Add(this.btn4);
            this.PnlPrincipal.Controls.Add(this.label7);
            this.PnlPrincipal.Controls.Add(this.btnCierre);
            this.PnlPrincipal.Controls.Add(this.label3);
            this.PnlPrincipal.Controls.Add(this.btn3);
            this.PnlPrincipal.Controls.Add(this.label2);
            this.PnlPrincipal.Controls.Add(this.btn2);
            this.PnlPrincipal.Controls.Add(this.label1);
            this.PnlPrincipal.Controls.Add(this.btn1);
            this.PnlPrincipal.Controls.Add(this.btnUsuarios);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(221, 48);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(803, 720);
            this.PnlPrincipal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(516, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 36);
            this.label4.TabIndex = 56;
            this.label4.Text = "Usuarios";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn6.Location = new System.Drawing.Point(516, 332);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(170, 150);
            this.btn6.TabIndex = 55;
            this.btn6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(364, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 36);
            this.label5.TabIndex = 54;
            this.label5.Text = "Usuarios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn5.Location = new System.Drawing.Point(364, 332);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(170, 150);
            this.btn5.TabIndex = 53;
            this.btn5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(199, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 36);
            this.label6.TabIndex = 52;
            this.label6.Text = "Usuarios";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn4.Location = new System.Drawing.Point(199, 332);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(170, 150);
            this.btn4.TabIndex = 51;
            this.btn4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(38, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 36);
            this.label7.TabIndex = 50;
            this.label7.Text = "Usuarios";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCierre
            // 
            this.btnCierre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCierre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnCierre.FlatAppearance.BorderSize = 2;
            this.btnCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierre.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierre.ForeColor = System.Drawing.Color.Black;
            this.btnCierre.Image = ((System.Drawing.Image)(resources.GetObject("btnCierre.Image")));
            this.btnCierre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCierre.Location = new System.Drawing.Point(38, 332);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(170, 150);
            this.btnCierre.TabIndex = 49;
            this.btnCierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCierre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(516, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 36);
            this.label3.TabIndex = 48;
            this.label3.Text = "Usuarios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn3.Location = new System.Drawing.Point(516, 148);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(170, 150);
            this.btn3.TabIndex = 47;
            this.btn3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(363, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 36);
            this.label2.TabIndex = 46;
            this.label2.Text = "Registrar Movimiento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn2.Location = new System.Drawing.Point(364, 148);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(170, 150);
            this.btn2.TabIndex = 45;
            this.btn2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(211, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.Location = new System.Drawing.Point(211, 148);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(170, 150);
            this.btn1.TabIndex = 43;
            this.btn1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "label9";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 2;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(39, 59);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(170, 150);
            this.btnUsuarios.TabIndex = 61;
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
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
            this.PnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox ptbRestaurar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox prbCerrar;
        private System.Windows.Forms.Panel pnlMenus;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUsuarios;
    }
}