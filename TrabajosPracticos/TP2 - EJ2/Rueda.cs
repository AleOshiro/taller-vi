using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2___EJ2
{
    class Rueda : RuedaInterface
    {
        public double diametro { get; set; }

        public Rueda(double diametro) {
            this.diametro = diametro;
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando R");
        }

        public void Iniciar()
        {
            Console.WriteLine("Iniciando R");
        }
    }
}
