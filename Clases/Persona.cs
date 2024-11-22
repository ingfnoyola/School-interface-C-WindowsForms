using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuela_3.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int Edad {  get; set; }

        public Persona(string nombre, string clave, int edad)
        {
            Nombre = nombre;
            Clave = clave;
            Edad = edad;
        }
    }
}
