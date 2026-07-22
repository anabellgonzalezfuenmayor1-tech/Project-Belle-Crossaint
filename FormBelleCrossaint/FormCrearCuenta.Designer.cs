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
            pLogo = new PictureBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            pVisibleCC = new PictureBox();
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
            label5 = new Label();
            cBoxPreguntasSeguridad = new ComboBox();
            label6 = new Label();
            txtRespuesta = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pVisibleC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pVisibleCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pVisibleC
            // 
            pVisibleC.Image = (Image)resources.GetObject("pVisibleC.Image");
            pVisibleC.Location = new Point(392, 310);
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
            lblTitulo.Location = new Point(221, 50);
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
            lblInicioSesion.Location = new Point(69, 616);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(208, 20);
            lblInicioSesion.TabIndex = 5;
            lblInicioSesion.Text = "¿Ya tienes cuenta? Inicia Sesion";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.FromArgb(74, 81, 60);
            btnCrearCuenta.ForeColor = Color.White;
            btnCrearCuenta.Location = new Point(69, 576);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(350, 34);
            btnCrearCuenta.TabIndex = 3;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(69, 287);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(86, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.ForeColor = SystemColors.WindowFrame;
            txtContrasena.Location = new Point(69, 310);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(317, 27);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(68, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(69, 173);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 27);
            txtNombre.TabIndex = 1;
            // 
            // pLogo
            // 
            pLogo.Image = (Image)resources.GetObject("pLogo.Image");
            pLogo.Location = new Point(69, 19);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(146, 105);
            pLogo.TabIndex = 2;
            pLogo.TabStop = false;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(247, 150);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = SystemColors.WindowFrame;
            txtApellido.Location = new Point(247, 173);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(172, 27);
            txtApellido.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(69, 216);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 12;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = SystemColors.WindowFrame;
            txtCorreo.Location = new Point(69, 239);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(350, 27);
            txtCorreo.TabIndex = 11;
            // 
            // pVisibleCC
            // 
            pVisibleCC.Image = (Image)resources.GetObject("pVisibleCC.Image");
            pVisibleCC.Location = new Point(392, 385);
            pVisibleCC.Name = "pVisibleCC";
            pVisibleCC.Size = new Size(27, 27);
            pVisibleCC.SizeMode = PictureBoxSizeMode.StretchImage;
            pVisibleCC.TabIndex = 13;
            pVisibleCC.TabStop = false;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Location = new Point(69, 362);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(156, 20);
            lblConfirmarContrasena.TabIndex = 15;
            lblConfirmarContrasena.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContrasena.ForeColor = SystemColors.WindowFrame;
            txtConfirmarContrasena.Location = new Point(69, 385);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(317, 27);
            txtConfirmarContrasena.TabIndex = 14;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 434);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 16;
            label5.Text = "Pregunta de seguridad:";
            // 
            // cBoxPreguntasSeguridad
            // 
            cBoxPreguntasSeguridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxPreguntasSeguridad.FormattingEnabled = true;
            cBoxPreguntasSeguridad.Location = new Point(69, 457);
            cBoxPreguntasSeguridad.Name = "cBoxPreguntasSeguridad";
            cBoxPreguntasSeguridad.Size = new Size(350, 28);
            cBoxPreguntasSeguridad.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 503);
            label6.Name = "label6";
            label6.Size = new Size(229, 20);
            label6.TabIndex = 19;
            label6.Text = "Digite su respuesta de seguridad:";
            // 
            // txtRespuesta
            // 
            txtRespuesta.BorderStyle = BorderStyle.FixedSingle;
            txtRespuesta.ForeColor = SystemColors.WindowFrame;
            txtRespuesta.Location = new Point(69, 526);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(350, 27);
            txtRespuesta.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(806, 656);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // FormCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(label6);
            Controls.Add(txtRespuesta);
            Controls.Add(txtApellido);
            Controls.Add(cBoxPreguntasSeguridad);
            Controls.Add(pLogo);
            Controls.Add(label5);
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
            Text = "FormCrearCuenta";
            ((System.ComponentModel.ISupportInitialize)pVisibleC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pVisibleCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private PictureBox pVisibleCC;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblApellido;
        private TextBox txtApellido;
        private PictureBox pVisibleC;
        private Label lblTitulo;
        private Label lblInicioSesion;
        private Button btnCrearCuenta;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblNombre;
        private TextBox txtNombre;
        private PictureBox pLogo;
        private Label label6;
        private TextBox txtRespuesta;
        private ComboBox cBoxPreguntasSeguridad;
        private PictureBox pictureBox2;
    }
}