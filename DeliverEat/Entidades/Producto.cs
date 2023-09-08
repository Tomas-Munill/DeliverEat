using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }

        public Producto(string nombre, double precio, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        
    }
}
