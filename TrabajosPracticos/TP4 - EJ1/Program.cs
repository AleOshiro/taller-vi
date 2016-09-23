using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4___EJ1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Materia> SextoCuatrimestre = new List<Materia>();

            SextoCuatrimestre.Add(new Materia("Taller de computación VI", "Almiñana Gabriel", "Lunes", "18:40"));
            SextoCuatrimestre.Add(new Materia("Seminario de tecnología", "Cudek Misael", "Lunes", "20:50"));
            SextoCuatrimestre.Add(new Materia("Seguridad e integridad de sistemas", "Romanos Pablo", "Martes", "18:40"));
            SextoCuatrimestre.Add(new Materia("Seminario de sistemas", "Romanos Pablo", "Miércoles", "18:40"));
            SextoCuatrimestre.Add(new Materia("Computación Avanzada", "Breitman Alejandro", "Jueves", "18:40"));

            foreach (Materia materia in SextoCuatrimestre)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("*  Materia: " + materia._nombre);
                Console.WriteLine("*  Profesor: " + materia._profesor);
                Console.WriteLine("*  Día: " + materia._dia);
                Console.WriteLine("*  Horario: " + materia._horario);
                Console.WriteLine("************************************************");
            }

            Console.ReadKey();

        }
    }
}
