using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4___EJ1
{
    class Materia
    {
        private string nombre, profesor, dia, horario;

        public Materia(string _nombre, string _profesor, string _dia, string _horario)
        {
            this.nombre = _nombre;
            this.profesor = _profesor;
            this.dia = _dia;
            this.horario = _horario;
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

        public string _profesor
        {
            set
            {
                profesor = value;
            }
            get
            {
                return profesor;
            }
        }

        public string _dia
        {
            set
            {
                dia = value;
            }
            get
            {
                return dia;
            }
        }

        public string _horario
        {
            set
            {
                horario = value;
            }
            get
            {
                return horario;
            }
        }
    }
}
