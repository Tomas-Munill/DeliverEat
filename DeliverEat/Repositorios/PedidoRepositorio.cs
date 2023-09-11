using DeliverEat.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Repositorios
{
    public class PedidoRepositorio
    {
        private Repository<Pedido> pedidos;
        public PedidoRepositorio()
        {
            string nombreArchivo = "pedidos.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"Datos", nombreArchivo);

            pedidos = new Repository<Pedido>(path);
        }

        public void InsertarPedido(Pedido pedido)
        {
            pedido.Id = pedidos.Count() != 0 ? pedidos[pedidos.Count() - 1].Id + 1 : 1;
            pedidos.Add(pedido);
            pedidos.Commit();
        }

        public Pedido[] GetPedidos()
        {
            return pedidos.SelectAll().ToArray();
        }

        public int ObtenerProxNro()
        {
            return pedidos.Count() != 0 ? pedidos[pedidos.Count() - 1].Id + 1 : 1;
        }

        public void DeletePedido(Pedido pedido)
        {
            for (int i = 0; i < pedidos.Count; i++)
            {
                if (pedidos[i].Id == pedido.Id)
                {
                    pedidos.Remove(pedidos[i]);
                    pedidos.Commit();
                }
            }
        }
    }
}
