using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2___EJ2
{
    class Auto
    {
        public Rueda[] ruedas { get; set; }
        public Motor motor { get; set; }
        public CajaDeCambio cajacambios { get; set; }

        public Auto (Rueda[] ruedas, Motor motor, CajaDeCambio cajaDeCambios)
        {
            if (this.ruedas.Length > 5)
            {
                Console.WriteLine("Solo se pueden tener 5 ruedas");
                return;
            }

            this.ruedas = ruedas;
            this.motor = motor;
            this.cajacambios = cajacambios;
        }
    }
}
