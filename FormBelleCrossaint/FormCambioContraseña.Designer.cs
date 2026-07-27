namespace FormBelleCrossaint
{
    partial class FormCambioContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambioContraseña));
            panelLogin = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtVerificacionContraseña = new TextBox();
            pVisible = new PictureBox();
            lblContrasena = new Label();
            txtContrasenaNueva = new TextBox();
            lblTitulo = new Label();
            btnAceptar = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pVisible).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(txtVerificacionContraseña);
            panelLogin.Controls.Add(pVisible);
            panelLogin.Controls.Add(lblContrasena);
            panelLogin.Controls.Add(txtContrasenaNueva);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(btnAceptar);
            panelLogin.Location = new Point(198, 26);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(409, 295);
            panelLogin.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 158);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 12;
            label1.Text = "Verificacion de la contraseña:";
            // 
            // txtVerificacionContraseña
            // 
            txtVerificacionContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtVerificacionContraseña.ForeColor = SystemColors.WindowFrame;
            txtVerificacionContraseña.Location = new Point(43, 181);
            txtVerificacionContraseña.Name = "txtVerificacionContraseña";
            txtVerificacionContraseña.Size = new Size(292, 27);
            txtVerificacionContraseña.TabIndex = 11;
            txtVerificacionContraseña.UseSystemPasswordChar = true;
            // 
            // pVisible
            // 
            pVisible.Image = (Image)resources.GetObject("pVisible.Image");
            pVisible.Location = new Point(349, 103);
            pVisible.Name = "pVisible";
            pVisible.Size = new Size(27, 27);
            pVisible.SizeMode = PictureBoxSizeMode.StretchImage;
            pVisible.TabIndex = 7;
            pVisible.TabStop = false;
            pVisible.Click += pVisible_Click;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(43, 80);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(132, 20);
            lblContrasena.TabIndex = 9;
            lblContrasena.Text = "Nueva Contraseña:";
            // 
            // txtContrasenaNueva
            // 
            txtContrasenaNueva.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenaNueva.ForeColor = SystemColors.WindowFrame;
            txtContrasenaNueva.Location = new Point(43, 103);
            txtContrasenaNueva.Name = "txtContrasenaNueva";
            txtContrasenaNueva.Size = new Size(292, 27);
            txtContrasenaNueva.TabIndex = 8;
            txtContrasenaNueva.UseSystemPasswordChar = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.WhiteSmoke;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 48, 51);
            lblTitulo.Location = new Point(75, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 41);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Nueva Contraseña";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(145, 128, 70);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(43, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(333, 34);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormCambioContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(panelLogin);
            Name = "FormCambioContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambio de contraseña";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pVisible).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lblTitulo;
        private Button btnAceptar;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtVerificacionContraseña;
        private PictureBox pVisible;
        private Label lblContrasena;
        private TextBox txtContrasenaNueva;
    }
}