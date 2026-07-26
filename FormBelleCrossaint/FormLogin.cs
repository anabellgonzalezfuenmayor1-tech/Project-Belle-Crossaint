using clasesDAO;

namespace FormBelleCrossaint
{
    public partial class FormLogin : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public FormLogin()
        {
            InitializeComponent();
        }
        //VALIDACION DE CAMPOS VACIOS
        private void ValidarBoton()
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContrasena.Text);
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
            if (usuarioDAO.correoExistente(txtUsuario.Text.ToLower()))
            {
                if (usuarioDAO.validarContrasena(txtUsuario.Text.ToLower(), txtContrasena.Text))
                {
                    MessageBox.Show("Bienvenido " + txtUsuario.Text);
                }
                else
                {
                    MessageBox.Show("Contraseña o correo electrónico incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Correo electrónico no registrado");
            }
        }

        // VALIDACION INSTANCIA DE CAMPO DE TEXTO
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarBoton();
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            ValidarBoton();
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
