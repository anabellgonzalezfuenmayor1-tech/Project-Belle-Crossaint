using clasesDAO;
using mis_clases;

namespace FormBelleCrossaint
{
    public partial class FormLogin : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public FormLogin()
        {
            InitializeComponent();
        }

        // CREAR CUENTA FORMULARIO
        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            FormCrearCuenta formCrearCuenta = new FormCrearCuenta();
            this.Visible = false;
            formCrearCuenta.ShowDialog();
            this.Visible = true;
        }


        // INICIAR SESION
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" && txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor, complete los campos");
                return;
            }
            if (usuarioDAO.correoExistente(txtUsuario.Text.ToLower()))
            {
                if (usuarioDAO.validarContrasena(txtUsuario.Text.ToLower(), txtContrasena.Text))
                {
                    MessageBox.Show("Bienvenido " + txtUsuario.Text);
                    Usuario log = usuarioDAO.ObtenerUsuarioPorCorreo(txtUsuario.Text.ToLower());
                    FormPantallaPrincipal formPantallaPrincipal = new FormPantallaPrincipal(log);
                    this.Visible = false;
                    formPantallaPrincipal.ShowDialog();
                    txtContrasena.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    this.Visible = true;
                }
                else
                {
                    lblIncorrecto.Visible = true;
                }
            }
            else
            {
                lblNoExiste.Visible = true;
            }
        }

        // VALIDACION INSTANCIA DE CAMPO DE TEXTO
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblIncorrecto.Visible = false;
            lblNoExiste.Visible = false;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            lblIncorrecto.Visible = false;
        }

        private void lblOlvidarContrasena_Click(object sender, EventArgs e)
        {
            FormCorreoRecuperacion formCorreoRecuperacion = new();
            this.Hide();
            formCorreoRecuperacion.ShowDialog();
            this.Show();
        }

        // VISIBILIDAD DE CONTRASEÑA
        private void pVisibleC_Click(object sender, EventArgs e)
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
