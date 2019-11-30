namespace Sistema_Hotel
{
    partial class frmGastos
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
            this.lstGastos = new System.Windows.Forms.ListBox();
            this.txtCostoTotalGasto = new System.Windows.Forms.TextBox();
            this.txtCantidadGasto = new System.Windows.Forms.TextBox();
            this.dtpFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.txtCodGasto = new System.Windows.Forms.TextBox();
            this.cboServicioGasto = new System.Windows.Forms.ComboBox();
            this.cboReservaGasto = new System.Windows.Forms.ComboBox();
            this.lblCostoTotalGasto = new System.Windows.Forms.Label();
            this.lblCantidadServicio = new System.Windows.Forms.Label();
            this.lblFechaGasto = new System.Windows.Forms.Label();
            this.lblServicioGasto = new System.Windows.Forms.Label();
            this.lblCodRerservaGasto = new System.Windows.Forms.Label();
            this.lblCodGasto = new System.Windows.Forms.Label();
            this.gbxGastos = new System.Windows.Forms.GroupBox();
            this.pictGatos = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblListadoGastos = new System.Windows.Forms.Label();
            this.mnsMoverFormulario = new System.Windows.Forms.MenuStrip();
            this.gbxGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictGatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGastos
            // 
            this.lstGastos.BackColor = System.Drawing.Color.White;
            this.lstGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstGastos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGastos.FormattingEnabled = true;
            this.lstGastos.ItemHeight = 16;
            this.lstGastos.Location = new System.Drawing.Point(12, 366);
            this.lstGastos.Name = "lstGastos";
            this.lstGastos.Size = new System.Drawing.Size(716, 148);
            this.lstGastos.TabIndex = 31;
            this.lstGastos.TabStop = false;
            this.lstGastos.Click += new System.EventHandler(this.lstGastos_Click);
            // 
            // txtCostoTotalGasto
            // 
            this.txtCostoTotalGasto.BackColor = System.Drawing.Color.White;
            this.txtCostoTotalGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCostoTotalGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotalGasto.Location = new System.Drawing.Point(83, 224);
            this.txtCostoTotalGasto.Name = "txtCostoTotalGasto";
            this.txtCostoTotalGasto.Size = new System.Drawing.Size(202, 21);
            this.txtCostoTotalGasto.TabIndex = 24;
            // 
            // txtCantidadGasto
            // 
            this.txtCantidadGasto.BackColor = System.Drawing.Color.White;
            this.txtCantidadGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCantidadGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadGasto.Location = new System.Drawing.Point(77, 186);
            this.txtCantidadGasto.Name = "txtCantidadGasto";
            this.txtCantidadGasto.Size = new System.Drawing.Size(208, 21);
            this.txtCantidadGasto.TabIndex = 22;
            // 
            // dtpFechaGasto
            // 
            this.dtpFechaGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGasto.Location = new System.Drawing.Point(106, 149);
            this.dtpFechaGasto.Name = "dtpFechaGasto";
            this.dtpFechaGasto.Size = new System.Drawing.Size(179, 21);
            this.dtpFechaGasto.TabIndex = 20;
            // 
            // txtCodGasto
            // 
            this.txtCodGasto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodGasto.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCodGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodGasto.Location = new System.Drawing.Point(86, 34);
            this.txtCodGasto.Name = "txtCodGasto";
            this.txtCodGasto.ReadOnly = true;
            this.txtCodGasto.Size = new System.Drawing.Size(199, 21);
            this.txtCodGasto.TabIndex = 14;
            // 
            // cboServicioGasto
            // 
            this.cboServicioGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboServicioGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServicioGasto.FormattingEnabled = true;
            this.cboServicioGasto.Location = new System.Drawing.Point(65, 110);
            this.cboServicioGasto.Name = "cboServicioGasto";
            this.cboServicioGasto.Size = new System.Drawing.Size(220, 24);
            this.cboServicioGasto.TabIndex = 18;
            // 
            // cboReservaGasto
            // 
            this.cboReservaGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboReservaGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservaGasto.FormattingEnabled = true;
            this.cboReservaGasto.Location = new System.Drawing.Point(67, 72);
            this.cboReservaGasto.Name = "cboReservaGasto";
            this.cboReservaGasto.Size = new System.Drawing.Size(218, 24);
            this.cboReservaGasto.TabIndex = 15;
            // 
            // lblCostoTotalGasto
            // 
            this.lblCostoTotalGasto.AutoSize = true;
            this.lblCostoTotalGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotalGasto.Location = new System.Drawing.Point(6, 227);
            this.lblCostoTotalGasto.Name = "lblCostoTotalGasto";
            this.lblCostoTotalGasto.Size = new System.Drawing.Size(71, 16);
            this.lblCostoTotalGasto.TabIndex = 23;
            this.lblCostoTotalGasto.Text = "Costo Total:";
            // 
            // lblCantidadServicio
            // 
            this.lblCantidadServicio.AutoSize = true;
            this.lblCantidadServicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadServicio.Location = new System.Drawing.Point(6, 189);
            this.lblCantidadServicio.Name = "lblCantidadServicio";
            this.lblCantidadServicio.Size = new System.Drawing.Size(65, 16);
            this.lblCantidadServicio.TabIndex = 21;
            this.lblCantidadServicio.Text = "Cantidad:";
            // 
            // lblFechaGasto
            // 
            this.lblFechaGasto.AutoSize = true;
            this.lblFechaGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGasto.Location = new System.Drawing.Point(6, 151);
            this.lblFechaGasto.Name = "lblFechaGasto";
            this.lblFechaGasto.Size = new System.Drawing.Size(98, 16);
            this.lblFechaGasto.TabIndex = 19;
            this.lblFechaGasto.Text = "Fecha / Servicio:";
            // 
            // lblServicioGasto
            // 
            this.lblServicioGasto.AutoSize = true;
            this.lblServicioGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicioGasto.Location = new System.Drawing.Point(6, 113);
            this.lblServicioGasto.Name = "lblServicioGasto";
            this.lblServicioGasto.Size = new System.Drawing.Size(53, 16);
            this.lblServicioGasto.TabIndex = 17;
            this.lblServicioGasto.Text = "Servicio:";
            // 
            // lblCodRerservaGasto
            // 
            this.lblCodRerservaGasto.AutoSize = true;
            this.lblCodRerservaGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodRerservaGasto.Location = new System.Drawing.Point(6, 75);
            this.lblCodRerservaGasto.Name = "lblCodRerservaGasto";
            this.lblCodRerservaGasto.Size = new System.Drawing.Size(55, 16);
            this.lblCodRerservaGasto.TabIndex = 16;
            this.lblCodRerservaGasto.Text = "Reserva:";
            // 
            // lblCodGasto
            // 
            this.lblCodGasto.AutoSize = true;
            this.lblCodGasto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodGasto.Location = new System.Drawing.Point(6, 37);
            this.lblCodGasto.Name = "lblCodGasto";
            this.lblCodGasto.Size = new System.Drawing.Size(74, 16);
            this.lblCodGasto.TabIndex = 13;
            this.lblCodGasto.Text = "Cod. Gasto:";
            // 
            // gbxGastos
            // 
            this.gbxGastos.Controls.Add(this.pictGatos);
            this.gbxGastos.Controls.Add(this.btnCancelar);
            this.gbxGastos.Controls.Add(this.btnLimpiar);
            this.gbxGastos.Controls.Add(this.btnAceptar);
            this.gbxGastos.Controls.Add(this.lblCodRerservaGasto);
            this.gbxGastos.Controls.Add(this.lblCodGasto);
            this.gbxGastos.Controls.Add(this.lblServicioGasto);
            this.gbxGastos.Controls.Add(this.lblFechaGasto);
            this.gbxGastos.Controls.Add(this.lblCantidadServicio);
            this.gbxGastos.Controls.Add(this.lblCostoTotalGasto);
            this.gbxGastos.Controls.Add(this.cboReservaGasto);
            this.gbxGastos.Controls.Add(this.cboServicioGasto);
            this.gbxGastos.Controls.Add(this.txtCodGasto);
            this.gbxGastos.Controls.Add(this.txtCostoTotalGasto);
            this.gbxGastos.Controls.Add(this.dtpFechaGasto);
            this.gbxGastos.Controls.Add(this.txtCantidadGasto);
            this.gbxGastos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGastos.Location = new System.Drawing.Point(12, 12);
            this.gbxGastos.Name = "gbxGastos";
            this.gbxGastos.Size = new System.Drawing.Size(820, 321);
            this.gbxGastos.TabIndex = 33;
            this.gbxGastos.TabStop = false;
            this.gbxGastos.Text = "Nomina de Gastos";
            // 
            // pictGatos
            // 
            this.pictGatos.BackgroundImage = global::Sistema_Hotel.Properties.Resources.wallhaven_zmv33w;
            this.pictGatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictGatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictGatos.Location = new System.Drawing.Point(302, 34);
            this.pictGatos.Name = "pictGatos";
            this.pictGatos.Size = new System.Drawing.Size(499, 265);
            this.pictGatos.TabIndex = 33;
            this.pictGatos.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(103, 269);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(197, 269);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(9, 269);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 30);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(744, 444);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 30);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(744, 406);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 30);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(744, 366);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 30);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(744, 484);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 30);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lblListadoGastos
            // 
            this.lblListadoGastos.AutoSize = true;
            this.lblListadoGastos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoGastos.Location = new System.Drawing.Point(368, 341);
            this.lblListadoGastos.Name = "lblListadoGastos";
            this.lblListadoGastos.Size = new System.Drawing.Size(104, 16);
            this.lblListadoGastos.TabIndex = 34;
            this.lblListadoGastos.Text = "Listado de Gastos";
            // 
            // mnsMoverFormulario
            // 
            this.mnsMoverFormulario.BackColor = System.Drawing.Color.Transparent;
            this.mnsMoverFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnsMoverFormulario.Location = new System.Drawing.Point(0, 0);
            this.mnsMoverFormulario.Name = "mnsMoverFormulario";
            this.mnsMoverFormulario.Size = new System.Drawing.Size(845, 533);
            this.mnsMoverFormulario.TabIndex = 46;
            this.mnsMoverFormulario.Text = "menuStrip1";
            this.mnsMoverFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnsMoverFormulario_MouseDown);
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 533);
            this.Controls.Add(this.lblListadoGastos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxGastos);
            this.Controls.Add(this.lstGastos);
            this.Controls.Add(this.mnsMoverFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnsMoverFormulario;
            this.Name = "frmGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nonima de Gastos";
            this.Load += new System.EventHandler(this.frmGastos_Load);
            this.gbxGastos.ResumeLayout(false);
            this.gbxGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictGatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstGastos;
        private System.Windows.Forms.TextBox txtCostoTotalGasto;
        private System.Windows.Forms.TextBox txtCantidadGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaGasto;
        private System.Windows.Forms.TextBox txtCodGasto;
        private System.Windows.Forms.ComboBox cboServicioGasto;
        private System.Windows.Forms.ComboBox cboReservaGasto;
        private System.Windows.Forms.Label lblCostoTotalGasto;
        private System.Windows.Forms.Label lblCantidadServicio;
        private System.Windows.Forms.Label lblFechaGasto;
        private System.Windows.Forms.Label lblServicioGasto;
        private System.Windows.Forms.Label lblCodRerservaGasto;
        private System.Windows.Forms.Label lblCodGasto;
        private System.Windows.Forms.GroupBox gbxGastos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictGatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblListadoGastos;
        private System.Windows.Forms.MenuStrip mnsMoverFormulario;
    }
}