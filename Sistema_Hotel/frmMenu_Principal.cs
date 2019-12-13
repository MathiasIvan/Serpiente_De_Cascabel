using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistema_Hotel
{
    public partial class frmMenu_Principal : Form
    {
        public frmMenu_Principal()
        {
            InitializeComponent();

            //Agregamos una imagen de fondo al formulario.
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\Imagen\wallhaven-6q9xkl.jpg");
            this.BackgroundImage = imagen;

            //Hacemos que la imagen se ajuste al tamaño del formulario.
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion

        private void pictMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictMazimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictMazimizar.Visible = false;
            pictRestaurar.Visible = true;
        }

        private void pictSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictRestaurar.Visible = false;
            pictMazimizar.Visible = true;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.Show();           
        }

        private void pictEstadoHabitacion_Click(object sender, EventArgs e)
        {
            frmEstadoHabitacion frmestadohabitacion = new frmEstadoHabitacion();
            frmestadohabitacion.Show();
        }

        private void pictTipoHabitacion_Click(object sender, EventArgs e)
        {
            frmTipoHabitacion frmtipohabitacion = new frmTipoHabitacion();
            frmtipohabitacion.Show();
        }

        private void pictRegistrador_Click(object sender, EventArgs e)
        {
            frmRegistrador frmregistrador = new frmRegistrador();
            frmregistrador.Show();

        }

        private void pictHabitacion_Click(object sender, EventArgs e)
        {
            frmHabitacion frmhabitacion = new frmHabitacion();
            frmhabitacion.Show();
        }

        private void pictGastos_Click(object sender, EventArgs e)
        {
            frmGastos frmgastos = new frmGastos();
            frmgastos.Show();
        }

        private void pictReserva_Click(object sender, EventArgs e)
        {
            frmReserva frmreserva = new frmReserva();
            frmreserva.Show();
        }

        private void mnsMoverFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void pictCrearUsuario_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmcrearusuario = new frmCrearUsuario();
            frmcrearusuario.Show();
        }
    }
}
