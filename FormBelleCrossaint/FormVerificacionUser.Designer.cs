namespace FormBelleCrossaint
{
    partial class FormVerificacionUser
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
            lblVolverInicio = new Label();
            lblRespuesta = new Label();
            txtRespuesta = new TextBox();
            lblTitulo = new Label();
            btnAceptar = new Button();
            lblPregunta = new Label();
            txtPregunta = new TextBox();
            lblDescripcion = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblVolverInicio);
            panelLogin.Controls.Add(lblRespuesta);
            panelLogin.Controls.Add(txtRespuesta);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(btnAceptar);
            panelLogin.Controls.Add(lblPregunta);
            panelLogin.Controls.Add(txtPregunta);
            panelLogin.Controls.Add(lblDescripcion);
            panelLogin.Location = new Point(161, 21);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(463, 331);
            panelLogin.TabIndex = 3;
            // 
            // lblVolverInicio
            // 
            lblVolverInicio.AutoSize = true;
            lblVolverInicio.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblVolverInicio.ForeColor = Color.FromArgb(74, 81, 60);
            lblVolverInicio.Location = new Point(24, 289);
            lblVolverInicio.Name = "lblVolverInicio";
            lblVolverInicio.Size = new Size(147, 20);
            lblVolverInicio.TabIndex = 7;
            lblVolverInicio.Text = "Volver al inicio sesion";
            lblVolverInicio.Click += lblVolverInicio_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(26, 181);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(79, 20);
            lblRespuesta.TabIndex = 6;
            lblRespuesta.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            txtRespuesta.BorderStyle = BorderStyle.FixedSingle;
            txtRespuesta.ForeColor = SystemColors.WindowFrame;
            txtRespuesta.Location = new Point(26, 204);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(409, 27);
            txtRespuesta.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.WhiteSmoke;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 48, 51);
            lblTitulo.Location = new Point(37, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(392, 41);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Recuperacion de contraseña";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(74, 81, 60);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(277, 277);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(158, 34);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(26, 105);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(162, 20);
            lblPregunta.TabIndex = 3;
            lblPregunta.Text = "Pregunta de seguridad:";
            // 
            // txtPregunta
            // 
            txtPregunta.BorderStyle = BorderStyle.FixedSingle;
            txtPregunta.Enabled = false;
            txtPregunta.ForeColor = SystemColors.WindowFrame;
            txtPregunta.Location = new Point(26, 128);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.ReadOnly = true;
            txtPregunta.Size = new Size(409, 27);
            txtPregunta.TabIndex = 2;
            txtPregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = SystemColors.ControlDark;
            lblDescripcion.Location = new Point(24, 56);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(416, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Contesta la pregunta de seguridad para recuperar tu contraseña";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormVerificacionUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 373);
            Controls.Add(panelLogin);
            Name = "FormVerificacionUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregunta de seguridad";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lblTitulo;
        private Button btnAceptar;
        private Label lblDescripcion;
        private Label lblRespuesta;
        private TextBox txtRespuesta;
        private Label lblPregunta;
        private TextBox txtPregunta;
        private Label lblVolverInicio;
    }
}