using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverEat.Entidades
{
    public class TarjetaCredito : IMetodoPago
    {
        public string numero { get; set; }
        public string cvc { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string nombreApellidoTitular { get; set; }
    
        public bool ValidarMetodo(string numero)
        {
            int sum = 0;
            bool alternate = false;

            // Recorre los dígitos de derecha a izquierda
            for (int i = numero.Length - 1; i >= 0; i--)
            {
                if (numero[i] == '-')
                    continue;

                int digit = int.Parse(numero[i].ToString());



                if (alternate)
                {
                    // Duplica el dígito y ajusta si es mayor o igual a 10
                    digit *= 2;
                    if (digit >= 10)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                alternate = !alternate;
            }

            // El número es válido si la suma es un múltiplo de 10
            return sum % 10 == 0;
        }


        override public string ToString()
        {
            return "Tarjeta";
        }
    }
}
