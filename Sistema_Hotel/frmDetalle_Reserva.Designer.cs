namespace Sistema_Hotel
{
    partial class frmDetalle_Reserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipoHabitacionDetalleReserva = new System.Windows.Forms.Label();
            this.cboTipoHabitacionDetalleReserva = new System.Windows.Forms.ComboBox();
            this.dgvDetalleReserva = new System.Windows.Forms.DataGridView();
            this.lblFechaDetalleReserva = new System.Windows.Forms.Label();
            this.dtpFechaDetalleReserva = new System.Windows.Forms.DateTimePicker();
            this.lblClienteDetalleReserva = new System.Windows.Forms.Label();
            this.cboClienteDetalleReserva = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(417, 412);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 27);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Detalle";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(254, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(147, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTipoHabitacionDetalleReserva
            // 
            this.lblTipoHabitacionDetalleReserva.AutoSize = true;
            this.lblTipoHabitacionDetalleReserva.Location = new System.Drawing.Point(27, 88);
            this.lblTipoHabitacionDetalleReserva.Name = "lblTipoHabitacionDetalleReserva";
            this.lblTipoHabitacionDetalleReserva.Size = new System.Drawing.Size(88, 13);
            this.lblTipoHabitacionDetalleReserva.TabIndex = 35;
            this.lblTipoHabitacionDetalleReserva.Text = "Tipo Habitación: ";
            // 
            // cboTipoHabitacionDetalleReserva
            // 
            this.cboTipoHabitacionDetalleReserva.FormattingEnabled = true;
            this.cboTipoHabitacionDetalleReserva.Items.AddRange(new object[] {
            "Vacuna",
            "Porcina"});
            this.cboTipoHabitacionDetalleReserva.Location = new System.Drawing.Point(121, 84);
            this.cboTipoHabitacionDetalleReserva.Name = "cboTipoHabitacionDetalleReserva";
            this.cboTipoHabitacionDetalleReserva.Size = new System.Drawing.Size(121, 21);
            this.cboTipoHabitacionDetalleReserva.TabIndex = 30;
            // 
            // dgvDetalleReserva
            // 
            this.dgvDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleReserva.Location = new System.Drawing.Point(32, 209);
            this.dgvDetalleReserva.Name = "dgvDetalleReserva";
            this.dgvDetalleReserva.Size = new System.Drawing.Size(451, 198);
            this.dgvDetalleReserva.TabIndex = 33;
            // 
            // lblFechaDetalleReserva
            // 
            this.lblFechaDetalleReserva.AutoSize = true;
            this.lblFechaDetalleReserva.Location = new System.Drawing.Point(27, 15);
            this.lblFechaDetalleReserva.Name = "lblFechaDetalleReserva";
            this.lblFechaDetalleReserva.Size = new System.Drawing.Size(40, 13);
            this.lblFechaDetalleReserva.TabIndex = 32;
            this.lblFechaDetalleReserva.Text = "Fecha:";
            // 
            // dtpFechaDetalleReserva
            // 
            this.dtpFechaDetalleReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDetalleReserva.Location = new System.Drawing.Point(74, 12);
            this.dtpFechaDetalleReserva.Name = "dtpFechaDetalleReserva";
            this.dtpFechaDetalleReserva.Size = new System.Drawing.Size(282, 20);
            this.dtpFechaDetalleReserva.TabIndex = 27;
            // 
            // lblClienteDetalleReserva
            // 
            this.lblClienteDetalleReserva.AutoSize = true;
            this.lblClienteDetalleReserva.Location = new System.Drawing.Point(27, 53);
            this.lblClienteDetalleReserva.Name = "lblClienteDetalleReserva";
            this.lblClienteDetalleReserva.Size = new System.Drawing.Size(39, 13);
            this.lblClienteDetalleReserva.TabIndex = 28;
            this.lblClienteDetalleReserva.Text = "Cliente";
            // 
            // cboClienteDetalleReserva
            // 
            this.cboClienteDetalleReserva.FormattingEnabled = true;
            this.cboClienteDetalleReserva.Location = new System.Drawing.Point(72, 50);
            this.cboClienteDetalleReserva.Name = "cboClienteDetalleReserva";
            this.cboClienteDetalleReserva.Size = new System.Drawing.Size(284, 21);
            this.cboClienteDetalleReserva.TabIndex = 29;
            // 
            // frmDetalle_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(597, 506);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTipoHabitacionDetalleReserva);
            this.Controls.Add(this.cboTipoHabitacionDetalleReserva);
            this.Controls.Add(this.dgvDetalleReserva);
            this.Controls.Add(this.lblFechaDetalleReserva);
            this.Controls.Add(this.dtpFechaDetalleReserva);
            this.Controls.Add(this.lblClienteDetalleReserva);
            this.Controls.Add(this.cboClienteDetalleReserva);
            this.Name = "frmDetalle_Reserva";
            this.Text = "Detalle / Reserva";
            //this.Load += new System.EventHandler(this.frmDetalle_Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTipoHabitacionDetalleReserva;
        private System.Windows.Forms.ComboBox cboTipoHabitacionDetalleReserva;
        private System.Windows.Forms.DataGridView dgvDetalleReserva;
        private System.Windows.Forms.Label lblFechaDetalleReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaDetalleReserva;
        private System.Windows.Forms.Label lblClienteDetalleReserva;
        private System.Windows.Forms.ComboBox cboClienteDetalleReserva;
    }
}