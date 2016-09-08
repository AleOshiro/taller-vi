using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2___EJ2
{
    class Auto
    {
        public Rueda[] rueda = new Rueda[5];
        public Motor motor;
        public CajaDeCambio cajaDeCambio;

        public Auto(Motor motor, CajaDeCambio cajaDeCambio, Rueda[] rueda)
        {
            if (rueda.Length > 5)
            {
                Console.WriteLine("Solo puede contener hasta 5 ruedas");
            }

            this.rueda = rueda;
            this.motor = motor;
            this.cajaDeCambio = cajaDeCambio;

        }
    }
}
