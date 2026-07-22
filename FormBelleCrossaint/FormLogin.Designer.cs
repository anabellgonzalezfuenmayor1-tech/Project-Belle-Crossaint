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
            pVisible = new PictureBox();
            lblTitulo = new Label();
            lblCrearCuenta = new Label();
            lblOlvidarContrasena = new Label();
            btnLogin = new Button();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            pLogo = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pImagen).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pVisible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // pImagen
            // 
            pImagen.Image = (Image)resources.GetObject("pImagen.Image");
            pImagen.Location = new Point(-3, -1);
            pImagen.Name = "pImagen";
            pImagen.Size = new Size(605, 650);
            pImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            pImagen.TabIndex = 0;
            pImagen.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(pVisible);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(lblCrearCuenta);
            panelLogin.Controls.Add(lblOlvidarContrasena);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(lblContrasena);
            panelLogin.Controls.Add(txtContrasena);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(pLogo);
            panelLogin.Location = new Point(702, 85);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(409, 485);
            panelLogin.TabIndex = 1;
            // 
            // pVisible
            // 
            pVisible.Image = (Image)resources.GetObject("pVisible.Image");
            pVisible.Location = new Point(346, 298);
            pVisible.Name = "pVisible";
            pVisible.Size = new Size(27, 27);
            pVisible.SizeMode = PictureBoxSizeMode.StretchImage;
            pVisible.TabIndex = 2;
            pVisible.TabStop = false;
            pVisible.Click += pVisible_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.WhiteSmoke;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 48, 51);
            lblTitulo.Location = new Point(46, 127);
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
            lblCrearCuenta.Location = new Point(279, 396);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(94, 20);
            lblCrearCuenta.TabIndex = 6;
            lblCrearCuenta.Text = "Crear Cuenta";
            // 
            // lblOlvidarContrasena
            // 
            lblOlvidarContrasena.AutoSize = true;
            lblOlvidarContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblOlvidarContrasena.ForeColor = Color.FromArgb(74, 81, 60);
            lblOlvidarContrasena.Location = new Point(40, 396);
            lblOlvidarContrasena.Name = "lblOlvidarContrasena";
            lblOlvidarContrasena.Size = new Size(172, 20);
            lblOlvidarContrasena.TabIndex = 5;
            lblOlvidarContrasena.Text = "¿Olvidaste tu contraseña?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(74, 81, 60);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 359);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(333, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
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
            // 
            // pLogo
            // 
            pLogo.Image = (Image)resources.GetObject("pLogo.Image");
            pLogo.Location = new Point(132, 19);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(146, 105);
            pLogo.TabIndex = 2;
            pLogo.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(0, 0);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1195, 649);
            Controls.Add(maskedTextBox1);
            Controls.Add(panelLogin);
            Controls.Add(pImagen);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pImagen).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pVisible).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pImagen;
        private Panel panelLogin;
        private PictureBox pLogo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btnLogin;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblCrearCuenta;
        private Label lblOlvidarContrasena;
        private Label lblTitulo;
        private PictureBox pVisible;
        private MaskedTextBox maskedTextBox1;
    }
}
