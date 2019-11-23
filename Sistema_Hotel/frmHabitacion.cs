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

namespace Sistema_Hotel
{
    public partial class frmHabitacion : Form
    {
        string alternativa;
        public frmHabitacion()
        {
            InitializeComponent();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
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
            habitacion.Id_EstadoHabitacion = (Estado_Habitacion)cboEstadoHabitacion.SelectedItem;
            habitacion.Costo = Convert.ToDouble(txtCostoHabitacion.Text);
            habitacion.Id_TipoHabitacion = (Tipo_Habitacion)cboTipoHabitacion.SelectedItem;
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
                cboEstadoHabitacion.SelectedItem = Convert.ToString(h.Id_EstadoHabitacion);
                txtCostoHabitacion.Text = Convert.ToString(h.Costo);
                cboTipoHabitacion.SelectedItem = Convert.ToString(h.Id_TipoHabitacion);
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

            //cboEstadoHabitacion.SelectedIndex = null;
            //cboTipoHabitacion.SelectedIndex = null;
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

    }
}

