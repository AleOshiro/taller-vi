using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Nota> notas = new List<Nota>();

            List<Materia> materias = new List<Materia>() {
                new Materia("Taller de computacion I", 2014, 1,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Programacion I", 2014, 1,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Taller de computacion II", 2014, 2,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Programacion II", 2014, 2,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Taller de computacion III", 2015, 3,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Programacion III", 2015, 3,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Taller de computacion IV", 2015, 4,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Programacion IV", 2015, 4,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 8),
                        new Nota("10/04/2014", "TP", 7),
                        new Nota("10/05/2014", "2º Parcial", 9),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Taller de computacion V", 2016, 5,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 2),
                        new Nota("10/04/2014", "TP", 2),
                        new Nota("10/05/2014", "2º Parcial", 2),
                        new Nota("10/06/2014", "Final", 2)
                    }
                ),

                new Materia("Programacion V", 2106, 5,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 2),
                        new Nota("10/04/2014", "TP", 2),
                        new Nota("10/05/2014", "2º Parcial", 2),
                        new Nota("10/06/2014", "Final", 2)
                    }
                ),

                new Materia("Taller de computacion VI", 2016, 6,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 10),
                        new Nota("10/04/2014", "TP", 10),
                        new Nota("10/05/2014", "2º Parcial", 10),
                        new Nota("10/06/2014", "Final", 10)
                    }
                ),

                new Materia("Programacion VI", 2016, 6,
                    new List<Nota>() {
                        new Nota("10/03/2014", "1º Parcial", 10),
                        new Nota("10/04/2014", "TP", 10),
                        new Nota("10/05/2014", "2º Parcial", 10),
                        new Nota("10/06/2014", "Final", 10)
                    }
                )
            };

            Console.WriteLine("***********************************************************************");

            var primerCuatrimestreQuery = from materia in materias where materia._cuatrimestre == 1 select materia;
            Console.WriteLine("* Consulta: Materias del primer cuatrimestre");
            Console.WriteLine();
            foreach (var query in primerCuatrimestreQuery)
            {
                Console.Write("*  Materia: " + query._nombre);
                Console.Write(" (Cuatrimestre: " + query._cuatrimestre);
                Console.WriteLine(" / Año: " + query._año + ")");
            }

            Console.WriteLine("***********************************************************************");

            var materiasOrdenQuery = from materia in materias orderby materia._nombre select materia;
            Console.WriteLine("* Consulta: Materias ordenadas alfabeticamente");
            Console.WriteLine();
            foreach (var query in materiasOrdenQuery)
            {
                Console.WriteLine("*  Materia: " + query._nombre);
            }

            Console.WriteLine("***********************************************************************");

            var notasTpQuery = from materia in materias from nota in materia._notas where nota._tipo == "TP" select nota;
            Console.WriteLine("* Consulta: Notas de TP");
            Console.WriteLine();
            foreach (var query in notasTpQuery)
            {
                Console.WriteLine("*  Tipo: " + query._tipo + " / " + "Nota: " + query._valor);
            }

            Console.WriteLine("***********************************************************************");

            Console.WriteLine("* Promedio de las notas de cada materia");

            foreach (var materia in materias)
            {
                Console.WriteLine("Materia: " + materia._nombre + " / " + "Promedio: " + materia.PromedioNotas());
            }

            Console.ReadKey();
        }
    }
}
