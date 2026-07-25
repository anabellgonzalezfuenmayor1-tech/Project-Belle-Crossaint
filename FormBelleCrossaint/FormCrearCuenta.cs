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
    public partial class FormCrearCuenta : Form
    {
        PreguntasDAO preguntasDAO = new PreguntasDAO();
        public bool estadoSubcripcion = false;

        public FormCrearCuenta()
        {
            InitializeComponent();
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {
            try
            {
                cBoxPreguntasSeguridad.Items.Clear();
                var preguntas = preguntasDAO.GetPreguntas();
                foreach (var pregunta in preguntas)
                {
                    cBoxPreguntasSeguridad.Items.Add(pregunta.Pregunta);
                }
                cBoxPreguntasSeguridad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recorrer las preguntas", ex.Message);
            }
        }
        private void lblInicioSesion_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Close();
        }

        // obtener estado del checkbox de suscripcion
        private void cBoxSubcripcion_CheckedChanged(object sender, EventArgs e)
        {
            estadoSubcripcion = cBoxSubcripcion.Checked;
        }

        // verificacion de que las contraseñas coincidan
        private bool coincidenciaContrasenas()
        {
            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                return false;
            }
            return true;
        }

        // metodo para crear la cuenta del usuario
        private void creacionCuenta()
        {
            Usuario usuario = new Usuario()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                PreguntaSeguridad = cBoxPreguntasSeguridad.SelectedItem.ToString(),
                RespuestaSeguridad = txtRespuesta.Text,
                Correo = txtCorreo.Text,
                Contrasena = txtContrasena.Text,
                SuscritoCorreo = estadoSubcripcion
            };
        }
        // validacion de campos obligatorios todos
        private bool validarCamposObligatorios()
        {
            if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtRespuesta.Text.Length == 0 || txtCorreo.Text.Length == 0 || txtContrasena.Text.Length == 0 || txtConfirmarContrasena.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        // Evento click del boton crear cuenta
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if(validarCamposObligatorios())
            {
                if (coincidenciaContrasenas())
                {
                    if (validarCorreo())
                    {
                        creacionCuenta();
                        MessageBox.Show("Cuenta creada exitosamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El correo electrónico no es válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }
        }
        // validacion de correo correo
        private bool validarCorreo()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(txtCorreo.Text);
                return addr.Address == txtCorreo.Text;
            }
            catch
            {
                return false;
            }
        }
        // validacion de campos obligatorios
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                lblNombre.Text = "Nombre";
                lblNombre.ForeColor = Color.FromArgb(44, 48, 51);
            }
            else
            {
                lblNombre.Text = "Nombre*";
                lblNombre.ForeColor = Color.FromArgb(143, 55, 48);
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length > 0)
            {
                lblApellido.Text = "Apellido";
                lblApellido.ForeColor = Color.FromArgb(44, 48, 51);
            }
            else
            {
                lblApellido.Text = "Apellido*";
                lblApellido.ForeColor = Color.FromArgb(143, 55, 48);
            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
            if (txtRespuesta.Text.Length > 0)
            {
                lblRespuesta.Text = "Respuesta";
                lblRespuesta.ForeColor = Color.FromArgb(44, 48, 51);
            }
            else
            {
                lblRespuesta.Text = "Respuesta*";
                lblRespuesta.ForeColor = Color.FromArgb(143, 55, 48);
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Length > 0)
            {
                lblCorreo.Text = "Correo";
                lblCorreo.ForeColor = Color.FromArgb(44, 48, 51);
            }
            else
            {
                lblCorreo.Text = "Correo*";
                lblCorreo.ForeColor = Color.FromArgb(143, 55, 48);
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Length > 0)
            {
                lblContrasena.Text = "Contraseña";
                lblContrasena.ForeColor = Color.FromArgb(44, 48, 51);


                if (txtConfirmarContrasena.Text.Length > 0)
                {
                    lblCoincidencia1.Visible = !coincidenciaContrasenas();
                    lblCoincidencia2.Visible = !coincidenciaContrasenas();
                }
            }
            else
            {
                lblContrasena.Text = "Contraseña*";
                lblContrasena.ForeColor = Color.FromArgb(143, 55, 48);
                {


                    if (txtConfirmarContrasena.Text.Length > 0)
                    {
                        lblCoincidencia1.Visible = coincidenciaContrasenas();
                        lblCoincidencia2.Visible = coincidenciaContrasenas();
                    }
                }
            }
        }

        private void txtConfirmarContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmarContrasena.Text.Length > 0)
            {
                lblConfirmarContrasena.Text = "Confirmar Contraseña";
                lblConfirmarContrasena.ForeColor = Color.FromArgb(44, 48, 51);

                if (txtContrasena.Text.Length > 0)
                {
                    lblCoincidencia1.Visible = !coincidenciaContrasenas();
                    lblCoincidencia2.Visible = !coincidenciaContrasenas();
                }

            }
            else
            {
                lblConfirmarContrasena.Text = "Confirmar Contraseña*";
                lblConfirmarContrasena.ForeColor = Color.FromArgb(143, 55, 48);

                if (txtContrasena.Text.Length > 0)
                {
                    lblCoincidencia1.Visible = coincidenciaContrasenas();
                    lblCoincidencia2.Visible = coincidenciaContrasenas();
                }
            }
        }

        // validacion de campos obligatorios
    }
}
