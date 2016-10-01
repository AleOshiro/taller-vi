using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___EJ1
{
    class Nota
    {
        private string tipo, fecha;
        private int valor;

        public Nota(string _fecha, string _tipo, int _valor)
        {
            this.fecha = _fecha;
            this.tipo = _tipo;
            this.valor = _valor;
        }

        public string _fecha
        {
            set
            {
                fecha = value;
            }
            get
            {
                return fecha;
            }
        }

        public string _tipo
        {
            set
            {
                tipo = value;
            }
            get
            {
                return tipo;
            }
        }

        public int _valor
        {
            set
            {
                valor = value;
            }
            get
            {
                return valor;
            }
        }
    }
}
