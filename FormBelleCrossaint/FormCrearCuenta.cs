using clasesDAO;
using mis_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormBelleCrossaint
{
    public partial class FormCrearCuenta : Form
    {
        PreguntasDAO preguntasDAO = new PreguntasDAO();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public FormCrearCuenta()
        {
            InitializeComponent();
            CargarPreguntas();
        }

        // CARGAR PREGUNTAS AL COMBOBOX DE PREGUNTAS DE SEGURIDAD
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

        // VERIFICACION DE QUE LAS CONTRASEÑAS COINCIDAN, SI NO COINCIDEN DEVUELVE FALSE
        private bool coincidenciaContrasenas()
        {
            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                return false;
            }
            return true;
        }

        // METODO PARA CREAR EL USUARIO, SE CREA UN OBJETO USUARIO CON LOS DATOS INGRESADOS Y SE LLAMA AL METODO CREARUSUARIO DEL DAO
        private void creacionCuenta()
        {
            Usuario usuario = new Usuario()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                PreguntaSeguridad = cBoxPreguntasSeguridad.SelectedItem.ToString(),
                RespuestaSeguridad = txtRespuesta.Text.ToLower(),
                Correo = txtCorreo.Text.ToLower(),
                Contrasena = txtContrasena.Text,
                SuscritoCorreo = cBoxSubcripcion.Checked
            };
            usuarioDAO.CrearUsuario(usuario);

        }
        // vVALIDACION DE CAMPOS OBLIGATORIOS, SI ALGUNO ESTA VACIO DEVUELVE FALSE
        private bool validarCamposObligatorios()
        {
            if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 ||
                txtRespuesta.Text.Length == 0 || txtCorreo.Text.Length == 0 ||
                txtContrasena.Text.Length == 0 || txtConfirmarContrasena.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        // EVENTO CLICK DEL BOTON CREAR CUENTA, QUE LLAMA A TODAS LAS VALIDACIONES Y SI TODO ES CORRECTO CREA LA CUENTA
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (validarCamposObligatorios())
            {
                if (coincidenciaContrasenas())
                {
                    if (validarCorreo())
                    {
                        if (!usuarioDAO.correoExistente(txtCorreo.Text.ToLower()))
                        {
                            creacionCuenta();
                            MessageBox.Show("Cuenta creada exitosamente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario Existente, inicia sesion");
                        }
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
        // VALIDACION DE QUE EL CORREO INGRESADO SEA VALIDO, USANDO LA CLASE MAILADDRESS
        private bool validarCorreo()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(txtCorreo.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        // VALIDACIONES INSTANTANEAS DE LOS CAMPOS OBLIGATORIOS, CAMBIANDO EL COLOR DEL TEXTO Y EL NOMBRE DEL LABEL
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

                // VALIDACION DE QUE EL CORREO INGRESADO SEA UNICO, SI NO LO ES MUESTRA UN LABEL DE ERROR
                if (usuarioDAO.correoExistente(txtCorreo.Text.ToLower()))
                {
                    lblUsuarioExistente.Visible = true;
                }
                else
                {
                    lblUsuarioExistente.Visible = false;
                }
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
        // PONER DATOS INGRESADOS EN PRIMERA EN MAYUSCULAS Y LAS DEMAS EN MINUSCULAS
        private string datosEnMayusculasYMinusculas(string dato)
        {
            try
            {
                dato = dato.Substring(0, 1).ToUpper() + dato.Substring(1).ToLower();
                return dato;
            }
            catch
            {
                return dato;
            }
        }
        // VALIDAR EL TEXTO DE CADA CAMPO OBLIGATORIO PARA QUE NO HAYA ERRORES DE ESCRITURA
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.Text = datosEnMayusculasYMinusculas(txtNombre.Text);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            txtApellido.Text = datosEnMayusculasYMinusculas(txtApellido.Text);
        }

        private void pVisibleCC_Click(object sender, EventArgs e)
        {
            txtConfirmarContrasena.UseSystemPasswordChar = !txtConfirmarContrasena.UseSystemPasswordChar;
            if (txtConfirmarContrasena.UseSystemPasswordChar)
            {
                pVisibleC.Image = Image.FromFile("C:\\Users\\AnaAl\\source\\repos\\Project-Belle-Crossaint\\imagenes\\Invisible.png");
            }
            else
            {
                pVisibleC.Image = Image.FromFile("C:\\Users\\AnaAl\\source\\repos\\Project-Belle-Crossaint\\imagenes\\Eye open.png");
            }
        }

        private void pVisibleC_Click_1(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
            if (txtContrasena.UseSystemPasswordChar)
            {
                pVisibleC.Image = Image.FromFile("C:\\Users\\AnaAl\\source\\repos\\Project-Belle-Crossaint\\imagenes\\Invisible.png");
            }
            else
            {
                pVisibleC.Image = Image.FromFile("C:\\Users\\AnaAl\\source\\repos\\Project-Belle-Crossaint\\imagenes\\Eye open.png");
            }
        }
    }
}
