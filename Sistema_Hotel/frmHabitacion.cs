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
    public partial class frmHabitacion : Form
    {
        string alternativa;
        public frmHabitacion()
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                var h = ObtenerDatosFormulario();

            if (alternativa == "Agregar")
            {
                Habitacion.AgregarHabitacion(h);
            }

            else if (alternativa == "Actualizar")
            {
                if (this.lstHabitacion.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para poder");
                }

                else
                {
                    int indice = lstHabitacion.SelectedIndex;
                    Habitacion.ActualizarHabitacion(h, indice);
                    ActualizarListaHabitaciones();
                }

            }
            LimpiarFormulario();
            ActualizarListaHabitaciones();
            BloquearFormulario();
            }
        }



        private void LimpiarFormulario()
        {
            txtCodHabitacion.Text = "";
            txtNroHabitacion.Text = "";
            cboEstadoHabitacion.SelectedItem = null;
            txtCostoHabitacion.Text = "";
            cboTipoHabitacion.SelectedItem = null;
            txtDescripcionHabitacion.Text = "";
        }



        private void BloquearFormulario()
        {
            txtCodHabitacion.Enabled = false;
            txtNroHabitacion.Enabled = false;
            cboEstadoHabitacion.Enabled = false;
            txtCostoHabitacion.Enabled = false;
            cboTipoHabitacion.Enabled = false;
            txtDescripcionHabitacion.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            lstHabitacion.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }



        private Habitacion ObtenerDatosFormulario()
        {
            Habitacion habitacion = new Habitacion();
            if (!string.IsNullOrEmpty(txtCodHabitacion.Text))
            {
                habitacion.ID_Habitacion = Convert.ToInt32(txtCodHabitacion.Text);
            }

            habitacion.Numero = Convert.ToInt32(txtNroHabitacion.Text);
            habitacion._Estado_Habitacion = (Estado_Habitacion)cboEstadoHabitacion.SelectedItem;
            habitacion.Costo = Convert.ToDouble(txtCostoHabitacion.Text);
            habitacion._TipoHabitacion = (Tipo_Habitacion)cboTipoHabitacion.SelectedItem;
            habitacion.Descripcion = txtDescripcionHabitacion.Text;

            return habitacion;

        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Actualizar.");
            }

            else
            {
                alternativa = "Actualizar";
                DesbloquearFormulario();
                txtCodHabitacion.Focus();
            }

        }



        private void DesbloquearFormulario()
        {
            txtCodHabitacion.Enabled = true;
            txtNroHabitacion.Enabled = true;
            cboEstadoHabitacion.Enabled = true;
            txtCostoHabitacion.Enabled = true;
            cboTipoHabitacion.Enabled = true;
            txtDescripcionHabitacion.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstHabitacion.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor Selecciones una fila para Eliminar.");
            }

            else
            {
                Habitacion h = (Habitacion)lstHabitacion.SelectedItem;
                Habitacion.EliminarHabitacion(h);
                ActualizarListaHabitaciones();
                LimpiarFormulario();
            }

        }



        private void ActualizarListaHabitaciones()
        {
            lstHabitacion.DataSource = null;
            lstHabitacion.DataSource = Habitacion.ObtenerHabitaciones();
        }



        private void lstHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion h = (Habitacion)lstHabitacion.SelectedItem;

            if (h != null)
            {
                txtCodHabitacion.Text = Convert.ToString(h.ID_Habitacion);
                txtNroHabitacion.Text = Convert.ToString(h.Numero);
                //cboEstadoHabitacion.SelectedItem = Convert.ToString(h._Estado_Habitacion);
                cboEstadoHabitacion.SelectedItem = (Estado_Habitacion)Estado_Habitacion.ObtenerEsHabitacion(h._Estado_Habitacion.ID_EstadoHabitacion);
                txtCostoHabitacion.Text = Convert.ToString(h.Costo);
                cboTipoHabitacion.SelectedItem = (Tipo_Habitacion)Tipo_Habitacion.ObtenerThabitacion(h._TipoHabitacion.ID_TipoHabitacion);
                txtDescripcionHabitacion.Text = h.Descripcion;

            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }



        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            ActualizarListaHabitaciones();
            cboEstadoHabitacion.DataSource = Estado_Habitacion.ObtenerEstadoHabitacion();
            cboTipoHabitacion.DataSource = Tipo_Habitacion.ObtenerTipoHabitaciones();
            BloquearFormulario();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            alternativa = "Agregar";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtCodHabitacion.Focus();
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

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            frmListado_Habitaciones frmlistadoregistradores = new frmListado_Habitaciones();
            frmlistadoregistradores.Show();
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNroHabitacion.Text))
            {
                MessageBox.Show("Ingrese el Número de Habitación.", "Mantenimiento de Habitaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroHabitacion.Focus();
                return false;
            }

            var eh = (Estado_Habitacion)cboEstadoHabitacion.SelectedItem;
            if (eh == null)
            {
                MessageBox.Show("Seleccione el Estado Habitación.", "Mantenimiento de Habitaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstadoHabitacion.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtCostoHabitacion.Text))
            {
                MessageBox.Show("Ingrese el Costo.", "Mantenimiento de Habitaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostoHabitacion.Focus();
                return false;
            }

            if (cboTipoHabitacion.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el Tipo Habitación.", "Mantenimiento de Habitaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoHabitacion.Focus();
                return false;
            }

       
            if (String.IsNullOrWhiteSpace(txtDescripcionHabitacion.Text))
            {
                MessageBox.Show("Escriba una breve Descripción.", "Mantenimiento de Habitaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionHabitacion.Focus();
                return false;
            }

            return true;
        }

        private void txtNroHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtCostoHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Globalization.CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (Char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}

