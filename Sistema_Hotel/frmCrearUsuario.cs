using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Hotel;
using System.Runtime.InteropServices;

namespace Sistema_Hotel
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario.CrearUsuario(txtUsuario.Text, txtContraseña.Text);

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Nombre de Usuario.");
                txtUsuario.Focus();
            }

            if(txtContraseña.Text == "")
            {
                MessageBox.Show("Debe Digirar una Contraseña.");
                txtContraseña.Focus();
            }

            else
	        {
                MessageBox.Show("Usuario creado exitosamente");
            }
           
        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnsMoverFormulario_MouseDown(object sender, MouseEventArgs e)
        {

            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }
    }
}
