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
        public FormPantallaPrincipal()
        {
            InitializeComponent();
            PanelContenido.Controls.Clear();
            UserControlPerfil perfil = new UserControlPerfil();
            perfil.Dock = DockStyle.Fill;
            PanelContenido.Controls.Add(perfil);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            PanelContenido.Controls.Clear();
            UserControlPerfil perfil = new UserControlPerfil();
            perfil.Dock = DockStyle.Fill;
            PanelContenido.Controls.Add(perfil);
        }
    }
}
