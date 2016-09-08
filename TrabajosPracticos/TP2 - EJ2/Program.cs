using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2___EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija un motor: Diesel, Turbo, TDI, Electrico");
            string motor = Console.ReadLine();
            Console.WriteLine("Elija la cantidad de cambios: ");
            int cajaDeCambio = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija tipo de la caja de cambio, entre automatica o manual");
            string tipoCajaCambio = Console.ReadLine();
            Console.WriteLine("Elija la cantidad de ruedas");
            int rueda = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija diametro de la rueda");
            double diametro = double.Parse(Console.ReadLine());
            Rueda[] wheel = new Rueda[rueda];
            int contador = rueda;

            while (contador == 0 )
            {
                wheel[contador] = new Rueda(diametro);
                contador--;
            }

            Motor engine = new Motor(motor);
            CajaDeCambio box = new CajaDeCambio(cajaDeCambio, tipoCajaCambio);
            Auto auto = new Auto(engine, box, wheel);

            Console.WriteLine(
                "***********************************" + "\n" +
                "Motor: " + auto.motor.nombre + "\n" +
                "Tipo de caja de cambio: " + auto.cajaDeCambio.tipo + "\n" +
                "Cantidad de cambios: " + auto.cajaDeCambio.cantidadCambios + "\n" +
                "Cantidad de ruedas: " + rueda + "\n" +
                "Diametro de la rueda: " + diametro + "\n" +
                "***********************************"
            );
            Console.ReadKey();
        }
    }
}
