using System;
using System.Collections.Generic;
using System.Text;

namespace mis_clases
{
    public class Direcciones
    {
        private string calle;
        private string pais;
        private string ciudad;
        private string codigo_postal;

        public string Calle
        {
            get {  return calle; }
            set { calle = value; }
        }
        public string Pais{
            get { return pais; }
            set{ pais = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set {  ciudad = value; }
        }
        public string CodigoPostal
        {
            get { return codigo_postal; }
            set { codigo_postal = value; }
        }
    }
}
