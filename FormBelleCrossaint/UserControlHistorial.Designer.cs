namespace FormBelleCrossaint
{
    partial class UserControlHistorial
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
            lblTitulo = new Label();
            btnAgregarDireccion = new Button();
            dgvDirecciones = new DataGridView();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDirecciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F);
            lblTitulo.ForeColor = Color.SeaGreen;
            lblTitulo.Location = new Point(15, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Administrador direcciones:";
            // 
            // btnAgregarDireccion
            // 
            btnAgregarDireccion.Location = new Point(426, 28);
            btnAgregarDireccion.Name = "btnAgregarDireccion";
            btnAgregarDireccion.Size = new Size(94, 29);
            btnAgregarDireccion.TabIndex = 1;
            btnAgregarDireccion.Text = "+";
            btnAgregarDireccion.UseVisualStyleBackColor = true;
            // 
            // dgvDirecciones
            // 
            dgvDirecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirecciones.Location = new Point(15, 63);
            dgvDirecciones.Name = "dgvDirecciones";
            dgvDirecciones.RowHeadersWidth = 51;
            dgvDirecciones.Size = new Size(505, 208);
            dgvDirecciones.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(15, 331);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 3;
            label1.Text = "Historial Pedidos:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(505, 208);
            dataGridView1.TabIndex = 4;
            // 
            // UserControlHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(dgvDirecciones);
            Controls.Add(btnAgregarDireccion);
            Controls.Add(lblTitulo);
            Name = "UserControlHistorial";
            Size = new Size(550, 705);
            ((System.ComponentModel.ISupportInitialize)dgvDirecciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAgregarDireccion;
        private DataGridView dgvDirecciones;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
