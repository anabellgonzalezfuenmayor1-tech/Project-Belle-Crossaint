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
            using (SqlConnection connection = new SqlConnection(CadenaConexion))
            {
                connection.Open();
                string query = "UPDATE ";

            }
            
        }
    }
}
