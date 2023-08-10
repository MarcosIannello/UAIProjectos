using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class Alumno:Persona
    {
        public Alumno(string nombre, int edad):base(nombre, edad) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

    }
}
