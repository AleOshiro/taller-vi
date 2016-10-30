using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___Forms
{
    class Materia
    {

        private string _nombre;
        
        public Materia(string nombre) {
            this._nombre = nombre;
        }

        public string nombre
        {
            set
            {
                _nombre = value;
            }

            get
            {
                return _nombre;
            }
        }

    }
}
