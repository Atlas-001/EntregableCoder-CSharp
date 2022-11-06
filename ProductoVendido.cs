using System;

namespace EntregableCoder
{
    internal class ProductoVendido
    {
        public int id { get; set; }
        public int idProducto { get; set; }
        public int stock { get; set; }
        public int idVenta { get; set; }

        public ProductoVendido()
        {
            id = 0;
            idProducto = 0;
            stock = 0;
            idVenta = 0;
        }
    }
}
