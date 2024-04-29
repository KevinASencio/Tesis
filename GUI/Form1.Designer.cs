namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Contenedor = new System.Windows.Forms.Panel();
            this.btnAbrirClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedor.Location = new System.Drawing.Point(351, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(732, 625);
            this.Contenedor.TabIndex = 0;
            // 
            // btnAbrirClientes
            // 
            this.btnAbrirClientes.Location = new System.Drawing.Point(86, 114);
            this.btnAbrirClientes.Name = "btnAbrirClientes";
            this.btnAbrirClientes.Size = new System.Drawing.Size(217, 34);
            this.btnAbrirClientes.TabIndex = 1;
            this.btnAbrirClientes.Text = "Clientes";
            this.btnAbrirClientes.UseVisualStyleBackColor = true;
            this.btnAbrirClientes.Click += new System.EventHandler(this.btnAbrirClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 623);
            this.Controls.Add(this.btnAbrirClientes);
            this.Controls.Add(this.Contenedor);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Button btnAbrirClientes;
    }
}

