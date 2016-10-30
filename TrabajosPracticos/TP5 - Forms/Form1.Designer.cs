namespace TP5___Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_legajo = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_legajo = new System.Windows.Forms.TextBox();
            this.label_materia = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_nota = new System.Windows.Forms.Label();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.listBox_materias = new System.Windows.Forms.ListBox();
            this.comboBox_materia = new System.Windows.Forms.ComboBox();
            this.comboBox_notas = new System.Windows.Forms.ComboBox();
            this.button_guardarTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_detalle = new System.Windows.Forms.ListBox();
            this.button_borrarTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(12, 31);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(79, 24);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.Location = new System.Drawing.Point(12, 81);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(79, 24);
            this.label_apellido.TabIndex = 1;
            this.label_apellido.Text = "Apellido";
            // 
            // label_legajo
            // 
            this.label_legajo.AutoSize = true;
            this.label_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_legajo.Location = new System.Drawing.Point(12, 133);
            this.label_legajo.Name = "label_legajo";
            this.label_legajo.Size = new System.Drawing.Size(67, 24);
            this.label_legajo.TabIndex = 2;
            this.label_legajo.Text = "Legajo";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(97, 31);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(210, 26);
            this.textBox_nombre.TabIndex = 3;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_apellido.Location = new System.Drawing.Point(97, 81);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(210, 26);
            this.textBox_apellido.TabIndex = 4;
            this.textBox_apellido.TextChanged += new System.EventHandler(this.textBox_apellido_TextChanged);
            // 
            // textBox_legajo
            // 
            this.textBox_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_legajo.Location = new System.Drawing.Point(97, 135);
            this.textBox_legajo.Name = "textBox_legajo";
            this.textBox_legajo.Size = new System.Drawing.Size(210, 26);
            this.textBox_legajo.TabIndex = 5;
            this.textBox_legajo.TextChanged += new System.EventHandler(this.textBox_legajo_TextChanged);
            // 
            // label_materia
            // 
            this.label_materia.AutoSize = true;
            this.label_materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_materia.Location = new System.Drawing.Point(12, 186);
            this.label_materia.Name = "label_materia";
            this.label_materia.Size = new System.Drawing.Size(71, 24);
            this.label_materia.TabIndex = 0;
            this.label_materia.Text = "Materia";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(12, 238);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(64, 24);
            this.label_fecha.TabIndex = 8;
            this.label_fecha.Text = "Fecha";
            // 
            // label_nota
            // 
            this.label_nota.AutoSize = true;
            this.label_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nota.Location = new System.Drawing.Point(12, 294);
            this.label_nota.Name = "label_nota";
            this.label_nota.Size = new System.Drawing.Size(49, 24);
            this.label_nota.TabIndex = 9;
            this.label_nota.Text = "Nota";
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fecha.Location = new System.Drawing.Point(97, 240);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.Size = new System.Drawing.Size(210, 26);
            this.textBox_fecha.TabIndex = 10;
            this.textBox_fecha.TextChanged += new System.EventHandler(this.textBox_fecha_TextChanged);
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(97, 334);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(98, 27);
            this.button_guardar.TabIndex = 12;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(201, 334);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(106, 27);
            this.button_cancelar.TabIndex = 13;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // listBox_materias
            // 
            this.listBox_materias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_materias.FormattingEnabled = true;
            this.listBox_materias.ItemHeight = 16;
            this.listBox_materias.Location = new System.Drawing.Point(97, 378);
            this.listBox_materias.Name = "listBox_materias";
            this.listBox_materias.Size = new System.Drawing.Size(210, 244);
            this.listBox_materias.TabIndex = 14;
            // 
            // comboBox_materia
            // 
            this.comboBox_materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_materia.FormattingEnabled = true;
            this.comboBox_materia.Location = new System.Drawing.Point(97, 186);
            this.comboBox_materia.Name = "comboBox_materia";
            this.comboBox_materia.Size = new System.Drawing.Size(210, 28);
            this.comboBox_materia.TabIndex = 15;
            this.comboBox_materia.SelectedIndexChanged += new System.EventHandler(this.comboBox_materia_SelectedIndexChanged);
            // 
            // comboBox_notas
            // 
            this.comboBox_notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_notas.FormattingEnabled = true;
            this.comboBox_notas.Location = new System.Drawing.Point(97, 290);
            this.comboBox_notas.Name = "comboBox_notas";
            this.comboBox_notas.Size = new System.Drawing.Size(210, 28);
            this.comboBox_notas.TabIndex = 16;
            this.comboBox_notas.SelectedIndexChanged += new System.EventHandler(this.comboBox_notas_SelectedIndexChanged);
            // 
            // button_guardarTodo
            // 
            this.button_guardarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardarTodo.Location = new System.Drawing.Point(97, 645);
            this.button_guardarTodo.Name = "button_guardarTodo";
            this.button_guardarTodo.Size = new System.Drawing.Size(210, 47);
            this.button_guardarTodo.TabIndex = 17;
            this.button_guardarTodo.Text = "Guardar Todo";
            this.button_guardarTodo.UseVisualStyleBackColor = true;
            this.button_guardarTodo.Click += new System.EventHandler(this.button_guardarTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Detalle";
            // 
            // listBox_detalle
            // 
            this.listBox_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_detalle.FormattingEnabled = true;
            this.listBox_detalle.ItemHeight = 16;
            this.listBox_detalle.Location = new System.Drawing.Point(365, 59);
            this.listBox_detalle.Name = "listBox_detalle";
            this.listBox_detalle.Size = new System.Drawing.Size(386, 612);
            this.listBox_detalle.TabIndex = 19;
            // 
            // button_borrarTodo
            // 
            this.button_borrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrarTodo.Location = new System.Drawing.Point(629, 677);
            this.button_borrarTodo.Name = "button_borrarTodo";
            this.button_borrarTodo.Size = new System.Drawing.Size(122, 36);
            this.button_borrarTodo.TabIndex = 20;
            this.button_borrarTodo.Text = "Borrar Detalle";
            this.button_borrarTodo.UseVisualStyleBackColor = true;
            this.button_borrarTodo.Click += new System.EventHandler(this.button_borrarTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 732);
            this.Controls.Add(this.button_borrarTodo);
            this.Controls.Add(this.listBox_detalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_guardarTodo);
            this.Controls.Add(this.comboBox_notas);
            this.Controls.Add(this.comboBox_materia);
            this.Controls.Add(this.listBox_materias);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.label_materia);
            this.Controls.Add(this.textBox_fecha);
            this.Controls.Add(this.label_nota);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.textBox_legajo);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_legajo);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_legajo;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_legajo;
        private System.Windows.Forms.Label label_materia;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_nota;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.ListBox listBox_materias;
        private System.Windows.Forms.ComboBox comboBox_materia;
        private System.Windows.Forms.ComboBox comboBox_notas;
        private System.Windows.Forms.Button button_guardarTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_detalle;
        private System.Windows.Forms.Button button_borrarTodo;
    }
}

