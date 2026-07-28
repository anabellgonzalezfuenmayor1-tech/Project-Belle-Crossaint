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
    public partial class UserControlPerfil : UserControl
    {
        Usuario usuario;
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public UserControlPerfil(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            cargarDatos();
        }
        private void habilitacionDatos()
        {
            txtNombre.Enabled = !(txtNombre.Enabled);
            txtApellido.Enabled = !(txtApellido.Enabled);
            txtCorreo.Enabled = !(txtCorreo.Enabled);
            txtNumero.Enabled = !(txtNumero.Enabled);
            CBoxSubCorreo.Enabled = !(CBoxSubCorreo.Enabled);
            CBoxEntrega.Enabled = !(CBoxEntrega.Enabled);
            CboxRecogida.Enabled = !(CboxRecogida.Enabled);

            if (btnEdit.Text == "Editar Perfil")
            {
                btnEdit.Text = "Guardar Cambios";
            }
            else
            {
                int? metodoEntrega = null;
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de guardar los cambios.", "Campos incompletos");
                    return;
                }
                if(CBoxEntrega.Checked)
                {
                    metodoEntrega = 2;
                }
                else if (CboxRecogida.Checked)
                {
                    metodoEntrega = 1;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un método de entrega.", "Método de entrega no seleccionado");
                    return;
                }
                btnEdit.Text = "Editar Perfil";
                usuarioDAO.ActualizarUsuario(txtCorreo.Text, txtNombre.Text, txtApellido.Text,  txtNumero.Text, CBoxSubCorreo.Checked, metodoEntrega, usuario.Id);
            }
        }
        // cargar datos
        private void cargarDatos()
        {
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtCorreo.Text = usuario.Correo;
            txtNumero.Text = usuario.NTelefono;

            if(usuario.MetodoEntrega == "Entrega")
            {
                CBoxEntrega.Checked = true;
                CboxRecogida.Checked = false;
            }
            else
            {
                CBoxEntrega.Checked = false;
                CboxRecogida.Checked = true;
            }
            CBoxSubCorreo.Checked = usuario.SuscritoCorreo;
        }

        private void UserControlPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(usuario.PathPerfil);
                pPerfil.Image = Image.FromFile(usuario.PathPerfil);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen de perfil: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            habilitacionDatos();
        }
    }
}
