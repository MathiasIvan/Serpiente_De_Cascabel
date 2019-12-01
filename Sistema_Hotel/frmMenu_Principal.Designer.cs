namespace Sistema_Hotel
{
    partial class frmMenu_Principal
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
            this.components = new System.ComponentModel.Container();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mnsMoverFormulario = new System.Windows.Forms.MenuStrip();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictGastos = new System.Windows.Forms.PictureBox();
            this.pictReserva = new System.Windows.Forms.PictureBox();
            this.pictHabitacion = new System.Windows.Forms.PictureBox();
            this.pictRegistrador = new System.Windows.Forms.PictureBox();
            this.pictTipoHabitacion = new System.Windows.Forms.PictureBox();
            this.pictEstadoHabitacion = new System.Windows.Forms.PictureBox();
            this.pictCliente = new System.Windows.Forms.PictureBox();
            this.pictSalir = new System.Windows.Forms.PictureBox();
            this.pictMazimizar = new System.Windows.Forms.PictureBox();
            this.pictMinimizar = new System.Windows.Forms.PictureBox();
            this.pictRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuTop.SuspendLayout();
            this.SidebarWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRegistrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTipoHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEstadoHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMazimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.MenuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuTop.Controls.Add(this.pictSalir);
            this.MenuTop.Controls.Add(this.pictMazimizar);
            this.MenuTop.Controls.Add(this.pictMinimizar);
            this.MenuTop.Controls.Add(this.pictRestaurar);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.pictureBox1);
            this.MenuTop.Controls.Add(this.mnsMoverFormulario);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1100, 55);
            this.MenuTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema Hotel - Menu Principal";
            // 
            // mnsMoverFormulario
            // 
            this.mnsMoverFormulario.BackColor = System.Drawing.Color.Transparent;
            this.mnsMoverFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnsMoverFormulario.Location = new System.Drawing.Point(0, 0);
            this.mnsMoverFormulario.Name = "mnsMoverFormulario";
            this.mnsMoverFormulario.Size = new System.Drawing.Size(1098, 53);
            this.mnsMoverFormulario.TabIndex = 6;
            this.mnsMoverFormulario.Text = "menuStrip1";
            this.mnsMoverFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnsMoverFormulario_MouseDown);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.SidebarWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidebarWrapper.Controls.Add(this.pictGastos);
            this.SidebarWrapper.Controls.Add(this.pictReserva);
            this.SidebarWrapper.Controls.Add(this.pictHabitacion);
            this.SidebarWrapper.Controls.Add(this.pictRegistrador);
            this.SidebarWrapper.Controls.Add(this.pictTipoHabitacion);
            this.SidebarWrapper.Controls.Add(this.pictEstadoHabitacion);
            this.SidebarWrapper.Controls.Add(this.pictCliente);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 55);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(57, 645);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(63, 58);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 33);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "label3";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(63, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(523, 39);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "label3";
            // 
            // pictGastos
            // 
            this.pictGastos.BackgroundImage = global::Sistema_Hotel.Properties.Resources._009_pago1;
            this.pictGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictGastos.Location = new System.Drawing.Point(8, 139);
            this.pictGastos.Name = "pictGastos";
            this.pictGastos.Size = new System.Drawing.Size(38, 35);
            this.pictGastos.TabIndex = 7;
            this.pictGastos.TabStop = false;
            this.pictGastos.Click += new System.EventHandler(this.pictGastos_Click);
            // 
            // pictReserva
            // 
            this.pictReserva.BackgroundImage = global::Sistema_Hotel.Properties.Resources._003_bolso1;
            this.pictReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictReserva.Location = new System.Drawing.Point(8, 200);
            this.pictReserva.Name = "pictReserva";
            this.pictReserva.Size = new System.Drawing.Size(38, 35);
            this.pictReserva.TabIndex = 6;
            this.pictReserva.TabStop = false;
            this.pictReserva.Click += new System.EventHandler(this.pictReserva_Click);
            // 
            // pictHabitacion
            // 
            this.pictHabitacion.BackgroundImage = global::Sistema_Hotel.Properties.Resources.cama;
            this.pictHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictHabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictHabitacion.Location = new System.Drawing.Point(8, 261);
            this.pictHabitacion.Name = "pictHabitacion";
            this.pictHabitacion.Size = new System.Drawing.Size(38, 35);
            this.pictHabitacion.TabIndex = 5;
            this.pictHabitacion.TabStop = false;
            this.pictHabitacion.Click += new System.EventHandler(this.pictHabitacion_Click);
            // 
            // pictRegistrador
            // 
            this.pictRegistrador.BackgroundImage = global::Sistema_Hotel.Properties.Resources._001_team1;
            this.pictRegistrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictRegistrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRegistrador.Location = new System.Drawing.Point(8, 78);
            this.pictRegistrador.Name = "pictRegistrador";
            this.pictRegistrador.Size = new System.Drawing.Size(38, 35);
            this.pictRegistrador.TabIndex = 4;
            this.pictRegistrador.TabStop = false;
            this.pictRegistrador.Click += new System.EventHandler(this.pictRegistrador_Click);
            // 
            // pictTipoHabitacion
            // 
            this.pictTipoHabitacion.BackgroundImage = global::Sistema_Hotel.Properties.Resources.person_user_customer_man_male_man_boy_people_1687;
            this.pictTipoHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictTipoHabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictTipoHabitacion.Location = new System.Drawing.Point(8, 322);
            this.pictTipoHabitacion.Name = "pictTipoHabitacion";
            this.pictTipoHabitacion.Size = new System.Drawing.Size(38, 35);
            this.pictTipoHabitacion.TabIndex = 3;
            this.pictTipoHabitacion.TabStop = false;
            this.pictTipoHabitacion.Click += new System.EventHandler(this.pictTipoHabitacion_Click);
            // 
            // pictEstadoHabitacion
            // 
            this.pictEstadoHabitacion.BackgroundImage = global::Sistema_Hotel.Properties.Resources.hotel;
            this.pictEstadoHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictEstadoHabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictEstadoHabitacion.Location = new System.Drawing.Point(8, 383);
            this.pictEstadoHabitacion.Name = "pictEstadoHabitacion";
            this.pictEstadoHabitacion.Size = new System.Drawing.Size(38, 35);
            this.pictEstadoHabitacion.TabIndex = 2;
            this.pictEstadoHabitacion.TabStop = false;
            this.pictEstadoHabitacion.Click += new System.EventHandler(this.pictEstadoHabitacion_Click);
            // 
            // pictCliente
            // 
            this.pictCliente.BackgroundImage = global::Sistema_Hotel.Properties.Resources._002_cliente;
            this.pictCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCliente.Location = new System.Drawing.Point(8, 17);
            this.pictCliente.Name = "pictCliente";
            this.pictCliente.Size = new System.Drawing.Size(38, 35);
            this.pictCliente.TabIndex = 1;
            this.pictCliente.TabStop = false;
            this.pictCliente.Click += new System.EventHandler(this.pictCliente_Click);
            // 
            // pictSalir
            // 
            this.pictSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictSalir.BackgroundImage = global::Sistema_Hotel.Properties.Resources.Close_Window__2_48px2;
            this.pictSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictSalir.Location = new System.Drawing.Point(1056, 13);
            this.pictSalir.Name = "pictSalir";
            this.pictSalir.Size = new System.Drawing.Size(30, 30);
            this.pictSalir.TabIndex = 5;
            this.pictSalir.TabStop = false;
            this.pictSalir.Click += new System.EventHandler(this.pictSalir_Click);
            // 
            // pictMazimizar
            // 
            this.pictMazimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictMazimizar.BackgroundImage = global::Sistema_Hotel.Properties.Resources.Maximize_Window_2_48px2;
            this.pictMazimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictMazimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictMazimizar.Location = new System.Drawing.Point(1020, 13);
            this.pictMazimizar.Name = "pictMazimizar";
            this.pictMazimizar.Size = new System.Drawing.Size(30, 30);
            this.pictMazimizar.TabIndex = 4;
            this.pictMazimizar.TabStop = false;
            this.pictMazimizar.Click += new System.EventHandler(this.pictMazimizar_Click);
            // 
            // pictMinimizar
            // 
            this.pictMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictMinimizar.BackgroundImage = global::Sistema_Hotel.Properties.Resources.Minimize_Window_2_48px1;
            this.pictMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictMinimizar.Location = new System.Drawing.Point(984, 13);
            this.pictMinimizar.Name = "pictMinimizar";
            this.pictMinimizar.Size = new System.Drawing.Size(30, 30);
            this.pictMinimizar.TabIndex = 3;
            this.pictMinimizar.TabStop = false;
            this.pictMinimizar.Click += new System.EventHandler(this.pictMinimizar_Click);
            // 
            // pictRestaurar
            // 
            this.pictRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictRestaurar.BackgroundImage = global::Sistema_Hotel.Properties.Resources.Restore_Window_2_48px1;
            this.pictRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRestaurar.Location = new System.Drawing.Point(1020, 13);
            this.pictRestaurar.Name = "pictRestaurar";
            this.pictRestaurar.Size = new System.Drawing.Size(30, 30);
            this.pictRestaurar.TabIndex = 2;
            this.pictRestaurar.TabStop = false;
            this.pictRestaurar.Visible = false;
            this.pictRestaurar.Click += new System.EventHandler(this.pictRestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema_Hotel.Properties.Resources._001_hotel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnsMoverFormulario;
            this.Name = "frmMenu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu_Principal";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.SidebarWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRegistrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTipoHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEstadoHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMazimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictSalir;
        private System.Windows.Forms.PictureBox pictMazimizar;
        private System.Windows.Forms.PictureBox pictMinimizar;
        private System.Windows.Forms.PictureBox pictRestaurar;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictCliente;
        private System.Windows.Forms.PictureBox pictTipoHabitacion;
        private System.Windows.Forms.PictureBox pictEstadoHabitacion;
        private System.Windows.Forms.PictureBox pictRegistrador;
        private System.Windows.Forms.PictureBox pictGastos;
        private System.Windows.Forms.PictureBox pictReserva;
        private System.Windows.Forms.PictureBox pictHabitacion;
        private System.Windows.Forms.MenuStrip mnsMoverFormulario;
    }
}