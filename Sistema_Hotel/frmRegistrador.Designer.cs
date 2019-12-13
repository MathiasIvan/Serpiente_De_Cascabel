namespace Sistema_Hotel
{
    partial class frmRegistrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrador));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtObservacionRegistrador = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoRegistrador = new System.Windows.Forms.TextBox();
            this.txtTelefonoRegistrador = new System.Windows.Forms.TextBox();
            this.txtNombreRegistrador = new System.Windows.Forms.TextBox();
            this.txtDireccionRegistrador = new System.Windows.Forms.TextBox();
            this.txtCodRegistrador = new System.Windows.Forms.TextBox();
            this.lblObservacionRegistrador = new System.Windows.Forms.Label();
            this.lblTelefonoRegistrador = new System.Windows.Forms.Label();
            this.lblNroDocumentoRegistrador = new System.Windows.Forms.Label();
            this.lblDireccionRegistrador = new System.Windows.Forms.Label();
            this.lblNombreRegistrador = new System.Windows.Forms.Label();
            this.lblCodRegistrador = new System.Windows.Forms.Label();
            this.gbxRegistradores = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblListadoRegistradores = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstRegistrador = new System.Windows.Forms.ListBox();
            this.mnsMoverFormulario = new System.Windows.Forms.MenuStrip();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.gbxRegistradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(102, 267);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(196, 267);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(8, 267);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 30);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtObservacionRegistrador
            // 
            this.txtObservacionRegistrador.BackColor = System.Drawing.Color.White;
            this.txtObservacionRegistrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacionRegistrador.Location = new System.Drawing.Point(93, 238);
            this.txtObservacionRegistrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObservacionRegistrador.Name = "txtObservacionRegistrador";
            this.txtObservacionRegistrador.Size = new System.Drawing.Size(191, 22);
            this.txtObservacionRegistrador.TabIndex = 25;
            // 
            // txtNroDocumentoRegistrador
            // 
            this.txtNroDocumentoRegistrador.BackColor = System.Drawing.Color.White;
            this.txtNroDocumentoRegistrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDocumentoRegistrador.Location = new System.Drawing.Point(110, 197);
            this.txtNroDocumentoRegistrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNroDocumentoRegistrador.Name = "txtNroDocumentoRegistrador";
            this.txtNroDocumentoRegistrador.Size = new System.Drawing.Size(174, 22);
            this.txtNroDocumentoRegistrador.TabIndex = 24;
            // 
            // txtTelefonoRegistrador
            // 
            this.txtTelefonoRegistrador.BackColor = System.Drawing.Color.White;
            this.txtTelefonoRegistrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoRegistrador.Location = new System.Drawing.Point(67, 158);
            this.txtTelefonoRegistrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoRegistrador.Name = "txtTelefonoRegistrador";
            this.txtTelefonoRegistrador.Size = new System.Drawing.Size(217, 22);
            this.txtTelefonoRegistrador.TabIndex = 22;
            // 
            // txtNombreRegistrador
            // 
            this.txtNombreRegistrador.BackColor = System.Drawing.Color.White;
            this.txtNombreRegistrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreRegistrador.Location = new System.Drawing.Point(65, 75);
            this.txtNombreRegistrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreRegistrador.Name = "txtNombreRegistrador";
            this.txtNombreRegistrador.Size = new System.Drawing.Size(219, 22);
            this.txtNombreRegistrador.TabIndex = 17;
            // 
            // txtDireccionRegistrador
            // 
            this.txtDireccionRegistrador.BackColor = System.Drawing.Color.White;
            this.txtDireccionRegistrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionRegistrador.Location = new System.Drawing.Point(72, 117);
            this.txtDireccionRegistrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccionRegistrador.Name = "txtDireccionRegistrador";
            this.txtDireccionRegistrador.Size = new System.Drawing.Size(212, 22);
            this.txtDireccionRegistrador.TabIndex = 20;
            // 
            // txtCodRegistrador
            // 
            this.txtCodRegistrador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodRegistrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodRegistrador.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCodRegistrador.Location = new System.Drawing.Point(112, 34);
            this.txtCodRegistrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodRegistrador.Name = "txtCodRegistrador";
            this.txtCodRegistrador.ReadOnly = true;
            this.txtCodRegistrador.Size = new System.Drawing.Size(172, 22);
            this.txtCodRegistrador.TabIndex = 16;
            // 
            // lblObservacionRegistrador
            // 
            this.lblObservacionRegistrador.AutoSize = true;
            this.lblObservacionRegistrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionRegistrador.Location = new System.Drawing.Point(5, 241);
            this.lblObservacionRegistrador.Name = "lblObservacionRegistrador";
            this.lblObservacionRegistrador.Size = new System.Drawing.Size(82, 16);
            this.lblObservacionRegistrador.TabIndex = 27;
            this.lblObservacionRegistrador.Text = "Observación:";
            // 
            // lblTelefonoRegistrador
            // 
            this.lblTelefonoRegistrador.AutoSize = true;
            this.lblTelefonoRegistrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoRegistrador.Location = new System.Drawing.Point(5, 161);
            this.lblTelefonoRegistrador.Name = "lblTelefonoRegistrador";
            this.lblTelefonoRegistrador.Size = new System.Drawing.Size(56, 16);
            this.lblTelefonoRegistrador.TabIndex = 23;
            this.lblTelefonoRegistrador.Text = "Teléfono:";
            // 
            // lblNroDocumentoRegistrador
            // 
            this.lblNroDocumentoRegistrador.AutoSize = true;
            this.lblNroDocumentoRegistrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumentoRegistrador.Location = new System.Drawing.Point(5, 200);
            this.lblNroDocumentoRegistrador.Name = "lblNroDocumentoRegistrador";
            this.lblNroDocumentoRegistrador.Size = new System.Drawing.Size(99, 16);
            this.lblNroDocumentoRegistrador.TabIndex = 21;
            this.lblNroDocumentoRegistrador.Text = "Nro. Documento:";
            // 
            // lblDireccionRegistrador
            // 
            this.lblDireccionRegistrador.AutoSize = true;
            this.lblDireccionRegistrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionRegistrador.Location = new System.Drawing.Point(5, 120);
            this.lblDireccionRegistrador.Name = "lblDireccionRegistrador";
            this.lblDireccionRegistrador.Size = new System.Drawing.Size(61, 16);
            this.lblDireccionRegistrador.TabIndex = 19;
            this.lblDireccionRegistrador.Text = "Dirección:";
            // 
            // lblNombreRegistrador
            // 
            this.lblNombreRegistrador.AutoSize = true;
            this.lblNombreRegistrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRegistrador.Location = new System.Drawing.Point(5, 78);
            this.lblNombreRegistrador.Name = "lblNombreRegistrador";
            this.lblNombreRegistrador.Size = new System.Drawing.Size(54, 16);
            this.lblNombreRegistrador.TabIndex = 18;
            this.lblNombreRegistrador.Text = "Nombre:";
            // 
            // lblCodRegistrador
            // 
            this.lblCodRegistrador.AutoSize = true;
            this.lblCodRegistrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodRegistrador.Location = new System.Drawing.Point(5, 37);
            this.lblCodRegistrador.Name = "lblCodRegistrador";
            this.lblCodRegistrador.Size = new System.Drawing.Size(101, 16);
            this.lblCodRegistrador.TabIndex = 15;
            this.lblCodRegistrador.Text = "Cod. Registrador:";
            // 
            // gbxRegistradores
            // 
            this.gbxRegistradores.Controls.Add(this.pictureBox1);
            this.gbxRegistradores.Controls.Add(this.btnCancelar);
            this.gbxRegistradores.Controls.Add(this.txtNombreRegistrador);
            this.gbxRegistradores.Controls.Add(this.btnLimpiar);
            this.gbxRegistradores.Controls.Add(this.txtNroDocumentoRegistrador);
            this.gbxRegistradores.Controls.Add(this.btnAceptar);
            this.gbxRegistradores.Controls.Add(this.txtTelefonoRegistrador);
            this.gbxRegistradores.Controls.Add(this.txtCodRegistrador);
            this.gbxRegistradores.Controls.Add(this.txtObservacionRegistrador);
            this.gbxRegistradores.Controls.Add(this.lblCodRegistrador);
            this.gbxRegistradores.Controls.Add(this.txtDireccionRegistrador);
            this.gbxRegistradores.Controls.Add(this.lblNombreRegistrador);
            this.gbxRegistradores.Controls.Add(this.lblObservacionRegistrador);
            this.gbxRegistradores.Controls.Add(this.lblDireccionRegistrador);
            this.gbxRegistradores.Controls.Add(this.lblTelefonoRegistrador);
            this.gbxRegistradores.Controls.Add(this.lblNroDocumentoRegistrador);
            this.gbxRegistradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxRegistradores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRegistradores.Location = new System.Drawing.Point(12, 13);
            this.gbxRegistradores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxRegistradores.Name = "gbxRegistradores";
            this.gbxRegistradores.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxRegistradores.Size = new System.Drawing.Size(820, 321);
            this.gbxRegistradores.TabIndex = 35;
            this.gbxRegistradores.TabStop = false;
            this.gbxRegistradores.Text = "Mantenimiento de Registradores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema_Hotel.Properties.Resources._1500x844_gestion_ventas_cartera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(302, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 263);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblListadoRegistradores
            // 
            this.lblListadoRegistradores.AutoSize = true;
            this.lblListadoRegistradores.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoRegistradores.ForeColor = System.Drawing.Color.Black;
            this.lblListadoRegistradores.Location = new System.Drawing.Point(361, 344);
            this.lblListadoRegistradores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListadoRegistradores.Name = "lblListadoRegistradores";
            this.lblListadoRegistradores.Size = new System.Drawing.Size(138, 16);
            this.lblListadoRegistradores.TabIndex = 37;
            this.lblListadoRegistradores.Text = "Listado de Registradores";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(728, 442);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 30);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(728, 405);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 30);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(728, 367);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 30);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(728, 517);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 30);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lstRegistrador
            // 
            this.lstRegistrador.BackColor = System.Drawing.Color.White;
            this.lstRegistrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstRegistrador.FormattingEnabled = true;
            this.lstRegistrador.ItemHeight = 16;
            this.lstRegistrador.Location = new System.Drawing.Point(12, 367);
            this.lstRegistrador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstRegistrador.Name = "lstRegistrador";
            this.lstRegistrador.Size = new System.Drawing.Size(704, 180);
            this.lstRegistrador.TabIndex = 34;
            this.lstRegistrador.TabStop = false;
            this.lstRegistrador.Click += new System.EventHandler(this.lstRegistrador_Click);
            // 
            // mnsMoverFormulario
            // 
            this.mnsMoverFormulario.BackColor = System.Drawing.Color.Transparent;
            this.mnsMoverFormulario.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnsMoverFormulario.Location = new System.Drawing.Point(0, 0);
            this.mnsMoverFormulario.Name = "mnsMoverFormulario";
            this.mnsMoverFormulario.Size = new System.Drawing.Size(30, 563);
            this.mnsMoverFormulario.TabIndex = 42;
            this.mnsMoverFormulario.Text = "menuStrip1";
            this.mnsMoverFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnsMoverFormulario_MouseDown);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.BackColor = System.Drawing.Color.White;
            this.btnGenerarListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarListado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerarListado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarListado.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarListado.Location = new System.Drawing.Point(728, 480);
            this.btnGenerarListado.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(104, 30);
            this.btnGenerarListado.TabIndex = 43;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = false;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // frmRegistrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.btnGenerarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblListadoRegistradores);
            this.Controls.Add(this.gbxRegistradores);
            this.Controls.Add(this.lstRegistrador);
            this.Controls.Add(this.mnsMoverFormulario);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMoverFormulario;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrador";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Registradores";
            this.Load += new System.EventHandler(this.frmRegistrador_Load);
            this.gbxRegistradores.ResumeLayout(false);
            this.gbxRegistradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtObservacionRegistrador;
        private System.Windows.Forms.TextBox txtNroDocumentoRegistrador;
        private System.Windows.Forms.TextBox txtTelefonoRegistrador;
        private System.Windows.Forms.TextBox txtNombreRegistrador;
        private System.Windows.Forms.TextBox txtDireccionRegistrador;
        private System.Windows.Forms.TextBox txtCodRegistrador;
        private System.Windows.Forms.Label lblObservacionRegistrador;
        private System.Windows.Forms.Label lblTelefonoRegistrador;
        private System.Windows.Forms.Label lblNroDocumentoRegistrador;
        private System.Windows.Forms.Label lblDireccionRegistrador;
        private System.Windows.Forms.Label lblNombreRegistrador;
        private System.Windows.Forms.Label lblCodRegistrador;
        private System.Windows.Forms.GroupBox gbxRegistradores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListadoRegistradores;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstRegistrador;
        private System.Windows.Forms.MenuStrip mnsMoverFormulario;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}