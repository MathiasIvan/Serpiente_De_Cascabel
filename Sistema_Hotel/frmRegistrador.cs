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
    public partial class frmRegistrador : Form
    {
        string alternativa;
        public frmRegistrador()
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

        private void frmRegistrador_Load(object sender, EventArgs e)
        {
            ActualizarListaRegistradores();
            BloquearFormulario();
            
        }


        private void lstRegistrador_Click(object sender, EventArgs e)
        {
            Registrador r = (Registrador)lstRegistrador.SelectedItem;

            if (r != null)
            {
                txtCodRegistrador.Text = r.ID_Registrador.ToString();
                txtNombreRegistrador.Text = r.Nombre;
                txtDireccionRegistrador.Text = r.Direccion;
                txtTelefonoRegistrador.Text = r.Telefono;
                txtNroDocumentoRegistrador.Text = r.NroDocumento;
                txtObservacionRegistrador.Text = r.Observacion;
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var r = ObtenerDatosFormulario();

            if (alternativa == "Agregar")
            {
                Registrador.AgregarRegistrador(r);
            }

            else if (alternativa == "Actualizar")
            {

                if (this.lstRegistrador.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para Actualizar.");
                }

                else
                {
                    int indice = lstRegistrador.SelectedIndex;
                    Registrador.ActualizarRegistrador(r, indice);
                    ActualizarListaRegistradores();
                }

            }

            LimpiarFormulario();
            ActualizarListaRegistradores();
            BloquearFormulario();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            alternativa = "Agregar";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtCodRegistrador.Focus();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstRegistrador.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para Actualizar.");
            }

            else
            {
                alternativa = "Actualizar";
                DesbloquearFormulario();
                txtCodRegistrador.Focus();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstRegistrador.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Eliminar.");
            }

            else
            {
                Registrador r = (Registrador)lstRegistrador.SelectedItem;
                Registrador.EliminarRegistrador(r);
                ActualizarListaRegistradores();
                LimpiarFormulario();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private Registrador ObtenerDatosFormulario()
        {

            Registrador registrador = new Registrador();
            if (!string.IsNullOrEmpty(txtCodRegistrador.Text))
            {
                registrador.ID_Registrador = Convert.ToInt32(txtCodRegistrador.Text);
            }
           
            registrador.Nombre = txtNombreRegistrador.Text;
            registrador.Direccion = txtDireccionRegistrador.Text;
            registrador.Telefono = txtTelefonoRegistrador.Text;
            registrador.NroDocumento = txtNroDocumentoRegistrador.Text;
            registrador.Observacion = txtObservacionRegistrador.Text;

            return registrador;
        }


        private void LimpiarFormulario()
        {
            txtCodRegistrador.Text = "";
            txtNombreRegistrador.Text = "";
            txtDireccionRegistrador.Text = "";
            txtTelefonoRegistrador.Text = "";
            txtNroDocumentoRegistrador.Text = "";
            txtObservacionRegistrador.Text = "";
        }

        private void ActualizarListaRegistradores()
        {
            lstRegistrador.DataSource = null;
            lstRegistrador.DataSource = Registrador.ObtenerRegistradores();
        }


        private void BloquearFormulario()
        {
            txtCodRegistrador.Enabled = false;
            txtNombreRegistrador.Enabled = false;
            txtDireccionRegistrador.Enabled = false;
            txtTelefonoRegistrador.Enabled = false;
            txtNroDocumentoRegistrador.Enabled = false;
            txtObservacionRegistrador.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            lstRegistrador.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        private void DesbloquearFormulario()
        {
            txtCodRegistrador.Enabled = true;
            txtNombreRegistrador.Enabled = true;
            txtDireccionRegistrador.Enabled = true;
            txtTelefonoRegistrador.Enabled = true;
            txtNroDocumentoRegistrador.Enabled = true;
            txtObservacionRegistrador.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstRegistrador.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void mnsMoverFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            frmListado_Registradores frmlistadoregistradores = new frmListado_Registradores();
            frmlistadoregistradores.Show();
        }
    }
}
