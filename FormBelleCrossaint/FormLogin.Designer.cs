namespace FormBelleCrossaint
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pImagen = new PictureBox();
            panelLogin = new Panel();
            lblNoExiste = new Label();
            lblIncorrecto = new Label();
            pVisibleC = new PictureBox();
            pLogo = new PictureBox();
            lblTitulo = new Label();
            lblCrearCuenta = new Label();
            lblOlvidarContrasena = new Label();
            btnLogin = new Button();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pImagen).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pVisibleC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // pImagen
            // 
            pImagen.Dock = DockStyle.Left;
            pImagen.Image = (Image)resources.GetObject("pImagen.Image");
            pImagen.Location = new Point(0, 0);
            pImagen.Name = "pImagen";
            pImagen.Size = new Size(605, 649);
            pImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            pImagen.TabIndex = 0;
            pImagen.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(248, 243, 238);
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblNoExiste);
            panelLogin.Controls.Add(lblIncorrecto);
            panelLogin.Controls.Add(pVisibleC);
            panelLogin.Controls.Add(pLogo);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(lblCrearCuenta);
            panelLogin.Controls.Add(lblOlvidarContrasena);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(lblContrasena);
            panelLogin.Controls.Add(txtContrasena);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Location = new Point(702, 85);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(409, 485);
            panelLogin.TabIndex = 1;
            // 
            // lblNoExiste
            // 
            lblNoExiste.AutoSize = true;
            lblNoExiste.ForeColor = Color.FromArgb(143, 55, 48);
            lblNoExiste.Location = new Point(230, 197);
            lblNoExiste.Name = "lblNoExiste";
            lblNoExiste.Size = new Size(143, 20);
            lblNoExiste.TabIndex = 9;
            lblNoExiste.Text = "Usuario no existente";
            lblNoExiste.Visible = false;
            // 
            // lblIncorrecto
            // 
            lblIncorrecto.AutoSize = true;
            lblIncorrecto.ForeColor = Color.FromArgb(143, 55, 48);
            lblIncorrecto.Location = new Point(40, 328);
            lblIncorrecto.Name = "lblIncorrecto";
            lblIncorrecto.Size = new Size(219, 20);
            lblIncorrecto.TabIndex = 2;
            lblIncorrecto.Text = "Contraseña o usuario incorrecto";
            lblIncorrecto.Visible = false;
            // 
            // pVisibleC
            // 
            pVisibleC.Image = (Image)resources.GetObject("pVisibleC.Image");
            pVisibleC.Location = new Point(346, 298);
            pVisibleC.Name = "pVisibleC";
            pVisibleC.Size = new Size(27, 27);
            pVisibleC.SizeMode = PictureBoxSizeMode.StretchImage;
            pVisibleC.TabIndex = 8;
            pVisibleC.TabStop = false;
            pVisibleC.Click += pVisibleC_Click;
            // 
            // pLogo
            // 
            pLogo.Image = (Image)resources.GetObject("pLogo.Image");
            pLogo.Location = new Point(112, 4);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(192, 120);
            pLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pLogo.TabIndex = 7;
            pLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.WhiteSmoke;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 48, 51);
            lblTitulo.Location = new Point(48, 127);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(319, 41);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Belle Crossaint Lyonnis";
            // 
            // lblCrearCuenta
            // 
            lblCrearCuenta.AutoSize = true;
            lblCrearCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblCrearCuenta.ForeColor = Color.FromArgb(74, 81, 60);
            lblCrearCuenta.Location = new Point(279, 400);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(94, 20);
            lblCrearCuenta.TabIndex = 6;
            lblCrearCuenta.Text = "Crear Cuenta";
            lblCrearCuenta.Click += lblCrearCuenta_Click;
            // 
            // lblOlvidarContrasena
            // 
            lblOlvidarContrasena.AutoSize = true;
            lblOlvidarContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblOlvidarContrasena.ForeColor = Color.FromArgb(74, 81, 60);
            lblOlvidarContrasena.Location = new Point(40, 400);
            lblOlvidarContrasena.Name = "lblOlvidarContrasena";
            lblOlvidarContrasena.Size = new Size(172, 20);
            lblOlvidarContrasena.TabIndex = 5;
            lblOlvidarContrasena.Text = "¿Olvidaste tu contraseña?";
            lblOlvidarContrasena.Click += lblOlvidarContrasena_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(158, 139, 76);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 359);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(333, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(40, 275);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(86, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.ForeColor = SystemColors.WindowFrame;
            txtContrasena.Location = new Point(40, 298);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(292, 27);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(40, 197);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = SystemColors.WindowFrame;
            txtUsuario.Location = new Point(40, 220);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(333, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1195, 649);
            Controls.Add(panelLogin);
            Controls.Add(pImagen);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pImagen).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pVisibleC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pImagen;
        private Panel panelLogin;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btnLogin;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblCrearCuenta;
        private Label lblOlvidarContrasena;
        private Label lblTitulo;
        private PictureBox pLogo;
        private PictureBox pVisibleC;
        private Label lblIncorrecto;
        private Label lblNoExiste;
    }
}
