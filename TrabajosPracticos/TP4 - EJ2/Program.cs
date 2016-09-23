using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4___EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Materia> PrimerAño = new List<Materia>()
            {
                new Materia("Introducción a la Informática", "Miraglia, Sebastián", "Lunes", "09:00"),
                new Materia("Organización Empresarial", "Sartorelli, Hernán", "Lunes", "11:00"),
                new Materia("Programación I", "Montoto, Elda", "Viernes", "09:00"),
                new Materia("Taller de computacion I", "Catronuovo", "Martes", "11:00"),
                new Materia("Ingles Tecnico I", "Bekerman Andres", "Miercoles", "09:00")
            };

            List<Materia> SegundoAño = new List<Materia>()
            {
                new Materia("Modelo estrategicos de negocios", "Fenocci Hector", "Lunes", "09:00"),
                new Materia("Diseño y administracion de base de datos", "Fernandez Da Silva", "Miercoles", "09:00"),
                new Materia("Programacion III", "Melillo Marta", "Jueves", "09:00"),
                new Materia("Taller de compuntacion III", "Melillo Marta", "Viernes", "09:00"),
                new Materia("Etica", "Paonessa Fernanda", "Lunes", "11:00")
            };

            List<Materia> TercerAño = new List<Materia>()
            {
                new Materia("Taller de computación VI", "Almiñana Gabriel", "Lunes", "18:40"),
                new Materia("Seminario de tecnología", "Cudek Misael", "Lunes", "20:50"),
                new Materia("Seguridad e integridad de sistemas", "Romanos Pablo", "Martes", "18:40"),
                new Materia("Seminario de sistemas", "Romanos Pablo", "Miércoles", "18:40"),
                new Materia("Computación Avanzada", "Breitman Alejandro", "Jueves", "18:40")
            };


            Dictionary<int, List<Materia>> MateriasAnuales = new Dictionary<int, List<Materia>>()
            {
                { 2014, PrimerAño },
                { 2013, SegundoAño },
                { 2015, TercerAño }
            };

            foreach (KeyValuePair<int, List<Materia>> materia in MateriasAnuales)
            {
                Console.Write("*****************************************************************");
                Console.WriteLine("*************************************************************");
                Console.WriteLine("      Año:  " + materia.Key);
                Console.Write("*****************************************************************");
                Console.WriteLine("*************************************************************");

                foreach (Materia asignatura in materia.Value)
                {
                    Console.Write("*  Materia: " + asignatura._nombre);
                    Console.Write(" ||  Profesor: " + asignatura._profesor);
                    Console.Write(" ||  Día: " + asignatura._dia);
                    Console.WriteLine(" || Horario: " + asignatura._horario); 
                }
            }
            Console.ReadKey();
        }
    }
}
