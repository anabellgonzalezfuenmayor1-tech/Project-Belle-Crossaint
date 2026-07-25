namespace FormBelleCrossaint
{
    partial class FormCorreoRecuperacion
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
            panelLogin = new Panel();
            lblVolverlInicio = new Label();
            lblTitulo = new Label();
            btnAceptar = new Button();
            lblContrasena = new Label();
            txtCorreo = new TextBox();
            lblDescripcion = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblVolverlInicio);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(btnAceptar);
            panelLogin.Controls.Add(lblContrasena);
            panelLogin.Controls.Add(txtCorreo);
            panelLogin.Controls.Add(lblDescripcion);
            panelLogin.Location = new Point(196, 32);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(409, 290);
            panelLogin.TabIndex = 2;
            // 
            // lblVolverlInicio
            // 
            lblVolverlInicio.AutoSize = true;
            lblVolverlInicio.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblVolverlInicio.ForeColor = Color.FromArgb(145, 128, 70);
            lblVolverlInicio.Location = new Point(29, 229);
            lblVolverlInicio.Name = "lblVolverlInicio";
            lblVolverlInicio.Size = new Size(147, 20);
            lblVolverlInicio.TabIndex = 6;
            lblVolverlInicio.Text = "Volver al inicio sesion";
            lblVolverlInicio.Click += lblVolverlInicio_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.WhiteSmoke;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 48, 51);
            lblTitulo.Location = new Point(29, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(355, 41);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "¿Olvidaste tu contraseña?";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(145, 128, 70);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(215, 219);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(158, 34);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(31, 114);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(57, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = SystemColors.WindowFrame;
            txtCorreo.Location = new Point(31, 137);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(342, 27);
            txtCorreo.TabIndex = 2;
            txtCorreo.UseSystemPasswordChar = true;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = SystemColors.ControlDark;
            lblDescripcion.Location = new Point(55, 57);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(294, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Ingresa tu usuario para recuperar contraseña";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCorreoRecuperacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 354);
            Controls.Add(panelLogin);
            Name = "FormCorreoRecuperacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Correo Recuperacion";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lblTitulo;
        private Button btnAceptar;
        private Label lblContrasena;
        private TextBox txtCorreo;
        private Label lblDescripcion;
        private Label lblVolverlInicio;
    }
}