using System;
using System.Collections.Generic;
using System.Text;

namespace mis_clases
{
    public class MetodoEntrega
    {
        private int id;
        private string metodo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Metodo
        {
            get { return metodo; }
            set
            {
                metodo = value;

            }
        }
    }
}
