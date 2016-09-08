using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2___EJ2
{
    interface MotorInterface
    {
        double diametro { get; set; }

        void Iniciar();

        void Frenar();
    }
}
