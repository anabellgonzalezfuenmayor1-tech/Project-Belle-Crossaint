using mis_clases;
using Org.BouncyCastle.Crypto.Generators;
using System.Data.SqlClient;

namespace clasesDAO
{
    public class UsuarioDAO : Conexion
    {
   
        public List<Usuario> ObtenerListUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            try
            {
                using (SqlConnection connection = new(CadenaConexion))
                {
                    connection.Open();
                    string query = "select * from vw_UsuarioCompleto";
                    using (SqlCommand command = new(query, connection))
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
        public void CrearUsuario(Usuario usuario)
        {
            try
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
                    string query = "sp_CrearUsuario";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {   
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        //encriptar la contraseña antes de guardarla en la base de datos
                        usuario.Contrasena = BCrypt.Net.BCrypt.HashPassword(usuario.Contrasena);
                        // encriptar la respuesta de seguridad antes de guardarla en la base de datos
                        usuario.RespuestaSeguridad = BCrypt.Net.BCrypt.HashPassword(usuario.RespuestaSeguridad);

                        // agregar los parámetros a la consulta
                        command.Parameters.AddWithValue("@idPregunta", idPregunta);
                        command.Parameters.AddWithValue("@respuestaSeguridad", usuario.RespuestaSeguridad);
                        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                        command.Parameters.AddWithValue("@email", usuario.Correo);
                        command.Parameters.AddWithValue("@subCorreo", usuario.SuscritoCorreo);
                        command.Parameters.AddWithValue("@pathPerfil", usuario.PathPerfil);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);

            }
        }
        // VALIDAR QUE EL CORREO EXISTA EN LA BASE DE DATOS, SI EXISTE RETORNAR TRUE, SI NO EXISTE RETORNAR FALSE
        public bool correoExistente(string correo)
        {
            try
            {
                foreach (var c in ObtenerListUsuario())
                {
                    if (c.Correo == correo)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el correo: " + ex.Message);
                return false;
            }
        }
        // VALIDAR QUE LA CONTRASEÑA PERTENEZCA AL CORREO, SI PERTENECE RETORNAR TRUE, SI NO PERTENECE RETORNAR FALSE
        public bool validarContrasena(string correo, string contrasena)
        {
            try
            {
                foreach (var c in ObtenerListUsuario())
                {
                    if (c.Correo == correo)
                    {
                        // comparar la contraseña encriptada con la contraseña ingresada
                        if (BCrypt.Net.BCrypt.Verify(contrasena, c.Contrasena))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar la contraseña: " + ex.Message);
                return false;
            }
        }
    }
}
