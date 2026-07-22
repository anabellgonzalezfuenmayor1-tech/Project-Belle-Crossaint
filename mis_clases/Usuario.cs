namespace mis_clases
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string pregunta_seguridad;
        private string respuesta_seguridad;
        private string correo;
        private string contrasena;
        private string n_telefono;
        private List<string>  lista_direcciones;
        private bool suscrito_correo;
        private string path_perfil;
        private string metodo_entrega;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string PreguntaSeguridad
        {
            get { return pregunta_seguridad; }
            set { pregunta_seguridad = value; }
        } 
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public string RespuestaSeguridad
        {
            get { return respuesta_seguridad; }
            set { respuesta_seguridad = value; }
        }
        public string NTelefono
        {
            get { return n_telefono; }
            set { n_telefono = value; }
        }
        public List<string> ListaDirecciones
        {
            get { return lista_direcciones; }
            set { lista_direcciones = value; }
        }
        public bool SuscritoCorreo
        {
            get { return suscrito_correo; }
            set { suscrito_correo = value; }
        }
        public string PathPerfil
        {
            get { return path_perfil; }
            set { path_perfil = value; }
        }
        public string MetodoEntrega
        {
            get { return metodo_entrega; }
            set { metodo_entrega = value; }
        }
    }
}
