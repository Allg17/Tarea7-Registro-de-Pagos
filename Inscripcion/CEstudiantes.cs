using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inscripcion
{
    public partial class CEstudiantes : Form
    {
        public CEstudiantes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            String a;
            a = CriteriotextBox.Text;
            int ID;
            int.TryParse(CriteriotextBox.Text, out ID );

            if (FiltrarcomboBox.SelectedIndex==0)
                 PersonasdataGridView.DataSource = BLL.EstudianteBLL.GetList(t => t.Nombre.Contains(a));
            else
                PersonasdataGridView.DataSource = BLL.EstudianteBLL.GetList(t => t.EstudianteId== ID);





        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PersonasdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
