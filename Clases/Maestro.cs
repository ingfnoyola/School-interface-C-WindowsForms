using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuela_3.Clases
{
    public class Maestro : Persona
    {
        public string Categoria {  get; set; }
        public int HorasClase { get; set; }

        public Maestro(string nombreMaestro, string claveMaestro, int edadMaestro) :
            base(nombreMaestro, claveMaestro, edadMaestro)
        {
            Nombre = nombreMaestro;
            Clave = claveMaestro;
            Edad = edadMaestro;
    
        }
    }
}
