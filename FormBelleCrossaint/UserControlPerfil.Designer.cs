namespace FormBelleCrossaint
{
    partial class UserControlPerfil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            CboxRecogida = new RadioButton();
            lblEntrega = new Label();
            label3 = new Label();
            txtNumero = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            CBoxEntrega = new RadioButton();
            CBoxSubCorreo = new CheckBox();
            btnEdit = new Button();
            pPerfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pPerfil).BeginInit();
            SuspendLayout();
            // 
            // CboxRecogida
            // 
            CboxRecogida.AutoSize = true;
            CboxRecogida.Enabled = false;
            CboxRecogida.Location = new Point(373, 383);
            CboxRecogida.Name = "CboxRecogida";
            CboxRecogida.Size = new Size(89, 24);
            CboxRecogida.TabIndex = 26;
            CboxRecogida.TabStop = true;
            CboxRecogida.Text = "recogida";
            CboxRecogida.UseVisualStyleBackColor = true;
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Location = new Point(106, 383);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(118, 20);
            lblEntrega.TabIndex = 25;
            lblEntrega.Text = "Tipo de entrega:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 335);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 23;
            label3.Text = "Numero Telefono:";
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Location = new Point(263, 332);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(199, 27);
            txtNumero.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 290);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 21;
            label4.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(263, 287);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(199, 27);
            txtCorreo.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 240);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 19;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(263, 233);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(199, 27);
            txtApellido.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 191);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 14;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(263, 184);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 27);
            txtNombre.TabIndex = 15;
            // 
            // CBoxEntrega
            // 
            CBoxEntrega.AutoSize = true;
            CBoxEntrega.Enabled = false;
            CBoxEntrega.Location = new Point(263, 381);
            CBoxEntrega.Name = "CBoxEntrega";
            CBoxEntrega.Size = new Size(81, 24);
            CBoxEntrega.TabIndex = 16;
            CBoxEntrega.TabStop = true;
            CBoxEntrega.Text = "Entrega";
            CBoxEntrega.UseVisualStyleBackColor = true;
            // 
            // CBoxSubCorreo
            // 
            CBoxSubCorreo.AutoSize = true;
            CBoxSubCorreo.Enabled = false;
            CBoxSubCorreo.Location = new Point(106, 431);
            CBoxSubCorreo.Name = "CBoxSubCorreo";
            CBoxSubCorreo.Size = new Size(236, 24);
            CBoxSubCorreo.TabIndex = 17;
            CBoxSubCorreo.Text = "Subcripcion a la lista de correo";
            CBoxSubCorreo.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(106, 479);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(356, 29);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Editar Perfil";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // pPerfil
            // 
            pPerfil.Location = new Point(193, 25);
            pPerfil.Name = "pPerfil";
            pPerfil.Size = new Size(192, 138);
            pPerfil.TabIndex = 27;
            pPerfil.TabStop = false;
            // 
            // UserControlPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pPerfil);
            Controls.Add(CboxRecogida);
            Controls.Add(lblEntrega);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(label4);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(CBoxEntrega);
            Controls.Add(CBoxSubCorreo);
            Controls.Add(btnEdit);
            Name = "UserControlPerfil";
            Size = new Size(587, 648);
            Load += UserControlPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)pPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton CboxRecogida;
        private Label lblEntrega;
        private Label label3;
        private TextBox txtNumero;
        private Label label4;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private RadioButton CBoxEntrega;
        private CheckBox CBoxSubCorreo;
        private Button btnEdit;
        private PictureBox pPerfil;
    }
}
