namespace FormBelleCrossaint
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pVisible_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
            if (txtContrasena.UseSystemPasswordChar)
            {
                pVisible.Image = Image.FromFile("C:\\Users\\AnaAl\\source\\repos\\BelleCrossaint\\imagenes\\Invisible.png");
            }
            else
            {
                pVisible.Image = Image.FromFile("C:\\Users\\AnaAl\\source\\repos\\BelleCrossaint\\imagenes\\Eye open.png");
            }
        }
    }
}
