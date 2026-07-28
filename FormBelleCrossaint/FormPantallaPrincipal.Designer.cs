namespace FormBelleCrossaint
{
    partial class FormPantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantallaPrincipal));
            PanelMenu = new Panel();
            btnCerrarSesion = new Button();
            btnHistorialPedido = new Button();
            btnPerfil = new Button();
            lblTitulo = new Label();
            pLogo = new PictureBox();
            PanelContenido = new Panel();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(215, 229, 177);
            PanelMenu.Controls.Add(btnCerrarSesion);
            PanelMenu.Controls.Add(btnHistorialPedido);
            PanelMenu.Controls.Add(btnPerfil);
            PanelMenu.Controls.Add(lblTitulo);
            PanelMenu.Controls.Add(pLogo);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(250, 702);
            PanelMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(12, 251);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(219, 29);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnHistorialPedido
            // 
            btnHistorialPedido.BackColor = Color.Transparent;
            btnHistorialPedido.FlatAppearance.BorderSize = 0;
            btnHistorialPedido.FlatStyle = FlatStyle.Flat;
            btnHistorialPedido.Location = new Point(12, 198);
            btnHistorialPedido.Name = "btnHistorialPedido";
            btnHistorialPedido.Size = new Size(219, 29);
            btnHistorialPedido.TabIndex = 5;
            btnHistorialPedido.Text = "Historial Pedidos";
            btnHistorialPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorialPedido.UseVisualStyleBackColor = false;
            btnHistorialPedido.Click += btnHistorialPedido_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Location = new Point(12, 150);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(219, 29);
            btnPerfil.TabIndex = 0;
            btnPerfil.Text = "Perfil";
            btnPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(44, 48, 51);
            lblTitulo.Location = new Point(29, 114);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(192, 23);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Belle Crossaint Lyonnis";
            // 
            // pLogo
            // 
            pLogo.Image = (Image)resources.GetObject("pLogo.Image");
            pLogo.Location = new Point(47, 9);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(152, 102);
            pLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pLogo.TabIndex = 3;
            pLogo.TabStop = false;
            // 
            // PanelContenido
            // 
            PanelContenido.Dock = DockStyle.Fill;
            PanelContenido.Location = new Point(250, 0);
            PanelContenido.Name = "PanelContenido";
            PanelContenido.Size = new Size(556, 702);
            PanelContenido.TabIndex = 0;
            // 
            // FormPantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 702);
            Controls.Add(PanelContenido);
            Controls.Add(PanelMenu);
            Name = "FormPantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelContenido;
        private PictureBox pLogo;
        private Button btnPerfil;
        private Label lblTitulo;
        private Button btnCerrarSesion;
        private Button btnHistorialPedido;
    }
}