using DeliverEat.Entidades;
using DeliverEat.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Servicios
{
    public class GestorPedido
    {
        public List<DetallePedido> carrito { get; set; }
        private PedidoRepositorio pedidoRepositorio;

        public GestorPedido()
        {
            Producto lomito = new Producto("Lomito Completo", 2250, "Lomito completo con papas");
            Producto gaseosa = new Producto("Pepsi", 500, "Gaseosa tamaño medio");
            Producto hamburguesa = new Producto("Hamburguesa doble con queso", 1700, "Hamburguesa con medallon premium");

            DetallePedido detalleLomito = new DetallePedido(lomito, 2);
            DetallePedido detalleGaseosa = new DetallePedido(gaseosa, 3);
            DetallePedido detalleHamburguesa = new DetallePedido(hamburguesa, 1);

            this.carrito = new List<DetallePedido>();
            this.carrito.Add(detalleLomito);
            this.carrito.Add(detalleGaseosa);
            this.carrito.Add(detalleHamburguesa);

            // crear archivo repositorio
            pedidoRepositorio = new PedidoRepositorio();


        }

        public List<DetallePedido> CargarCarrito()
        {
            return carrito;
        }

        public void GuardarPedido(Pedido pedido)
        {
            pedidoRepositorio.InsertarPedido(pedido);
        }
    }
}
