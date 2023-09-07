using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Entidades
{
    public interface IMetodoPago
    {
        bool ValidarMetodo(string NumeroT);
    }
}
