using mis_clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace clasesDAO
{
    public class PreguntasDAO : Conexion
    {
        public List<Preguntas> GetPreguntas()
        {
            List<Preguntas> listaPreguntas = new List<Preguntas>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConexion))
                {
                    connection.Open();
                    string query = "SELECT * FROM PreguntasSeguridad;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Preguntas pregunta = new Preguntas()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Pregunta = Convert.ToString(reader["Pregunta"])
                                };
                                
                                listaPreguntas.Add(pregunta);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las preguntas: " + ex.Message);
            }
            return listaPreguntas;
        }
    }
}
