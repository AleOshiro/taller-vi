using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2___EJ2
{
    class CajaDeCambio : CajaDeCambioInterface
    {
        /*
        enum type {
            automatico,
            manual
        }
        */

        string[] type = new string[] { "automatico", "manual" };

        public int cantidadCambios { get; set; }

        public string tipo { get; set; }

        public CajaDeCambio(int cantidadCambios, string tipo) {
            
            if (!type.Contains(tipo)){

                Console.WriteLine("Tiene que ser automatico o manual");
            }
            this.tipo = tipo;
            this.cantidadCambios = cantidadCambios;
        }
    }
}
