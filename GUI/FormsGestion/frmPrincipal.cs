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
using GUI.FormsProcesos;
namespace GUI.FormsGestion
{
    public partial class frmPrincipal : Form
    {
        internal static frmPrincipal fr;
        #region declaracion formilarios
        frmVistaClientes _frmVistaCliente;
        frmGestionClientes _frmGestionClientes;
        frmVistaUsuarios _frmVistaUsuarios;
        frmVistaServicios _frmVistaServicios;
        FrmCrearFacturas _frmCrearFacturas;
        frmMovimientos _frmMovimientos;
        #endregion

        static UsuarioNeg _useractivo = new UsuarioNeg();
        static string formCall;
        int auxancho;
        int auxalto;
        int posicionX;
        int posicionY;
        public frmPrincipal()
        {

            InitializeComponent();
            fr = this;
        }

        public static UsuarioNeg useractivo { get => _useractivo; set => _useractivo = value; }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _useractivo.nombres();
            lblRol.Text = _useractivo.rol();
            OrganizadorObj.Organizar(4, 2, pnlBotones, btnClientes.GetType());
            OrganizadorObj.ocultar(pnlMenus, pnlMenuDetalles);
            OrganizadorObj.mostrar(pnlMenus, pnlMenuInicio);
            OrganizadorObj.Organizar(1, 6, pnlMenuInicio, btnUsuarios.GetType());
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
            OrganizadorObj.Organizar(4, 2, pnlBotones, btnClientes.GetType());
            pnlBotones.Refresh();
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
            formCall = "clientes";
            OrganizadorObj.abrirCont(_frmVistaCliente);
            OrganizadorObj.ocultar(pnlMenus, pnlMenuInicio);
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
            switch (formCall)
            {
                case "clientes":
                    _frmVistaCliente.Editar();
                    break;
                case "usuarios":
                    _frmVistaUsuarios.Editar();
                    break;
                default: break;
            }
        }

        private void btnCobro_Click(object sender, EventArgs e)
        {
            OrganizadorObj.abrirCont(new frmCobroFacturas());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            formCall = "usuarios";
            this.pnlMenuDetalles.Enabled = true;
            this.pnlMenuDetalles.Controls.Remove(btnServicios);
            this.pnlMenuDetalles.Controls.Remove(btnFacturasU);
            OrganizadorObj.ocultar(this.pnlMenus, this.pnlMenuInicio);
            OrganizadorObj.mostrar(this.pnlMenus, this.pnlMenuDetalles);
            this.pnlMenuDetalles.Refresh();
            _frmVistaUsuarios = new frmVistaUsuarios();
            OrganizadorObj.abrirCont(_frmVistaUsuarios);
        }
        private void btnServicios_Click(object sender, EventArgs e)
        {
            _frmVistaCliente.Servicios();
        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {

            switch (formCall)
            {
                case "clientes":
                    _frmVistaCliente.CambiarEstado();
                    _frmVistaCliente.CargarDatos();
                    break;
                case "usuarios":
                    //_frmVistaUsuarios.();
                    break;
                default: break;
            }
        }

        private void btnGenerarFac_Click(object sender, EventArgs e)
        {
            _frmCrearFacturas = new FrmCrearFacturas();
            OrganizadorObj.abrirCont(_frmCrearFacturas);
            formCall = "crearfacturas";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (formCall)
            {
                case "clientes":
                    _frmVistaCliente.agregar();
                    break;
                case "usuarios":
                    _frmVistaUsuarios.agregar();
                    break;
                default: break;
            }

        }

        private void btnParametro_Click(object sender, EventArgs e)
        {
            switch (btnParametro.Text)
            {
                case "Parametros":
                    PnlPrincipal.Controls.Remove(pnlBotones);
                    PnlPrincipal.Controls.Add(pnlTablasAux);
                    pnlTablasAux.Visible = true;
                    pnlTablasAux.Enabled = true;
                    OrganizadorObj.Organizar(3, 2, pnlTablasAux, btnCuotas.GetType());
                    pnlTablasAux.Dock = DockStyle.Fill;
                    btnParametro.Text = "Inicio";
                    break;
                case "Inicio":
                    PnlPrincipal.Controls.Remove(pnlTablasAux);
                    PnlPrincipal.Controls.Add(pnlBotones);
                    pnlTablasAux.Visible = false;
                    pnlTablasAux.Enabled = false;
                    pnlTablasAux.Dock = DockStyle.Fill;
                    btnParametro.Text = "Parametros";
                    break;
            }
            
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            _frmMovimientos = new frmMovimientos();
            OrganizadorObj.abrirCont(_frmMovimientos);
        }

        private void btnFacturasU_Click(object sender, EventArgs e)
        {
            _frmVistaCliente.AbrirFactuasCliente();
        }

        private void btnCuotasConsumno_Click(object sender, EventArgs e)
        {
            frmGestionCuotas frm = new frmGestionCuotas();
            OrganizadorObj.abrirCont(frm);
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            OrganizadorObj.Organizar(4, 2, pnlBotones, btnClientes.GetType());
            OrganizadorObj.Organizar(3, 2, pnlTablasAux, btnCuotas.GetType());
        }
    }
}
