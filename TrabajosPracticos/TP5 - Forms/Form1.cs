using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5___Forms
{
    public partial class Form1 : Form
    {

        private string materia, fecha, nombre, apellido, legajo;
        private int nota;
        private DateTime f;
        private int[] notas = new int[10];
        List<MateriaAlumno> materias_alumno = new List<MateriaAlumno>();
        List<Materia> materias = new List<Materia>() {
            new Materia("Taller VI"),
            new Materia("Seminario de Tecnologia"),
            new Materia("Seminario de Sistemas"),
            new Materia("Computacion Avanzada"),
            new Materia("Seguridad Informatica")
        };
        
        public Form1()
        {
            InitializeComponent();
            comboBox_materia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_notas.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var values in materias)
            {
                comboBox_materia.Items.Add(values.nombre);
            }

            for (int i = 0; i < notas.Length; i++)
            {
                comboBox_notas.Items.Add(i + 1);
            }
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            nombre = textBox_nombre.Text;
        }

        private void textBox_apellido_TextChanged(object sender, EventArgs e)
        {
            apellido = textBox_apellido.Text;
        }

        private void textBox_legajo_TextChanged(object sender, EventArgs e)
        {
            legajo = textBox_legajo.Text;
        }

        private void comboBox_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            object m = comboBox_materia.SelectedItem;
            materia = Convert.ToString(m);
        }

        private void textBox_fecha_TextChanged(object sender, EventArgs e)
        { 
            fecha = textBox_fecha.Text;
        } 

        private void comboBox_notas_SelectedIndexChanged(object sender, EventArgs e)
        {
            object n = comboBox_notas.SelectedItem;
            nota = Convert.ToInt16(n);
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            listBox_materias.Items.Clear();
            MateriaAlumno mat = new MateriaAlumno(materia, fecha, nota);
            materias_alumno.Add(mat);
            foreach (var values in materias_alumno)
            {
                listBox_materias.Items.Add("Materia: " + values.nombre);
                listBox_materias.Items.Add("Fecha:" + values.fecha);
                listBox_materias.Items.Add("Nota:" + values.nota);
                listBox_materias.Items.Add("--------------------------------------------");
            }
            textBox_fecha.Clear();
            comboBox_materia.SelectedIndex = -1;
            comboBox_notas.SelectedIndex = -1;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_fecha.Clear();
            comboBox_materia.SelectedIndex = -1;
            comboBox_notas.SelectedIndex = -1;
        }

        private void button_guardarTodo_Click(object sender, EventArgs e)
        {
            listBox_detalle.Items.Clear();
            listBox_materias.Items.Clear();
            listBox_detalle.Items.Add("Alumno: " + nombre + " " + apellido);
            listBox_detalle.Items.Add("Legajo: " + legajo);
            listBox_detalle.Items.Add("Materias: ");
            foreach (var values in materias_alumno)
            {
                listBox_detalle.Items.Add("   - " + values.nombre + " | Fecha: " + values.fecha + " | Nota: " + values.nota);
            }
            textBox_nombre.Clear();
            textBox_apellido.Clear();
            textBox_legajo.Clear();
            textBox_fecha.Clear();
            comboBox_materia.SelectedIndex = -1;
            comboBox_notas.SelectedIndex = -1;
        }

        private void button_borrarTodo_Click(object sender, EventArgs e)
        {
            textBox_nombre.Clear();
            textBox_apellido.Clear();
            textBox_legajo.Clear();
            textBox_fecha.Clear();
            listBox_detalle.Items.Clear();
            listBox_materias.Items.Clear();
            comboBox_materia.SelectedIndex = -1;
            comboBox_notas.SelectedIndex = -1;
        }

    }
}
