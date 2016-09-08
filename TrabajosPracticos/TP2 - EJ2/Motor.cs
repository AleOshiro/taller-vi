using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2___EJ2
{
    class Motor : MotorInterface
    {
        public string nombre { set; get; }

        public Motor(string nombre)
        {
            this.nombre = nombre;
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando F");
        }

        public void Iniciar()
        {
            Console.WriteLine("Iniciando M");
        } 
    }
}
