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
    public partial class FormCambioContraseña : Form
    {
        UsuarioDAO usuarioDAO = new();
        private Usuario usuario;
        public FormCambioContraseña(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtContrasenaNueva.Text == txtVerificacionContraseña.Text)
            {
                usuarioDAO.ActualizarContrasena(usuario.Correo, txtContrasenaNueva.Text);
                MessageBox.Show("Contraseña actualizada correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
