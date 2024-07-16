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
        internal static frmPrincipal fr;
        #region declaracion formilarios
        frmVistaClientes _frmVistaCliente;
        frmGestionClientes _frmGestionClientes;
        #endregion

        static UsuarioNeg _useractivo = new UsuarioNeg();
        int auxancho;
        int auxalto;
        int posicionX;
        int posicionY;
        public frmPrincipal()
        {

            InitializeComponent();
            fr = this;
        }

        private void AbrirEnContenedor(object frm)
        {
            if (this.PnlPrincipal.Controls.Count > 1)
            {
                this.PnlPrincipal.Controls.RemoveAt(0);
                //this.PnlPrincipal.Controls.Clear();
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

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            OrganizadorObj.Organizar(4, 2, pnlBotones, btnClientes.GetType());
            OrganizadorObj.ocuktar(pnlMenus, pnlMenuDetalles);
            OrganizadorObj.ocuktar(pnlMenus, pnlAcciones);
            OrganizadorObj.mostrar(pnlMenus, pnlMenuInicio);
            OrganizadorObj.Organizar(1, 6, pnlMenuInicio, btnUsuarios.GetType());
        }

        private void GestionClientes_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void GestionClientes_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void GestionClientes_SizeChanged(object sender, EventArgs e)
        {
            OrganizadorObj.Organizar( 4, 2, pnlBotones, btnClientes.GetType());
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
        
        private void btnClientes_Click(object sender, EventArgs e)
        {
            _frmVistaCliente = new frmVistaClientes();
            AbrirEnContenedor(_frmVistaCliente);
            OrganizadorObj.ocuktar(pnlMenus, pnlMenuInicio);
            OrganizadorObj.ocuktar(pnlMenus, pnlAcciones);
            OrganizadorObj.mostrar(pnlMenus, pnlMenuDetalles);
        }

        private void pnlBotones_Enter(object sender, EventArgs e)
        {
            
        }

        private void PnlPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            pnlMenuDetalles.Visible = false;
            pnlMenuInicio.Enabled = true;
            pnlMenus.Controls.Add(pnlMenuInicio);
            pnlMenuInicio.Dock = DockStyle.Fill;
            pnlMenuInicio.Visible = true;
            pnlMenuInicio.BringToFront();
            pnlMenuInicio.Update();
            pnlMenuDetalles.Update();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _frmVistaCliente.Editar();
            OrganizadorObj.ocuktar(pnlMenus, pnlMenuInicio);
            OrganizadorObj.ocuktar(pnlMenus, pnlMenuDetalles);
            OrganizadorObj.mostrar(pnlMenus, pnlAcciones);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmGestionClientes.frmgc.procesar();
        }
    }
}
