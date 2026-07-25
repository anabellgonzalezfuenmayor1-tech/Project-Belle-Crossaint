using mis_clases;
using System.Data.SqlClient;

namespace clasesDAO
{
    public class UsuarioDAO : Conexion
    {
   
        public List<Usuario> ObtenerListUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            listaUsuario = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConexion))
                {
                    connection.Open();
                    string query = "SELECT u.id, u.nombre, u.apellido,u.email, u.contrasena, \r\nps.pregunta, u.respuesta_seguridad, u.n_telefono, u.subcripcion_correo,u.path_perfil, me.metodo_nombre\r\nFROM Usuario u\r\nINNER JOIN PreguntasSeguridad ps \r\nON u.id_pregunta = ps.id\r\nINNER JOIN MetodoEntrega me \r\nON me.id = u.id_Metodo; \r\n";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(reader["Id"]);
                                usuario.Nombre = Convert.ToString(reader["Nombre"]);
                                usuario.Apellido = Convert.ToString(reader["Apellido"]);
                                usuario.Correo = Convert.ToString(reader["Correo"]);
                                usuario.Contrasena = Convert.ToString(reader["Contrasena"]);
                                usuario.PreguntaSeguridad = Convert.ToString(reader["PreguntaSeguridad"]);
                                usuario.RespuestaSeguridad = Convert.ToString(reader["RespuestaSeguridad"]);
                                usuario.NTelefono = Convert.ToString(reader["NTelefono"]);
                                usuario.SuscritoCorreo = Convert.ToBoolean(reader["SuscritoCorreo"]);
                                usuario.PathPerfil = Convert.ToString(reader["PathPerfil"]);
                                usuario.MetodoEntrega = Convert.ToString(reader["MetodoEntrega"]);
                                listaUsuario.Add(usuario);
                            }
                        }

                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al obtener la lista de usuarios: " + ex.Message);

            }
            return listaUsuario;
        }
        public void EncriptarContrasena(Usuario usuario)
        {
            // obtener el id de pregunta de seguridad
            PreguntasDAO preguntasDAO = new PreguntasDAO();
            int idPregunta = 0;
            foreach (var item in preguntasDAO.GetPreguntas())
            {
                if (item.Pregunta == usuario.PreguntaSeguridad)
                {
                    idPregunta = item.Id;
                }
            }
            // obtener el id del metodo de entrega


            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                string query = "INSERT INTO \r\nUsuario(id_pregunta, respuesta_seguridad, nombre, apellido, contrasena, email, n_telefono, subcripcion_correo, path_perfil, id_Metodo)\r\nVALUES\r\n(@idPregunta, @respuestaSeguridad, @nombre, @apellido, ,@contrasena, @email, @telefono, @subCorreo, @pathPerfil, @idMetodo );";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    // agregar los parámetros a la consulta
                    command.Parameters.AddWithValue("@idPregunta", idPregunta);
                    command.Parameters.AddWithValue("@respuestaSeguridad", usuario.RespuestaSeguridad);
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                    command.Parameters.AddWithValue("@email", usuario.Correo);
                    command.Parameters.AddWithValue("@telefono", usuario.NTelefono);
                    command.Parameters.AddWithValue("@subCorreo", usuario.SuscritoCorreo);
                    command.Parameters.AddWithValue("@pathPerfil", usuario.PathPerfil);
                    command.Parameters.AddWithValue("@idMetodo", usuario.MetodoEntrega);
                    command.ExecuteNonQuery();
                }

            }
            
        }
    }
}
