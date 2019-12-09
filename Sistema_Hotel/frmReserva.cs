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
    public partial class frmReserva : Form
    {
        string alternativa;
        public frmReserva()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var rs = ObtenerDatosFormulario();


            if (alternativa == "Agregar")
            {
                Reserva.AgregarReserva(rs);
            }
            else if (alternativa == "Actualizar")
            {

                if (this.lstReserva.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para Actualizar.");
                }

                else
                {
                    int indice = lstReserva.SelectedIndex;
                    Reserva.ActualizarReserva(rs, indice);
                    ActualizarListaReservas();
                }
            }

            LimpiarFormulario();
            ActualizarListaReservas();
            BloquearFormulario();
        }

        private Reserva ObtenerDatosFormulario()
        {

            Reserva reserva = new Reserva();
            if (!string.IsNullOrEmpty(txtCodReserva.Text))
            {
                reserva.ID_Reserva = Convert.ToInt32(txtCodReserva.Text);
            }

            if (this.dtpFechaHoraEntradaReserva.Value.CompareTo(this.dtpFechaHoraSalidaReserva.Value)==1)
            {
                MessageBox.Show("La Fecha de Salida no puede ser mayor a la Fecha de Entrada.");
            }

            reserva.FechaHoraEntrada = dtpFechaHoraEntradaReserva.Value.Date;
            reserva.FechaHoraSalida = dtpFechaHoraSalidaReserva.Value.Date;
            reserva.Id_Habitacion = (Habitacion)cboHabitacionReserva.SelectedItem;
            reserva.Id_Cliente = (Cliente)cboClienteReserva.SelectedItem;
            reserva.Id_Registrador = (Registrador)cboRegistradorReserva.SelectedItem;
            reserva.CostoTotal = Convert.ToDouble(txtCostoTotalReserva.Text);
            reserva.Observacion = txtObservacionReserva.Text;

            return reserva;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstReserva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Actualizar.");
            }
            else
            {
                alternativa = "Actualizar";
                DesbloquearFormulario();
                txtCodReserva.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstReserva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Eliminar.");
            }
            else
            {
                Reserva rs = (Reserva)lstReserva.SelectedItem;
                Reserva.EliminarReserva(rs);
                ActualizarListaReservas();
                LimpiarFormulario();
            }
        }

        private void lstReserva_Click(object sender, EventArgs e)
        {
            Reserva rs = (Reserva)lstReserva.SelectedItem;

            if (rs != null)
            {
                txtCodReserva.Text = rs.ID_Reserva.ToString();
                dtpFechaHoraEntradaReserva.MinDate = rs.FechaHoraEntrada;
                dtpFechaHoraSalidaReserva.MinDate = rs.FechaHoraSalida;
                cboHabitacionReserva.SelectedItem = rs.Id_Habitacion.ToString(); 
                cboClienteReserva.SelectedItem = rs.Id_Cliente.ToString(); 
                cboRegistradorReserva.SelectedItem = rs.Id_Registrador.ToString(); 
                txtCostoTotalReserva.Text = rs.CostoTotal.ToString();
                txtObservacionReserva.Text = rs.Observacion;
            }
        }

        private void ActualizarListaReservas()
        {
            lstReserva.DataSource = null;
            lstReserva.DataSource = Reserva.ObtenerReservas();
        }


        private void LimpiarFormulario()
        {
            txtCodReserva.Text = "";
            dtpFechaHoraEntradaReserva.Value = DateTime.Now;
            dtpFechaHoraSalidaReserva.Value = DateTime.Now;
            cboHabitacionReserva.SelectedItem = null;
            cboClienteReserva.SelectedItem = null;
            cboRegistradorReserva.SelectedItem = null;
            txtCostoTotalReserva.Text = "";
            txtObservacionReserva.Text = "";
        }


        private void BloquearFormulario()
        {
            txtCodReserva.Enabled = false;
            dtpFechaHoraEntradaReserva.Enabled = false;
            dtpFechaHoraSalidaReserva.Enabled = false;
            cboHabitacionReserva.Enabled = false;
            cboClienteReserva.Enabled = false;
            cboRegistradorReserva.Enabled = false;
            txtCostoTotalReserva.Enabled = false;
            txtObservacionReserva.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void DesbloquearFormulario()
        {
            txtCodReserva.Enabled = true;
            dtpFechaHoraEntradaReserva.Enabled = true;
            dtpFechaHoraSalidaReserva.Enabled = true;
            cboHabitacionReserva.Enabled = true;
            cboClienteReserva.Enabled = true;
            cboRegistradorReserva.Enabled = true;
            txtCostoTotalReserva.Enabled = true;
            txtObservacionReserva.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {

            ActualizarListaReservas();

            cboHabitacionReserva.DataSource = Habitacion.ObtenerHabitaciones();
            cboClienteReserva.DataSource = Cliente.ObtenerClientes();
            cboRegistradorReserva.DataSource = Registrador.ObtenerRegistradores();

            cboHabitacionReserva.SelectedItem = null;
            cboClienteReserva.SelectedItem = null;
            cboRegistradorReserva.SelectedItem = null;

            BloquearFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            alternativa = "Agregar";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtCodReserva.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dtpFechaHoraSalidaReserva_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaHoraSalidaReserva.Value.Date < dtpFechaHoraEntradaReserva.Value.Date)
            {
                MessageBox.Show("La Fecha de Salida no puede ser menor a la Fecha de Entrada.");
                dtpFechaHoraSalidaReserva.Focus();
            }
        }
    }
}
