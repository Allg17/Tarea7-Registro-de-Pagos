using Inscripcion.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Inscripcion
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }


        private void Consultabutton(object sender, EventArgs e)
        {
            CEstudiantes cpersonas = new CEstudiantes();
            cpersonas.Show();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
              Estudiantes estudiante = LlenaClase();
            

            if(BLL.EstudianteBLL.Guardar(estudiante))
            {
                MessageBox.Show("Guardado");
            }

        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            int a;
            int.TryParse(PersonaIdtextBox.Text, out a);
            estudiante.EstudianteId = a;
            estudiante.Nombre= NombrestextBox.Text;
            estudiante.Monto = (decimal)MontonumericUpDown.Value;
            estudiante.Observaciones = txObservacion.Text;
            estudiante.FechaActual = FechadateTimePicker.Value;
            return estudiante;
        }

        private void Nuevobutto(object sender, EventArgs e)
        {

            NombrestextBox.Clear();
            PersonaIdtextBox.Clear();
            MontonumericUpDown.Value = 0;
            txObservacion.Clear();
            FechadateTimePicker.Value = DateTime.Now;


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes eliminar = new Estudiantes();
            
            int ID;
            int.TryParse(PersonaIdtextBox.Text, out ID);

            if (BLL.EstudianteBLL.Eliminar(ID))
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(PersonaIdtextBox.Text, out ID);

            estudiante = BLL.EstudianteBLL.Buscar(ID);

            if(estudiante!=null)
            {
                NombrestextBox.Text = estudiante.Nombre;
                MontonumericUpDown.Value = Convert.ToDecimal(estudiante.Monto);
                txObservacion.Text = estudiante.Observaciones;
                FechadateTimePicker.Value = estudiante.FechaActual;

            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
 
             if(BLL.EstudianteBLL.Modificar(LlenaClase()))
                MessageBox.Show("Modificado");

        }
    }
}
