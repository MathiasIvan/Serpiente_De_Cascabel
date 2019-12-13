namespace Sistema_Hotel
{
    partial class frmReserva
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstReserva = new System.Windows.Forms.ListBox();
            this.txtObservacionReserva = new System.Windows.Forms.TextBox();
            this.cboRegistradorReserva = new System.Windows.Forms.ComboBox();
            this.cboClienteReserva = new System.Windows.Forms.ComboBox();
            this.dtpFechaHoraEntradaReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHoraSalidaReserva = new System.Windows.Forms.DateTimePicker();
            this.cboHabitacionReserva = new System.Windows.Forms.ComboBox();
            this.txtCodReserva = new System.Windows.Forms.TextBox();
            this.txtCostoTotalReserva = new System.Windows.Forms.TextBox();
            this.lblObservacionReserva = new System.Windows.Forms.Label();
            this.lblCostoTotalReserva = new System.Windows.Forms.Label();
            this.lblRegistradorReserva = new System.Windows.Forms.Label();
            this.lblClienteReserva = new System.Windows.Forms.Label();
            this.lblHabitacionReserva = new System.Windows.Forms.Label();
            this.lblFechaHoraSalidaReserva = new System.Windows.Forms.Label();
            this.lblFechaHoraEntradaReserva = new System.Windows.Forms.Label();
            this.lblCodRerseva = new System.Windows.Forms.Label();
            this.gbxReserva = new System.Windows.Forms.GroupBox();
            this.pictReserva = new System.Windows.Forms.PictureBox();
            this.lblListadoReservas = new System.Windows.Forms.Label();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.gbxReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(728, 505);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 30);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(728, 469);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 30);
            this.btnActualizar.TabIndex = 38;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(728, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 30);
            this.btnAgregar.TabIndex = 37;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(728, 576);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 30);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(103, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(197, 332);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(9, 332);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 30);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstReserva
            // 
            this.lstReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstReserva.FormattingEnabled = true;
            this.lstReserva.Location = new System.Drawing.Point(12, 433);
            this.lstReserva.Name = "lstReserva";
            this.lstReserva.Size = new System.Drawing.Size(704, 173);
            this.lstReserva.TabIndex = 41;
            this.lstReserva.TabStop = false;
            this.lstReserva.Click += new System.EventHandler(this.lstReserva_Click);
            // 
            // txtObservacionReserva
            // 
            this.txtObservacionReserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacionReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionReserva.Location = new System.Drawing.Point(94, 305);
            this.txtObservacionReserva.Name = "txtObservacionReserva";
            this.txtObservacionReserva.Size = new System.Drawing.Size(191, 21);
            this.txtObservacionReserva.TabIndex = 31;
            // 
            // cboRegistradorReserva
            // 
            this.cboRegistradorReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRegistradorReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegistradorReserva.FormattingEnabled = true;
            this.cboRegistradorReserva.Location = new System.Drawing.Point(83, 229);
            this.cboRegistradorReserva.Name = "cboRegistradorReserva";
            this.cboRegistradorReserva.Size = new System.Drawing.Size(202, 24);
            this.cboRegistradorReserva.TabIndex = 28;
            // 
            // cboClienteReserva
            // 
            this.cboClienteReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClienteReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClienteReserva.FormattingEnabled = true;
            this.cboClienteReserva.Location = new System.Drawing.Point(61, 189);
            this.cboClienteReserva.Name = "cboClienteReserva";
            this.cboClienteReserva.Size = new System.Drawing.Size(224, 24);
            this.cboClienteReserva.TabIndex = 26;
            // 
            // dtpFechaHoraEntradaReserva
            // 
            this.dtpFechaHoraEntradaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaHoraEntradaReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHoraEntradaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHoraEntradaReserva.Location = new System.Drawing.Point(149, 68);
            this.dtpFechaHoraEntradaReserva.Name = "dtpFechaHoraEntradaReserva";
            this.dtpFechaHoraEntradaReserva.Size = new System.Drawing.Size(136, 21);
            this.dtpFechaHoraEntradaReserva.TabIndex = 21;
            // 
            // dtpFechaHoraSalidaReserva
            // 
            this.dtpFechaHoraSalidaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaHoraSalidaReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHoraSalidaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHoraSalidaReserva.Location = new System.Drawing.Point(139, 108);
            this.dtpFechaHoraSalidaReserva.Name = "dtpFechaHoraSalidaReserva";
            this.dtpFechaHoraSalidaReserva.Size = new System.Drawing.Size(146, 21);
            this.dtpFechaHoraSalidaReserva.TabIndex = 23;
            //this.dtpFechaHoraSalidaReserva.ValueChanged += new System.EventHandler(this.dtpFechaHoraSalidaReserva_ValueChanged);
            // 
            // cboHabitacionReserva
            // 
            this.cboHabitacionReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboHabitacionReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHabitacionReserva.FormattingEnabled = true;
            this.cboHabitacionReserva.Location = new System.Drawing.Point(83, 149);
            this.cboHabitacionReserva.Name = "cboHabitacionReserva";
            this.cboHabitacionReserva.Size = new System.Drawing.Size(202, 24);
            this.cboHabitacionReserva.TabIndex = 24;
            // 
            // txtCodReserva
            // 
            this.txtCodReserva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodReserva.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCodReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodReserva.ForeColor = System.Drawing.Color.Transparent;
            this.txtCodReserva.Location = new System.Drawing.Point(97, 29);
            this.txtCodReserva.Name = "txtCodReserva";
            this.txtCodReserva.ReadOnly = true;
            this.txtCodReserva.Size = new System.Drawing.Size(188, 21);
            this.txtCodReserva.TabIndex = 19;
            // 
            // txtCostoTotalReserva
            // 
            this.txtCostoTotalReserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostoTotalReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotalReserva.Location = new System.Drawing.Point(83, 269);
            this.txtCostoTotalReserva.Name = "txtCostoTotalReserva";
            this.txtCostoTotalReserva.Size = new System.Drawing.Size(202, 21);
            this.txtCostoTotalReserva.TabIndex = 30;
            this.txtCostoTotalReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoTotalReserva_KeyPress);
            // 
            // lblObservacionReserva
            // 
            this.lblObservacionReserva.AutoSize = true;
            this.lblObservacionReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionReserva.Location = new System.Drawing.Point(6, 308);
            this.lblObservacionReserva.Name = "lblObservacionReserva";
            this.lblObservacionReserva.Size = new System.Drawing.Size(82, 16);
            this.lblObservacionReserva.TabIndex = 34;
            this.lblObservacionReserva.Text = "Observación:";
            // 
            // lblCostoTotalReserva
            // 
            this.lblCostoTotalReserva.AutoSize = true;
            this.lblCostoTotalReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotalReserva.Location = new System.Drawing.Point(6, 272);
            this.lblCostoTotalReserva.Name = "lblCostoTotalReserva";
            this.lblCostoTotalReserva.Size = new System.Drawing.Size(71, 16);
            this.lblCostoTotalReserva.TabIndex = 32;
            this.lblCostoTotalReserva.Text = "Costo Total:";
            // 
            // lblRegistradorReserva
            // 
            this.lblRegistradorReserva.AutoSize = true;
            this.lblRegistradorReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistradorReserva.Location = new System.Drawing.Point(6, 232);
            this.lblRegistradorReserva.Name = "lblRegistradorReserva";
            this.lblRegistradorReserva.Size = new System.Drawing.Size(71, 16);
            this.lblRegistradorReserva.TabIndex = 29;
            this.lblRegistradorReserva.Text = "Registrador:";
            // 
            // lblClienteReserva
            // 
            this.lblClienteReserva.AutoSize = true;
            this.lblClienteReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteReserva.Location = new System.Drawing.Point(6, 192);
            this.lblClienteReserva.Name = "lblClienteReserva";
            this.lblClienteReserva.Size = new System.Drawing.Size(49, 16);
            this.lblClienteReserva.TabIndex = 27;
            this.lblClienteReserva.Text = "Cliente:";
            // 
            // lblHabitacionReserva
            // 
            this.lblHabitacionReserva.AutoSize = true;
            this.lblHabitacionReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacionReserva.Location = new System.Drawing.Point(6, 152);
            this.lblHabitacionReserva.Name = "lblHabitacionReserva";
            this.lblHabitacionReserva.Size = new System.Drawing.Size(72, 16);
            this.lblHabitacionReserva.TabIndex = 25;
            this.lblHabitacionReserva.Text = "Habitación:";
            // 
            // lblFechaHoraSalidaReserva
            // 
            this.lblFechaHoraSalidaReserva.AutoSize = true;
            this.lblFechaHoraSalidaReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraSalidaReserva.Location = new System.Drawing.Point(6, 112);
            this.lblFechaHoraSalidaReserva.Name = "lblFechaHoraSalidaReserva";
            this.lblFechaHoraSalidaReserva.Size = new System.Drawing.Size(127, 16);
            this.lblFechaHoraSalidaReserva.TabIndex = 22;
            this.lblFechaHoraSalidaReserva.Text = "Fecha / Hora / Salida:";
            // 
            // lblFechaHoraEntradaReserva
            // 
            this.lblFechaHoraEntradaReserva.AutoSize = true;
            this.lblFechaHoraEntradaReserva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraEntradaReserva.Location = new System.Drawing.Point(6, 72);
            this.lblFechaHoraEntradaReserva.Name = "lblFechaHoraEntradaReserva";
            this.lblFechaHoraEntradaReserva.Size = new System.Drawing.Size(137, 16);
            this.lblFechaHoraEntradaReserva.TabIndex = 20;
            this.lblFechaHoraEntradaReserva.Text = "Fecha / Hora / Entrada:";
            // 
            // lblCodRerseva
            // 
            this.lblCodRerseva.AutoSize = true;
            this.lblCodRerseva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodRerseva.Location = new System.Drawing.Point(6, 32);
            this.lblCodRerseva.Name = "lblCodRerseva";
            this.lblCodRerseva.Size = new System.Drawing.Size(85, 16);
            this.lblCodRerseva.TabIndex = 18;
            this.lblCodRerseva.Text = "Cod. Reserva:";
            // 
            // gbxReserva
            // 
            this.gbxReserva.Controls.Add(this.pictReserva);
            this.gbxReserva.Controls.Add(this.lblCodRerseva);
            this.gbxReserva.Controls.Add(this.lblFechaHoraEntradaReserva);
            this.gbxReserva.Controls.Add(this.lblFechaHoraSalidaReserva);
            this.gbxReserva.Controls.Add(this.lblHabitacionReserva);
            this.gbxReserva.Controls.Add(this.lblClienteReserva);
            this.gbxReserva.Controls.Add(this.btnCancelar);
            this.gbxReserva.Controls.Add(this.lblRegistradorReserva);
            this.gbxReserva.Controls.Add(this.btnLimpiar);
            this.gbxReserva.Controls.Add(this.lblCostoTotalReserva);
            this.gbxReserva.Controls.Add(this.btnAceptar);
            this.gbxReserva.Controls.Add(this.lblObservacionReserva);
            this.gbxReserva.Controls.Add(this.txtCodReserva);
            this.gbxReserva.Controls.Add(this.txtObservacionReserva);
            this.gbxReserva.Controls.Add(this.txtCostoTotalReserva);
            this.gbxReserva.Controls.Add(this.cboRegistradorReserva);
            this.gbxReserva.Controls.Add(this.cboHabitacionReserva);
            this.gbxReserva.Controls.Add(this.cboClienteReserva);
            this.gbxReserva.Controls.Add(this.dtpFechaHoraSalidaReserva);
            this.gbxReserva.Controls.Add(this.dtpFechaHoraEntradaReserva);
            this.gbxReserva.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReserva.Location = new System.Drawing.Point(12, 12);
            this.gbxReserva.Name = "gbxReserva";
            this.gbxReserva.Size = new System.Drawing.Size(820, 389);
            this.gbxReserva.TabIndex = 42;
            this.gbxReserva.TabStop = false;
            this.gbxReserva.Text = "Nómina de Reservas";
            // 
            // pictReserva
            // 
            this.pictReserva.BackgroundImage = global::Sistema_Hotel.Properties.Resources.hospitality_uniform_suppliers_uk1;
            this.pictReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictReserva.ErrorImage = null;
            this.pictReserva.Location = new System.Drawing.Point(299, 29);
            this.pictReserva.Name = "pictReserva";
            this.pictReserva.Size = new System.Drawing.Size(504, 333);
            this.pictReserva.TabIndex = 37;
            this.pictReserva.TabStop = false;
            // 
            // lblListadoReservas
            // 
            this.lblListadoReservas.AutoSize = true;
            this.lblListadoReservas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoReservas.Location = new System.Drawing.Point(360, 409);
            this.lblListadoReservas.Name = "lblListadoReservas";
            this.lblListadoReservas.Size = new System.Drawing.Size(115, 16);
            this.lblListadoReservas.TabIndex = 43;
            this.lblListadoReservas.Text = "Listado de Reservas";
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarListado.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarListado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarListado.Location = new System.Drawing.Point(728, 540);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(104, 30);
            this.btnGenerarListado.TabIndex = 44;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 625);
            this.Controls.Add(this.btnGenerarListado);
            this.Controls.Add(this.lblListadoReservas);
            this.Controls.Add(this.gbxReserva);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Habitaciones";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.gbxReserva.ResumeLayout(false);
            this.gbxReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstReserva;
        private System.Windows.Forms.TextBox txtObservacionReserva;
        private System.Windows.Forms.ComboBox cboRegistradorReserva;
        private System.Windows.Forms.ComboBox cboClienteReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraEntradaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraSalidaReserva;
        private System.Windows.Forms.ComboBox cboHabitacionReserva;
        private System.Windows.Forms.TextBox txtCodReserva;
        private System.Windows.Forms.TextBox txtCostoTotalReserva;
        private System.Windows.Forms.Label lblObservacionReserva;
        private System.Windows.Forms.Label lblCostoTotalReserva;
        private System.Windows.Forms.Label lblRegistradorReserva;
        private System.Windows.Forms.Label lblClienteReserva;
        private System.Windows.Forms.Label lblHabitacionReserva;
        private System.Windows.Forms.Label lblFechaHoraSalidaReserva;
        private System.Windows.Forms.Label lblFechaHoraEntradaReserva;
        private System.Windows.Forms.Label lblCodRerseva;
        private System.Windows.Forms.GroupBox gbxReserva;
        private System.Windows.Forms.Label lblListadoReservas;
        private System.Windows.Forms.PictureBox pictReserva;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}