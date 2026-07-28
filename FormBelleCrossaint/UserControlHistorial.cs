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
    public partial class UserControlHistorial : UserControl
    {
        private Usuario usuario;
        public UserControlHistorial(Usuario usuario)
        {
            InitializeComponent();
        }
    }
}
