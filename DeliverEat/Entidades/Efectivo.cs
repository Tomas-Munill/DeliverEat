using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Entidades
{
    public class Efectivo : IMetodoPago
    {
        public double MontoQueAbona { get; set; }
        public bool ValidarMetodo(string monto)
        {
            double montoDouble = Convert.ToDouble(monto);
            return MontoQueAbona >= montoDouble;
        }

        override public string ToString()
        {
            return "Efectivo";
        }
    }
}
