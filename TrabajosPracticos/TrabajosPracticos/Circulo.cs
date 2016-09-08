using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticos
{
    class Circulo : Interface
    {
        private double radio, area, perimetro, pi = Math.PI;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            area = pi * Math.Pow(radio,2);
            return area;
        }

        public double CalcularPerimetro()
        {
            perimetro = 2 * pi * radio;
            return perimetro;
        }
    }
}
