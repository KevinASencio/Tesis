namespace GUI
{
    partial class pruebainterfas
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
            this.pnlprueba = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlprueba
            // 
            this.pnlprueba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlprueba.Location = new System.Drawing.Point(0, 0);
            this.pnlprueba.Name = "pnlprueba";
            this.pnlprueba.Size = new System.Drawing.Size(800, 450);
            this.pnlprueba.TabIndex = 0;
            // 
            // pruebainterfas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlprueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pruebainterfas";
            this.Text = "pruebainterfas";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlprueba;
    }
}