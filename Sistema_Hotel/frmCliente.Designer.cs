namespace Sistema_Hotel
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.lblListadoClientes = new System.Windows.Forms.Label();
            this.gbxRegistroClientes = new System.Windows.Forms.GroupBox();
            this.pictCliente = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtNroDocumentoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.cboNacionalidadCliente = new System.Windows.Forms.ComboBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblNacionalidadCliente = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblNroDocumentoCliente = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.mnsMoverFormulario = new System.Windows.Forms.MenuStrip();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.gbxRegistroClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(728, 441);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 30);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(728, 404);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 30);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(728, 366);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 30);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(728, 516);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstCliente
            // 
            this.lstCliente.BackColor = System.Drawing.Color.White;
            this.lstCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.ItemHeight = 16;
            this.lstCliente.Location = new System.Drawing.Point(12, 366);
            this.lstCliente.Margin = new System.Windows.Forms.Padding(4);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(704, 180);
            this.lstCliente.TabIndex = 32;
            this.lstCliente.TabStop = false;
            this.lstCliente.Click += new System.EventHandler(this.lstCliente_Click);
            // 
            // lblListadoClientes
            // 
            this.lblListadoClientes.AutoSize = true;
            this.lblListadoClientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoClientes.ForeColor = System.Drawing.Color.Black;
            this.lblListadoClientes.Location = new System.Drawing.Point(387, 341);
            this.lblListadoClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListadoClientes.Name = "lblListadoClientes";
            this.lblListadoClientes.Size = new System.Drawing.Size(109, 16);
            this.lblListadoClientes.TabIndex = 33;
            this.lblListadoClientes.Text = "Listado de Clientes";
            // 
            // gbxRegistroClientes
            // 
            this.gbxRegistroClientes.Controls.Add(this.pictCliente);
            this.gbxRegistroClientes.Controls.Add(this.btnCancelar);
            this.gbxRegistroClientes.Controls.Add(this.btnLimpiar);
            this.gbxRegistroClientes.Controls.Add(this.btnAceptar);
            this.gbxRegistroClientes.Controls.Add(this.txtTelefonoCliente);
            this.gbxRegistroClientes.Controls.Add(this.txtNroDocumentoCliente);
            this.gbxRegistroClientes.Controls.Add(this.txtNombreCliente);
            this.gbxRegistroClientes.Controls.Add(this.txtDireccionCliente);
            this.gbxRegistroClientes.Controls.Add(this.cboNacionalidadCliente);
            this.gbxRegistroClientes.Controls.Add(this.txtCodCliente);
            this.gbxRegistroClientes.Controls.Add(this.lblNacionalidadCliente);
            this.gbxRegistroClientes.Controls.Add(this.lblTelefonoCliente);
            this.gbxRegistroClientes.Controls.Add(this.lblNroDocumentoCliente);
            this.gbxRegistroClientes.Controls.Add(this.lblDireccionCliente);
            this.gbxRegistroClientes.Controls.Add(this.lblNombreCliente);
            this.gbxRegistroClientes.Controls.Add(this.lblCodCliente);
            this.gbxRegistroClientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRegistroClientes.Location = new System.Drawing.Point(12, 12);
            this.gbxRegistroClientes.Name = "gbxRegistroClientes";
            this.gbxRegistroClientes.Size = new System.Drawing.Size(820, 321);
            this.gbxRegistroClientes.TabIndex = 35;
            this.gbxRegistroClientes.TabStop = false;
            this.gbxRegistroClientes.Text = "Mantenimiento de Clientes";
            // 
            // pictCliente
            // 
            this.pictCliente.BackgroundImage = global::Sistema_Hotel.Properties.Resources.Clientes_Proveedores_Principal;
            this.pictCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictCliente.Location = new System.Drawing.Point(305, 33);
            this.pictCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pictCliente.Name = "pictCliente";
            this.pictCliente.Size = new System.Drawing.Size(499, 265);
            this.pictCliente.TabIndex = 50;
            this.pictCliente.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(106, 268);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(202, 268);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(9, 268);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 30);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.BackColor = System.Drawing.Color.White;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(80, 154);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(210, 22);
            this.txtTelefonoCliente.TabIndex = 38;
            this.txtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoCliente_KeyPress);
            // 
            // txtNroDocumentoCliente
            // 
            this.txtNroDocumentoCliente.BackColor = System.Drawing.Color.White;
            this.txtNroDocumentoCliente.Location = new System.Drawing.Point(113, 196);
            this.txtNroDocumentoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroDocumentoCliente.Name = "txtNroDocumentoCliente";
            this.txtNroDocumentoCliente.Size = new System.Drawing.Size(177, 22);
            this.txtNroDocumentoCliente.TabIndex = 39;
            this.txtNroDocumentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocumentoCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.White;
            this.txtNombreCliente.Location = new System.Drawing.Point(68, 74);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(222, 22);
            this.txtNombreCliente.TabIndex = 36;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BackColor = System.Drawing.Color.White;
            this.txtDireccionCliente.Location = new System.Drawing.Point(75, 115);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(215, 22);
            this.txtDireccionCliente.TabIndex = 37;
            // 
            // cboNacionalidadCliente
            // 
            this.cboNacionalidadCliente.BackColor = System.Drawing.Color.White;
            this.cboNacionalidadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNacionalidadCliente.FormattingEnabled = true;
            this.cboNacionalidadCliente.Location = new System.Drawing.Point(101, 236);
            this.cboNacionalidadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboNacionalidadCliente.Name = "cboNacionalidadCliente";
            this.cboNacionalidadCliente.Size = new System.Drawing.Size(189, 25);
            this.cboNacionalidadCliente.TabIndex = 40;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(93, 33);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(197, 22);
            this.txtCodCliente.TabIndex = 35;
            this.txtCodCliente.TabStop = false;
            // 
            // lblNacionalidadCliente
            // 
            this.lblNacionalidadCliente.AutoSize = true;
            this.lblNacionalidadCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidadCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNacionalidadCliente.Location = new System.Drawing.Point(7, 239);
            this.lblNacionalidadCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidadCliente.Name = "lblNacionalidadCliente";
            this.lblNacionalidadCliente.Size = new System.Drawing.Size(86, 16);
            this.lblNacionalidadCliente.TabIndex = 49;
            this.lblNacionalidadCliente.Text = "Nacionalidad:";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(7, 159);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(56, 16);
            this.lblTelefonoCliente.TabIndex = 48;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // lblNroDocumentoCliente
            // 
            this.lblNroDocumentoCliente.AutoSize = true;
            this.lblNroDocumentoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumentoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNroDocumentoCliente.Location = new System.Drawing.Point(7, 199);
            this.lblNroDocumentoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDocumentoCliente.Name = "lblNroDocumentoCliente";
            this.lblNroDocumentoCliente.Size = new System.Drawing.Size(99, 16);
            this.lblNroDocumentoCliente.TabIndex = 47;
            this.lblNroDocumentoCliente.Text = "Nro. Documento:";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.ForeColor = System.Drawing.Color.Black;
            this.lblDireccionCliente.Location = new System.Drawing.Point(6, 118);
            this.lblDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(61, 16);
            this.lblDireccionCliente.TabIndex = 46;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCliente.Location = new System.Drawing.Point(6, 77);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(54, 16);
            this.lblNombreCliente.TabIndex = 45;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCodCliente.Location = new System.Drawing.Point(6, 36);
            this.lblCodCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(79, 16);
            this.lblCodCliente.TabIndex = 44;
            this.lblCodCliente.Text = "Cod. Cliente:";
            // 
            // mnsMoverFormulario
            // 
            this.mnsMoverFormulario.BackColor = System.Drawing.Color.Transparent;
            this.mnsMoverFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnsMoverFormulario.Location = new System.Drawing.Point(0, 0);
            this.mnsMoverFormulario.Name = "mnsMoverFormulario";
            this.mnsMoverFormulario.Size = new System.Drawing.Size(845, 563);
            this.mnsMoverFormulario.TabIndex = 36;
            this.mnsMoverFormulario.Text = "menuStrip1";
            //this.mnsMoverFormulario.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsMoverFormulario_ItemClicked);
            this.mnsMoverFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnsMoverFormulario_MouseDown);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarListado.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGenerarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarListado.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarListado.Location = new System.Drawing.Point(728, 478);
            this.btnGenerarListado.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(104, 30);
            this.btnGenerarListado.TabIndex = 37;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = false;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.btnGenerarListado);
            this.Controls.Add(this.gbxRegistroClientes);
            this.Controls.Add(this.lblListadoClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.mnsMoverFormulario);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMoverFormulario;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.gbxRegistroClientes.ResumeLayout(false);
            this.gbxRegistroClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.Label lblListadoClientes;
        private System.Windows.Forms.GroupBox gbxRegistroClientes;
        private System.Windows.Forms.PictureBox pictCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtNroDocumentoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.ComboBox cboNacionalidadCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblNacionalidadCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Label lblNroDocumentoCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.MenuStrip mnsMoverFormulario;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}

