using System;
using System.Collections.Generic;
using System.Text;

namespace mis_clases
{
    public class Preguntas
    {
        private int id;
        private string pregunta;
        

        public int Id { 
            get { return id; } 
            set { id = value; }
        }
        public string Pregunta { 
            get { return pregunta; } 
            set { pregunta = value; } 
        }
    }
}
