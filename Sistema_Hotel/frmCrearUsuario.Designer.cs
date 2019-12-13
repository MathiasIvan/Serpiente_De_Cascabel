namespace Sistema_Hotel
{
    partial class frmCrearUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.gbxCrearUsuario = new System.Windows.Forms.GroupBox();
            this.pictCrearUsuario = new System.Windows.Forms.PictureBox();
            this.mnsMoverFormulario = new System.Windows.Forms.MenuStrip();
            this.gbxCrearUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCrearUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 251);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(73, 248);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(154, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(13, 343);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(104, 30);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(10, 300);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(83, 17);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña :";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(123, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(99, 297);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(128, 22);
            this.txtContraseña.TabIndex = 3;
            // 
            // gbxCrearUsuario
            // 
            this.gbxCrearUsuario.Controls.Add(this.pictCrearUsuario);
            this.gbxCrearUsuario.Controls.Add(this.txtContraseña);
            this.gbxCrearUsuario.Controls.Add(this.lblUsuario);
            this.gbxCrearUsuario.Controls.Add(this.btnSalir);
            this.gbxCrearUsuario.Controls.Add(this.txtUsuario);
            this.gbxCrearUsuario.Controls.Add(this.lblContraseña);
            this.gbxCrearUsuario.Controls.Add(this.btnCrear);
            this.gbxCrearUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCrearUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbxCrearUsuario.Name = "gbxCrearUsuario";
            this.gbxCrearUsuario.Size = new System.Drawing.Size(241, 394);
            this.gbxCrearUsuario.TabIndex = 0;
            this.gbxCrearUsuario.TabStop = false;
            this.gbxCrearUsuario.Text = "Crear Usuario";
            // 
            // pictCrearUsuario
            // 
            this.pictCrearUsuario.BackgroundImage = global::Sistema_Hotel.Properties.Resources._1__1_;
            this.pictCrearUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictCrearUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictCrearUsuario.Location = new System.Drawing.Point(13, 26);
            this.pictCrearUsuario.Name = "pictCrearUsuario";
            this.pictCrearUsuario.Size = new System.Drawing.Size(214, 208);
            this.pictCrearUsuario.TabIndex = 6;
            this.pictCrearUsuario.TabStop = false;
            // 
            // mnsMoverFormulario
            // 
            this.mnsMoverFormulario.BackColor = System.Drawing.Color.Transparent;
            this.mnsMoverFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnsMoverFormulario.Location = new System.Drawing.Point(0, 0);
            this.mnsMoverFormulario.Name = "mnsMoverFormulario";
            this.mnsMoverFormulario.Size = new System.Drawing.Size(265, 425);
            this.mnsMoverFormulario.TabIndex = 1;
            this.mnsMoverFormulario.Text = "menuStrip1";
            this.mnsMoverFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnsMoverFormulario_MouseDown);
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 425);
            this.Controls.Add(this.gbxCrearUsuario);
            this.Controls.Add(this.mnsMoverFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.gbxCrearUsuario.ResumeLayout(false);
            this.gbxCrearUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCrearUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.GroupBox gbxCrearUsuario;
        private System.Windows.Forms.PictureBox pictCrearUsuario;
        private System.Windows.Forms.MenuStrip mnsMoverFormulario;
    }
}