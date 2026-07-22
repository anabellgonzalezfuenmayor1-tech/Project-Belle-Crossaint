using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.Text;

namespace clasesDAO
{
    abstract public class Conexion
    {
        private readonly string cadenaConexion;

        public Conexion()
        {
            try
            {
                cadenaConexion = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
            }
            catch(Exception exc){ 
                MessageBox.Show("Error al obtener la cadena de conexión: " + exc.Message);
            }
        }
        public string CadenaConexion
        {
            get { return cadenaConexion; }
        }

    }
}
