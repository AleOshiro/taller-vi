using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___Forms
{
    class MateriaAlumno
    {
        private string _nombre, _fecha;
        private int _nota;
        
        public MateriaAlumno(string nombre, string fecha, int nota)
        {
            this._nombre = nombre;
            this._fecha = fecha;
            this._nota = nota;
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

        public string fecha
        {
            set
            {
                _fecha = value;
            }

            get
            {
                return _fecha;
            }
        }

        public int nota
        {
            set
            {
                _nota = value;
            }

            get
            {
                return _nota;
            }
        }

    }
}
