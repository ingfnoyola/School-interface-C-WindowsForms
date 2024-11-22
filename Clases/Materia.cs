using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuela_3.Clases
{
    public class Materia
    {
        public string NombreMateria { get; set; }
        public int Creditos { get; set; }
        public float Calificacion   { get; set; }
        public string ClaveMateria { get; set; }

        public Materia(string nombreMateria, int creditos, float calificacion, 
            string claveMateria)
        {
            NombreMateria = nombreMateria;
            Creditos = creditos;
            Calificacion = calificacion;
            ClaveMateria = claveMateria;
        }
    }
}
