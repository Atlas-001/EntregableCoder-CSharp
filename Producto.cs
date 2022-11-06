using System;

namespace EntregableCoder
{
    internal class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int costo { get; set; }
        public int precioVenta { get; set; }
        public int stock { get; set; }
        public int idUsuario { get; set; }

        public Producto()
        {
            id = 0;
            descripcion = "";
            costo = 0;
            precioVenta = 0;
            stock = 0;
            idUsuario = 0;
        }
    }
}
