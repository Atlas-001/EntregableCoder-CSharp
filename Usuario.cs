using System;

namespace EntregableCoder
{
    internal class Usuario
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public string correo { get; set; }

        public Usuario()
        {
            id = 0;
            nombre = "";
            apellido = "";
            nombreUsuario = "";
            clave = "";
            correo = "";
        }
    }
}
