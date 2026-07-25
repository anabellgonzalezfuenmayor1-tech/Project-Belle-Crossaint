using mis_clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace clasesDAO
{
    public class MetodoEntregaDAO : Conexion
    {
        public List<MetodoEntrega> ObtenerListMetodoEntrega()
        {
            List<MetodoEntrega> listaMetodoEntrega = new List<MetodoEntrega>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConexion))
                {
                    connection.Open();
                    string query = "SELECT id, metodo FROM MetodoEntrega";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MetodoEntrega metodoEntrega = new MetodoEntrega
                                {
                                    Id = reader.GetInt32(0),
                                    Metodo = reader.GetString(1)
                                };
                                listaMetodoEntrega.Add(metodoEntrega);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la lista de métodos de entrega: " + ex.Message);
            }


            return listaMetodoEntrega;
        }
    }
}
