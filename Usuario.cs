using System;

namespace EntregableCoder
{
    public class Usuario
    {
        public int id { get; set; } 
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public string correo { get; set; }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string clave, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.correo = correo;
        }

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
