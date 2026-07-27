using clasesDAO;
using mis_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormBelleCrossaint
{
    public partial class FormVerificacionUser : Form
    {
        UsuarioDAO usuarioDAO = new();

        private Usuario usuario;
        public FormVerificacionUser(string correo)
        {
            InitializeComponent();
            this.usuario = usuarioDAO.ObtenerUsuarioPorCorreo(correo);
            CargarPregunta();

        }
        public void CargarPregunta()
        {
            txtPregunta.Text = usuario.PreguntaSeguridad;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (BCrypt.Net.BCrypt.Verify(txtRespuesta.Text, usuario.RespuestaSeguridad))
            {
                FormCambioContraseña formCambioContraseña = new FormCambioContraseña(usuario);
                this.Visible = false;
                formCambioContraseña.ShowDialog();
                this.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }

        }

        private void lblVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
