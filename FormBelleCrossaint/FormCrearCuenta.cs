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
    }
}
