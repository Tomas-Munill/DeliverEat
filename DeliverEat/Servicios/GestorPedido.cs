using DeliverEat.Entidades;
using DeliverEat.InterfacesDeUsuario;
using DeliverEat.Repositorios;
using MaterialSkin.Controls;
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
        private FrmRealizarPedido frmRealizarPedido;
        private FrmPrincipal frmPrincipal;

        public GestorPedido()
        {
            Producto lomito = new Producto("Lomito", 2250, "Lomito completo con papas");
            Producto gaseosa = new Producto("Pepsi", 500, "Gaseosa tamaño medio");
            Producto hamburguesa = new Producto("Hamburguesa", 1700, "Hamburguesa con medallon premium");

            DetallePedido detalleLomito = new DetallePedido(lomito, 2);
            DetallePedido detalleGaseosa = new DetallePedido(gaseosa, 3);
            DetallePedido detalleHamburguesa = new DetallePedido(hamburguesa, 1);

            this.carrito = new List<DetallePedido>();
            this.carrito.Add(detalleLomito);
            this.carrito.Add(detalleGaseosa);
            this.carrito.Add(detalleHamburguesa);

            // crear archivo repositorio
            pedidoRepositorio = new PedidoRepositorio();

            // ejecutar form
            frmPrincipal = new FrmPrincipal(this);
            frmPrincipal.ShowDialog();

            //frmRealizarPedido = new FrmRealizarPedido(this);
            //frmRealizarPedido.ShowDialog();


        }

        public List<DetallePedido> CargarCarrito()
        {
            return carrito;
        }

        public void GuardarPedido(Pedido pedido)
        {
            pedidoRepositorio.InsertarPedido(pedido);
        }

        public void CancelarPedido()
        {
            this.frmRealizarPedido.Hide();
            this.frmPrincipal.Show();
        }

        public void ConfirmarPedido()
        {
            this.frmRealizarPedido = new FrmRealizarPedido(this);
            this.frmPrincipal.Hide();
            this.frmRealizarPedido.ShowDialog();
        }

        public void RegistrarPedido()
        {
            this.frmRealizarPedido.Dispose();
            this.frmPrincipal.Show();

            frmPrincipal.MostrarConfirmacion();
        }
    }
}
