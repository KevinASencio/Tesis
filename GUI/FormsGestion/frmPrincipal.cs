using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.ClientesNeg;
using CapaNegocio.UsuarioNeg;
namespace GUI.FormsGestion
{
    public partial class frmPrincipal : Form
    {
        static UsuarioNeg _useractivo = new UsuarioNeg();
        BindingSource listclientes;
        ClientesNeg clientes;
        int auxancho;
        int auxalto;
        int posicionX;
        int posicionY;
        public frmPrincipal()
        {
            listclientes = new BindingSource();
            clientes = new ClientesNeg();
            InitializeComponent();
        }

        public static UsuarioNeg useractivo { get => _useractivo; set => _useractivo = value; }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            //pnlMenus.Visible = false;
           btnUsuarios.Margin = new Padding(0, Convert.ToInt32(PnlPrincipal.Height * .21), 0, Convert.ToInt32(PnlPrincipal.Height * .21));



        }

        private void GestionClientes_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void GestionClientes_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void GestionClientes_SizeChanged(object sender, EventArgs e)
        {
            CalTamaño();
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

        //recalcular el tamaño de los paneles y el area para mostrar la pantalla principal

        public void CalTamaño() 
        {
            pnlMenus.Size = new Size(Convert.ToInt32(this.Width * .25), this.Height);

            btnUsuarios.Margin = new Padding(0, Convert.ToInt32(PnlPrincipal.Height*.21),0, Convert.ToInt32(PnlPrincipal.Height * .21));
            btnCierre.Margin = new Padding(0, Convert.ToInt32(PnlPrincipal.Height * .21), 0, Convert.ToInt32(PnlPrincipal.Height * .21));

            btnUsuarios.Update();
            MessageBox.Show("margen alto " + btnUsuarios.Margin.Top + " ññ" + btnUsuarios.Margin.Left);

            //label1.Text = "el ancho de la pantlla es" + this.Width.ToString() + "el ancho del panel es==" + pnlMargen.Width.ToString();
        }
    }
}
