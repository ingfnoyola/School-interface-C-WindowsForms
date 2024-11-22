using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuela_3.Clases
{
    public class Alumno : Persona
    {

        public List<Materia> ListaMaterias { get; set; }
        public int NumeroMaterias { get; set; }

        public float Promedio { get; set; }
        public Alumno(string nombreAlumno, string claveAlumno, int edadAlumno,
            int numMaterias) : base(nombreAlumno, claveAlumno, edadAlumno)
        {
            Nombre = nombreAlumno;
            Edad = edadAlumno;
            Clave = claveAlumno;
            NumeroMaterias = numMaterias;
            ListaMaterias = new List<Materia>();
        }
        public void CrearMateria(string nomMat, int cred, float calif, string clavMat)
        {
            Materia nuevaMateria = new Materia(nomMat, cred, calif, clavMat);
            ListaMaterias.Add(nuevaMateria);
        }
        public void CrearDocumento(string ruta, List<Persona> lista)
        {

        }
        public void CalcularPromedio()
        {
            float sumaCalificaciones = 0;
            for (int i = 0; i < ListaMaterias.Count; i++)
            {
                sumaCalificaciones = sumaCalificaciones + ListaMaterias[i].Calificacion;

            }
            Promedio = sumaCalificaciones / ListaMaterias.Count;

        }
    }
}
