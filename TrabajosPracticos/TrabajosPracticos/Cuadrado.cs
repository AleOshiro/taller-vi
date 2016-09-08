using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticos
{
    class Cuadrado : Interface
    {
        private double lado, area, perimetro;

        public Cuadrado(double lado) {
            this.lado = lado;
        }

        public double CalcularArea() {
            area = lado * lado;
            return area;
        }

        public double CalcularPerimetro() {
            perimetro = lado * 4;
            return perimetro;
        }
    }
}
