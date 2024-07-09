using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.UsuarioNeg;
using GUI.Clases;
namespace GUI.FormsGestion
{
    public partial class frmPrincipal : Form
    {
        #region declaracion formilarios
        frmVistaClientes frmVistaCliente = new frmVistaClientes();
        #endregion

        static UsuarioNeg _useractivo = new UsuarioNeg();
        BindingSource listclientes;
        int auxancho;
        int auxalto;
        int posicionX;
        int posicionY;
        public frmPrincipal()
        {
          
            InitializeComponent();
        }

        private void AbrirEnContenedor(object frm)
        {
            if (this.PnlPrincipal.Controls.Count > 1)
            {
                this.PnlPrincipal.Controls.RemoveAt(0);
            }
            Form aux = frm as Form;
            aux.TopLevel = false;
            aux.Dock = DockStyle.Fill;
            this.PnlPrincipal.Controls.Add(aux);
            this.PnlPrincipal.Tag = aux;
            aux.BringToFront();
            aux.Show();
        }

        public static UsuarioNeg useractivo { get => _useractivo; set => _useractivo = value; }
        #region botones control del formulario
        private void GestionClientes_Load(object sender, EventArgs e)
        {
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, 2);
        }

        private void GestionClientes_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void GestionClientes_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void GestionClientes_SizeChanged(object sender, EventArgs e)
        {
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, 2);
        }
        #region funciones de los botones para el control de la ventana
        private void prbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(auxancho, auxalto);
            this.Location = new Point(posicionX, posicionY);
            ptbMaximizar.Visible = true;
            ptbRestaurar.Visible = false;
        }

        private void ptbMaximizar_Click(object sender, EventArgs e)
        {
            //obtener el tamaño y la posicion para usarlos en la accion de restaurar pantalla
            posicionY = this.Location.Y;
            posicionX = this.Location.X;
            auxancho = this.Size.Width;
            auxalto = this.Size.Height;
            ptbMaximizar.Visible = false;
            ptbRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #endregion
        public void Pos(int x, int y, int cantx, int canty)
        {
            int PosX = 0, PosY = 0;
            Int16 cont = 0;
            Int16 linea = 0;
            #region posicionar los botones
            foreach (System.Windows.Forms.Control cr in PnlPrincipal.Controls)
            {
                try
                {
                    System.Windows.Forms.Panel btn = (System.Windows.Forms.Panel)cr;
                    PosX = (PnlPrincipal.Width - btn.Width * cantx) / (cantx + 1);
                    PosY = (PnlPrincipal.Height - btn.Height * canty) / (canty + 1);
                    if (cont < canty)
                    {
                        btn.Location = new Point((btn.Width * cont) + PosX * (cont + 1), (btn.Height * linea) + PosY * (linea + 1));
                    }
                    else
                    {
                        btn.Location = new Point((btn.Width * cont) + PosX * (cont + 1), (btn.Height * linea) + PosY * (linea + 1));
                    }
                    btn.Update();
                    if (cont >= cantx - 1) { cont = 0; linea++; } else { cont++; };

                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }
            #endregion
            
        }

        private void PnlPrincipal_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarFac_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.Update();
        }

        private void btnGenerarFac_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            label4.BackColor = Color.Transparent;
            label4.Update();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirEnContenedor(frmVistaCliente);
        }
    }
}
