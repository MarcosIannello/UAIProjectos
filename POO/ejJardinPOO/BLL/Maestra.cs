using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class Maestra: Persona
    {
        public Maestra(string nombre, int edad):base( nombre,  edad) 
        { 
            this.Nombre = nombre;
            this.Edad = edad;
        }
    }
}
