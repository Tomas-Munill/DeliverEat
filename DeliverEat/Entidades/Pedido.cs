using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public bool RecepcionLoAntesPosible { get; set; } 
        public DateTime? FechaHoraRecepcion { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
        public string Estado { get; set; }
        public Direccion Direccion { get; set; }
        public List<DetallePedido> DetallePedidos { get; set;  }
        public IMetodoPago MetodoPago { get; set; }

    }
}
