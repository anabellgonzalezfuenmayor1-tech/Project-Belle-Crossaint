namespace FormBelleCrossaint
{
    partial class FormCrearCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCuenta));
            pVisibleC = new PictureBox();
            lblTitulo = new Label();
            lblInicioSesion = new Label();
            btnCrearCuenta = new Button();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            pVisibleCC = new PictureBox();
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
            lblPregunta = new Label();
            cBoxPreguntasSeguridad = new ComboBox();
            lblRespuesta = new Label();
            txtRespuesta = new TextBox();
            pictureBox2 = new PictureBox();
            txtApellido = new TextBox();
            cBoxSubcripcion = new CheckBox();
            pLogo = new PictureBox();
            lblCoincidencia1 = new Label();
            lblCoincidencia2 = new Label();
            lblUsuarioExistente = new Label();
            ((System.ComponentModel.ISupportInitialize)pVisibleC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pVisibleCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // pVisibleC
            // 
            pVisibleC.Image = (Image)resources.GetObject("pVisibleC.Image");
            pVisibleC.Location = new Point(438, 310);
            pVisibleC.Name = "pVisibleC";
            pVisibleC.Size = new Size(27, 27);
            pVisibleC.SizeMode = PictureBoxSizeMode.StretchImage;
            pVisibleC.TabIndex = 2;
            pVisibleC.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 48, 51);
            lblTitulo.Location = new Point(265, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 41);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Crear Cuenta";
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblInicioSesion.ForeColor = Color.FromArgb(74, 81, 60);
            lblInicioSesion.Location = new Point(69, 641);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(208, 20);
            lblInicioSesion.TabIndex = 5;
            lblInicioSesion.Text = "¿Ya tienes cuenta? Inicia Sesion";
            lblInicioSesion.Click += lblInicioSesion_Click;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.FromArgb(112, 120, 78);
            btnCrearCuenta.ForeColor = Color.White;
            btnCrearCuenta.Location = new Point(69, 601);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(400, 34);
            btnCrearCuenta.TabIndex = 3;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.ForeColor = Color.FromArgb(143, 55, 48);
            lblContrasena.Location = new Point(69, 287);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(89, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña*";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.ForeColor = SystemColors.WindowFrame;
            txtContrasena.Location = new Point(69, 310);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(363, 27);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.FromArgb(143, 55, 48);
            lblNombre.Location = new Point(69, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre*";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(69, 173);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.ForeColor = Color.FromArgb(143, 55, 48);
            lblApellido.Location = new Point(275, 150);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 20);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido*";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.ForeColor = Color.FromArgb(143, 55, 48);
            lblCorreo.Location = new Point(69, 216);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(60, 20);
            lblCorreo.TabIndex = 12;
            lblCorreo.Text = "Correo*";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = SystemColors.WindowFrame;
            txtCorreo.Location = new Point(69, 239);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(396, 27);
            txtCorreo.TabIndex = 11;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // pVisibleCC
            // 
            pVisibleCC.Image = (Image)resources.GetObject("pVisibleCC.Image");
            pVisibleCC.Location = new Point(438, 385);
            pVisibleCC.Name = "pVisibleCC";
            pVisibleCC.Size = new Size(27, 27);
            pVisibleCC.SizeMode = PictureBoxSizeMode.StretchImage;
            pVisibleCC.TabIndex = 13;
            pVisibleCC.TabStop = false;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.BackColor = Color.Transparent;
            lblConfirmarContrasena.ForeColor = Color.FromArgb(143, 55, 48);
            lblConfirmarContrasena.Location = new Point(69, 362);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(159, 20);
            lblConfirmarContrasena.TabIndex = 15;
            lblConfirmarContrasena.Text = "Confirmar Contraseña*";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContrasena.ForeColor = SystemColors.WindowFrame;
            txtConfirmarContrasena.Location = new Point(69, 385);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(363, 27);
            txtConfirmarContrasena.TabIndex = 14;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.TextChanged += txtConfirmarContrasena_TextChanged;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Transparent;
            lblPregunta.ForeColor = Color.FromArgb(44, 48, 51);
            lblPregunta.Location = new Point(69, 434);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(159, 20);
            lblPregunta.TabIndex = 16;
            lblPregunta.Text = "Pregunta de seguridad";
            // 
            // cBoxPreguntasSeguridad
            // 
            cBoxPreguntasSeguridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPreguntasSeguridad.FormattingEnabled = true;
            cBoxPreguntasSeguridad.Location = new Point(69, 457);
            cBoxPreguntasSeguridad.Name = "cBoxPreguntasSeguridad";
            cBoxPreguntasSeguridad.Size = new Size(396, 28);
            cBoxPreguntasSeguridad.TabIndex = 17;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.BackColor = Color.Transparent;
            lblRespuesta.ForeColor = Color.FromArgb(143, 55, 48);
            lblRespuesta.Location = new Point(69, 503);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(232, 20);
            lblRespuesta.TabIndex = 19;
            lblRespuesta.Text = "Digite su respuesta de seguridad*";
            // 
            // txtRespuesta
            // 
            txtRespuesta.BorderStyle = BorderStyle.FixedSingle;
            txtRespuesta.ForeColor = SystemColors.WindowFrame;
            txtRespuesta.Location = new Point(69, 526);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(396, 27);
            txtRespuesta.TabIndex = 18;
            txtRespuesta.TextChanged += txtRespuesta_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 692);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = SystemColors.WindowFrame;
            txtApellido.Location = new Point(275, 173);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 27);
            txtApellido.TabIndex = 21;
            txtApellido.TextChanged += txtApellido_TextChanged;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // cBoxSubcripcion
            // 
            cBoxSubcripcion.AutoSize = true;
            cBoxSubcripcion.BackColor = Color.Transparent;
            cBoxSubcripcion.Location = new Point(73, 571);
            cBoxSubcripcion.Name = "cBoxSubcripcion";
            cBoxSubcripcion.Size = new Size(225, 24);
            cBoxSubcripcion.TabIndex = 22;
            cBoxSubcripcion.Text = "Subcribirse a la lista de email";
            cBoxSubcripcion.UseVisualStyleBackColor = false;
            // 
            // pLogo
            // 
            pLogo.Image = (Image)resources.GetObject("pLogo.Image");
            pLogo.Location = new Point(63, 12);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(196, 120);
            pLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pLogo.TabIndex = 23;
            pLogo.TabStop = false;
            // 
            // lblCoincidencia1
            // 
            lblCoincidencia1.AutoSize = true;
            lblCoincidencia1.ForeColor = Color.FromArgb(143, 55, 48);
            lblCoincidencia1.Location = new Point(264, 287);
            lblCoincidencia1.Name = "lblCoincidencia1";
            lblCoincidencia1.Size = new Size(201, 20);
            lblCoincidencia1.TabIndex = 24;
            lblCoincidencia1.Text = "Las contraseñas no coinciden";
            lblCoincidencia1.Visible = false;
            // 
            // lblCoincidencia2
            // 
            lblCoincidencia2.AutoSize = true;
            lblCoincidencia2.ForeColor = Color.FromArgb(143, 55, 48);
            lblCoincidencia2.Location = new Point(268, 362);
            lblCoincidencia2.Name = "lblCoincidencia2";
            lblCoincidencia2.Size = new Size(201, 20);
            lblCoincidencia2.TabIndex = 25;
            lblCoincidencia2.Text = "Las contraseñas no coinciden";
            lblCoincidencia2.Visible = false;
            // 
            // lblUsuarioExistente
            // 
            lblUsuarioExistente.AutoSize = true;
            lblUsuarioExistente.ForeColor = Color.FromArgb(143, 55, 48);
            lblUsuarioExistente.Location = new Point(347, 216);
            lblUsuarioExistente.Name = "lblUsuarioExistente";
            lblUsuarioExistente.Size = new Size(122, 20);
            lblUsuarioExistente.TabIndex = 26;
            lblUsuarioExistente.Text = "Usuario existente";
            // 
            // FormCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 692);
            Controls.Add(lblUsuarioExistente);
            Controls.Add(lblCoincidencia2);
            Controls.Add(lblCoincidencia1);
            Controls.Add(pLogo);
            Controls.Add(cBoxSubcripcion);
            Controls.Add(txtApellido);
            Controls.Add(lblRespuesta);
            Controls.Add(txtRespuesta);
            Controls.Add(cBoxPreguntasSeguridad);
            Controls.Add(lblPregunta);
            Controls.Add(txtNombre);
            Controls.Add(pVisibleCC);
            Controls.Add(lblNombre);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(lblCorreo);
            Controls.Add(btnCrearCuenta);
            Controls.Add(txtCorreo);
            Controls.Add(lblInicioSesion);
            Controls.Add(lblApellido);
            Controls.Add(lblTitulo);
            Controls.Add(pVisibleC);
            Controls.Add(pictureBox2);
            Name = "FormCrearCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrearCuenta";
            ((System.ComponentModel.ISupportInitialize)pVisibleC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pVisibleCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPregunta;
        private PictureBox pVisibleCC;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblApellido;
        private PictureBox pVisibleC;
        private Label lblTitulo;
        private Label lblInicioSesion;
        private Button btnCrearCuenta;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblRespuesta;
        private TextBox txtRespuesta;
        private ComboBox cBoxPreguntasSeguridad;
        private PictureBox pictureBox2;
        private TextBox txtApellido;
        private CheckBox cBoxSubcripcion;
        private PictureBox pLogo;
        private Label lblCoincidencia1;
        private Label lblCoincidencia2;
        private Label lblUsuarioExistente;
    }
}