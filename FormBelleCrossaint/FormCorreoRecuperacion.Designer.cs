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
            lblTitulo = new Label();
            btnLogin = new Button();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            button1 = new Button();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(lblContrasena);
            panelLogin.Controls.Add(txtContrasena);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Location = new Point(196, 32);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(409, 290);
            panelLogin.TabIndex = 2;
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
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(74, 81, 60);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(215, 219);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
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
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.ForeColor = SystemColors.WindowFrame;
            txtContrasena.Location = new Point(31, 137);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(342, 27);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ControlDark;
            lblUsuario.Location = new Point(55, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(294, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Ingresa tu usuario para recuperar contraseña";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(31, 219);
            button1.Name = "button1";
            button1.Size = new Size(158, 34);
            button1.TabIndex = 4;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormCorreoRecuperacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 354);
            Controls.Add(panelLogin);
            Name = "FormCorreoRecuperacion";
            Text = "Correo Recuperacion";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Button button1;
        private Label lblTitulo;
        private Button btnLogin;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblUsuario;
    }
}