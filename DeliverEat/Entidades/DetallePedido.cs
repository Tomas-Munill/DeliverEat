using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Entidades
{
    public class DetallePedido
    {
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }

        public DetallePedido(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public double CalcularPrecio()
        {
            return producto.Precio * cantidad;
        }
    }
}
