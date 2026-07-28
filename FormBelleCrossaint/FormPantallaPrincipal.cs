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
    public partial class FormPantallaPrincipal : Form
    {
        Usuario usuario;
        public FormPantallaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            cargarUserControl();
        }
        private void cargarUserControl()
        {
            UserControlPerfil perfil = new UserControlPerfil(usuario);
            PanelContenido.Controls.Clear();
            perfil.Dock = DockStyle.Fill;
            PanelContenido.Controls.Add(perfil);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            cargarUserControl();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
