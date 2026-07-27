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
        //CREAR UN USUARIO, RECIBIENDO UN OBJETO USUARIO, ENCRIPTANDO LA CONTRASEÑA Y LA RESPUESTA DE SEGURIDAD ANTES DE GUARDARLA EN LA BASE DE DATOS
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


                using (SqlConnection connection = new SqlConnection(CadenaConexion))
                {
                    connection.Open();
                    string query = "sp_CrearUsuario";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        //ENCRIPTAR LA CONTRASEÑA ANTES DE GUARDARLA EN LA BASE DE DATOS
                        usuario.Contrasena = BCrypt.Net.BCrypt.HashPassword(usuario.Contrasena);
                        //ENCRIPTAR LA RESPUESTA DE SEGURIDAD ANTES DE GUARDARLA EN LA BASE DE DATOS
                        usuario.RespuestaSeguridad = BCrypt.Net.BCrypt.HashPassword(usuario.RespuestaSeguridad);

                        // AGREGAR PARAMETROS A LA CONSULTA SQL PARA CREAR EL USUARIO
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
        // OBTENER UN USUARIO POR SU CORREO, SI EXISTE RETORNAR EL USUARIO, SI NO EXISTE RETORNAR NULL
        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            try
            {
                foreach (var c in ObtenerListUsuario())
                {
                    if (c.Correo == correo)
                    {
                        return c;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el usuario: " + ex.Message);
                return null;
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
                        // COMPARAR LA CONTRASEÑA ENCRIPTADA CON LA CONTRASEÑA INGRESADA, USANDO LA LIBRERIA BCRYPT
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
        // ACTUALIZAR LA CONTRASEÑA DE UN USUARIO, RECIBIENDO EL CORREO Y LA NUEVA CONTRASEÑA, ENCRIPTANDO LA NUEVA CONTRASEÑA ANTES DE GUARDARLA EN LA BASE DE DATOS
        public void ActualizarContrasena(string correo, string nuevaContrasena)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConexion))
                {
                    connection.Open();
                    string query = "UPDATE Usuario SET contrasena = @nuevaContrasena WHERE email = @correo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        // ENCRIPTAR LA NUEVA CONTRASEÑA ANTES DE GUARDARLA EN LA BASE DE DATOS
                        nuevaContrasena = BCrypt.Net.BCrypt.HashPassword(nuevaContrasena);
                        // ACTUALIZAR REGISTRO EN LA BASE DE DATOS
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@nuevaContrasena", nuevaContrasena);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
            }
        }
    }
}
