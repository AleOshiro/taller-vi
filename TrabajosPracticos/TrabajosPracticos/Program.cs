using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosPracticos
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 0, b = 0, c = 0, valor = 0, valor2 = 0;

            Console.Write(
                "*************************************************" + "\n" +
                "Ingrese el valor del lado de un cuadrado: "
            );
            while (valor <= 0) {
                valor = double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    Cuadrado cuadrado = new Cuadrado(valor);
                    Console.WriteLine(
                        "El area del cuadrado es: " + cuadrado.CalcularArea() + "\n" +
                        "El perimetro del cuadrado es: " + cuadrado.CalcularPerimetro() + "\n" +
                        "*************************************************"
                    );
                }
                else
                {
                    Console.Write("Ingrese un valor mayor a 0: ");
                }
            }

            Console.Write(
                "*************************************************" + "\n" +
                "Ingrese el valor del radio del circulo: "
            );
            while (valor2 <= 0) {
                valor2 = double.Parse(Console.ReadLine());

                if (valor2 > 0)
                {
                    Circulo circulo = new Circulo(valor2);
                    Console.WriteLine(
                        "El area del circulo es: " + circulo.CalcularArea() + "\n" +
                        "El perimetro del circulo es: " + circulo.CalcularPerimetro() + "\n" +
                        "*************************************************"
                    );
                }
                else
                {
                    Console.Write("Ingrese un valor mayor a 0: ");
                }
            }

            

            while (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("*************************************************");
                Console.Write("Ingrese el primer lado del traingulo: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo lado del traingulo: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el tercer lado del traingulo: ");
                c = double.Parse(Console.ReadLine());

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Ingrese valor mayores a 0");
                }
                else
                {
                    Triangulo triangulo = new Triangulo(a, b, c);
                    Console.WriteLine(
                        "El perimetro del triangulo es: " + triangulo.CalcularPerimetro() + "\n" +
                        "El area del triangulo es: " + triangulo.CalcularArea() + "\n" +
                        "*************************************************"
                    );
                }
            }
            Console.ReadKey(); 
        }
    }
}
