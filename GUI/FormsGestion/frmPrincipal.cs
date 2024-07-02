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
          /*  btn1.Location = new Point(0, 0);
            btn1.Update();*/
            //pnlMenus.Visible = false;

            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, 2);
            //Pos(211 + PnlPrincipal.Width, PnlPrincipal.Height, 2, btn1);
            /*Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn2);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn3);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn4);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn5);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btn6);
            Pos(PnlPrincipal.Width, PnlPrincipal.Height, 4, btnCierre);*/
            label8.Text = "Left ->" + btnUsuarios.Margin.Left + "************ Top ->" + btnUsuarios.Margin.Top +
                "*********right ->" + btnUsuarios.Margin.Right + "***********down -> " + btnUsuarios.Margin.Bottom;
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

        //recalcular el tamaño de los paneles y el area para mostrar la pantalla principal
        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("si funciona la mierda");
        }

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
    }
}
