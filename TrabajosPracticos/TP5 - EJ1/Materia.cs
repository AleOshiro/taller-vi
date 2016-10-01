using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5___EJ1
{
    class Materia
    {
        private string nombre;
        private int año, cuatrimestre;
        private List<Nota> notas = new List<Nota>();


        public Materia(string _nombre, int _año, int _cuatrimestre, List<Nota> _notas)
        {
            this.nombre = _nombre;
            this.año = _año;
            this.cuatrimestre = _cuatrimestre;
            this.notas = _notas;
        }

        public string _nombre
        {
            set
            {
                nombre = value;
            }

            get
            {
                return nombre;
            }
        }

        public int _año
        {
            set
            {
                año = value;
            }
            get
            {
                return año;
            }
        }

        public int _cuatrimestre
        {
            set
            {
                cuatrimestre = value;
            }
            get
            {
                return cuatrimestre;
            }
        }

        public List<Nota> _notas
        {
            set
            {
                notas = value;
            }
            get
            {
                return notas;
            }
        }
        /*
        public void addNota(string fecha, string tipo, int valor)
        {
            notas.Add(new Nota(fecha, tipo, valor));
        }
        */
    }
}
