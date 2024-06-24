using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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

            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btnUsuarios);
            Pos(211+PnlPrincipal.Width, PnlPrincipal.Height, 4, btn1);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn2);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn3);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn4);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn5);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn6);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btnCierre);
            label8.Text= "Left ->" + btnUsuarios.Margin.Left + "************ Top ->" + btnUsuarios.Margin.Top +
                "*********right ->" + btnUsuarios.Margin.Right + "***********down -> " + btnUsuarios.Margin.Bottom;
        }

        private void GestionClientes_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void GestionClientes_ResizeEnd(object sender, EventArgs e)
        {
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btnUsuarios);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn1);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn2);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn3);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn4);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn5);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn6);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btnCierre);
            label8.Text = "Left ->" + btnUsuarios.Margin.Left + "************ Top ->" + btnUsuarios.Margin.Top +
                "*********right ->" + btnUsuarios.Margin.Right + "***********down -> " + btnUsuarios.Margin.Bottom;
        }

        private void GestionClientes_SizeChanged(object sender, EventArgs e)
        {
            //CalTamaño();
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

            btn1.Margin = new Padding(0, Convert.ToInt32(PnlPrincipal.Height * .50), 0, Convert.ToInt32(PnlPrincipal.Height * .21));
            btnCierre.Margin = new Padding(0, Convert.ToInt32(PnlPrincipal.Height * .21), 0, Convert.ToInt32(PnlPrincipal.Height * .21));

            btn1.Update();

            //label1.Text = "el ancho de la pantlla es" + this.Width.ToString() + "el ancho del panel es==" + pnlMargen.Width.ToString();
        }


        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("si funciona la mierda");
        }

        public void Pos(int x, int y, int cantidad, object obj)
        {
            System.Windows.Forms.Control control = obj as System.Windows.Forms.Control;
            control.Location = new Point(control.Location.X+ Convert.ToInt32((x - (control.Width * cantidad)) / cantidad), control.Location.Y+ Convert.ToInt32((y - (control.Height * 2)) / cantidad));
            //control.Margin = new Padding(+200, Convert.ToInt32((y - (control.Height*2)) / cantidad), 0,0);
            control.BackColor = Color.Aqua;
            control.Update();
            label9.Text = "Left ->" + control.Margin.Left + "************ Top ->" + control.Margin.Top +
                "*********right ->" + control.Margin.Right + "***********down -> " + control.Margin.Bottom;
        }
    }
}
