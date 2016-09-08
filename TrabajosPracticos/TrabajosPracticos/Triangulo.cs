using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticos
{
    class Triangulo : Interface
    {
        private double b, lado1, lado2, area, perimetro, altura, semiperimetro;

        public Triangulo(double b, double lado1, double lado2) {
            this.b = b;
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public double CalcularArea()
        {
            
            if (b != lado1 && lado1 != lado2 && lado2 != b)
            {
                //Triangulo escaleno
                semiperimetro = (b + lado1 + lado2) / 2;
                area = Math.Sqrt(semiperimetro * (semiperimetro - b) * (semiperimetro - lado1) * (semiperimetro - lado2));
            }
            else
            {   
                //Triangulo equilatero, isoceles
                altura = (Math.Sqrt(3) * lado1) / 2;
                area = (b * altura) / 2;
            }
            return area;
        }

        public double CalcularPerimetro()
        {
            perimetro = b + lado1 + lado2;
            return perimetro;
        }
    }
}


