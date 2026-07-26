using clasesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormBelleCrossaint
{
    public partial class FormCorreoRecuperacion : Form
    {
        UsuarioDAO usuarioDAO = new();
        public FormCorreoRecuperacion()
        {
            InitializeComponent();
        }

        private void lblVolverlInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (usuarioDAO.correoExistente(txtCorreo.Text.ToLower()))
            {
                FormVerificacionUser formVerificacionUser = new FormVerificacionUser(txtCorreo.Text.ToLower());
                this.Visible = false;
                formVerificacionUser.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Correo electrónico no registrado");
            }

        }
    }
}
