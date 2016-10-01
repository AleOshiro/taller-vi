using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___EJ1
{
    static class Promedio
    {
        public static double PromedioNotas(this Materia materia)
        {
            int cantidadNotas = 4;
            double total = 0, promedio = 0;

            foreach(var nota in materia._notas)
            {
                total = total + nota._valor;
            }

            promedio = total / cantidadNotas;
            return promedio;
        }
    }
}
