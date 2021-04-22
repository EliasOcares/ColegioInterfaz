using ColegioInterfaz.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ColegioInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();


            comboCursos.DataSource = bd.Cursos.ToList();
            comboCursos.DisplayMember = "Nombre";



            

            //textBoxProfesor.Text = bd.Profesores.Where(profesore => profesore.idProfesor == 1).ToString();

            
            



        }

        private void comboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContextBD bd = new ContextBD();


            Curso cursoSeleccionado = (Curso)comboCursos.SelectedItem;

            List<Alumno> alumnosDelCurso = bd.Alumnos.Where(Alumno => Alumno.idCurso == cursoSeleccionado.idCurso).ToList();

            gridAlumnos.DataSource = alumnosDelCurso;

            gridAlumnos.Columns[0].Visible = false;
            gridAlumnos.Columns[3].Visible = false;
            gridAlumnos.Columns[4].Visible = false;

            List<Profesore> profesorDelCurso = bd.Profesores.Where(Profesore => Profesore.idProfesor == cursoSeleccionado.idProfesor).ToList();

            gridProfesor.DataSource = profesorDelCurso;

            gridProfesor.Columns[0].Visible = false;
            gridProfesor.Columns[2].Visible = false;




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
