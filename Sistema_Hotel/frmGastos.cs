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
    public partial class frmGastos : Form
    {
        string alternativa;
        public frmGastos()
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

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            var g = ObtenerDatosFormulario();


            if (alternativa == "Agregar")
            {
                Gastos.AgregarGasto(g);
            }
            else if (alternativa == "Actualizar")
            {

                if (this.lstGastos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para Acualizar.");
                }

                else
                {
                    int indice = lstGastos.SelectedIndex;
                    Gastos.ActualizarGasto(g, indice);
                    ActualizarListaGastos();
                }

            }

            LimpiarFormulario();
            ActualizarListaGastos();
            BloquearFormulario();
        }

       

        private Gastos ObtenerDatosFormulario()
        {
            Gastos gasto = new Gastos();
            if (!string.IsNullOrEmpty(txtCodGasto.Text))
            {
                gasto.ID_Gasto = Convert.ToInt32(txtCodGasto.Text);
            }

            gasto.ID_Reserva_Gasto = (Reserva)cboReservaGasto.SelectedItem;
            gasto.Servicio = (Servicios)cboServicioGasto.SelectedItem;
            gasto.FechaGasto = dtpFechaGasto.Value.Date;
            gasto.Cantidad = txtCantidadGasto.Text;
            gasto.CostoTotalGasto = Convert.ToDouble(txtCostoTotalGasto.Text);

            return gasto;

        }


        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (this.lstGastos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Actualizar");
            }
            else
            {
                alternativa = "Actualizar";
                DesbloquearFormulario();
                txtCodGasto.Focus();
            }
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.lstGastos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para Eliminar.");
            }
            else
            {
                Gastos g = (Gastos)lstGastos.SelectedItem;
                Gastos.EliminarGasto(g);
                ActualizarListaGastos();
                LimpiarFormulario();
            }
        }

   
        private void BloquearFormulario()
        {
            txtCodGasto.Enabled = false;
            cboReservaGasto.Enabled = false;
            cboServicioGasto.Enabled = false;
            dtpFechaGasto.Enabled = false;
            txtCantidadGasto.Enabled = false;
            txtCostoTotalGasto.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            lstGastos.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        private void DesbloquearFormulario()
        {
            txtCodGasto.Enabled = true;
            cboReservaGasto.Enabled = true;
            cboServicioGasto.Enabled = true;
            dtpFechaGasto.Enabled = true;
            txtCantidadGasto.Enabled = true;
            txtCostoTotalGasto.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstGastos.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            txtCodGasto.Text = "";
            cboReservaGasto.SelectedItem = null;
            cboServicioGasto.SelectedItem = null;
            dtpFechaGasto.Value = DateTime.Now;
            txtCantidadGasto.Text = "";
            txtCostoTotalGasto.Text = "";
        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
            ActualizarListaGastos();
            cboServicioGasto.DataSource = Enum.GetValues(typeof(Servicios));
            cboReservaGasto.DataSource = Reserva.ObtenerReservas();

            cboServicioGasto.SelectedItem = null;
            cboReservaGasto.SelectedItem = 1;

            BloquearFormulario();
        }

        private void ActualizarListaGastos()
        {
            lstGastos.DataSource = null;
            lstGastos.DataSource = Gastos.ObtenerGastos();
        }

        private void lstGastos_Click(object sender, EventArgs e)
        {
            Gastos g = (Gastos)lstGastos.SelectedItem;

            if (g != null)
            {
                txtCodGasto.Text = g.ID_Gasto.ToString();
                cboReservaGasto.SelectedItem = g.ID_Reserva_Gasto;
                cboServicioGasto.SelectedItem = g.Servicio;
                dtpFechaGasto.Value = g.FechaGasto;
                txtCantidadGasto.Text = g.Cantidad;
                txtCostoTotalGasto.Text = g.CostoTotalGasto.ToString();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

       
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }



        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }



        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            alternativa = "Agregar";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtCodGasto.Focus();
        }

        private void mnsMoverFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            frmListado_Gastos frmlistadogastos = new frmListado_Gastos();
            frmlistadogastos.Show();
        }
    }

}


