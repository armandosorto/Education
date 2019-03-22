using Education.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var alumnosBL = new AlumnosBL();
            var listaAlumnos = alumnosBL.ObtenerAlumnos();

            listaAlumnosBindingSource.DataSource = listaAlumnos;
        }

        private void listaAlumnosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
