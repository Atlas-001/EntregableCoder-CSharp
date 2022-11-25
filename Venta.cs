using System;

namespace EntregableCoder
{
    public class Venta
    {
        public int id { get; set; }
        public string comentarios { get; set; }

        public Venta(int id, string comentarios)
        {
            this.id = id;
            this.comentarios = comentarios;
        }

        public Venta()
        {
            id = 0;
            comentarios = "";
        }
    }
}
