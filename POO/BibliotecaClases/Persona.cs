using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Persona
    {
		private int legajo;

		public int Legajo
		{
			get { return legajo; }
			set { legajo = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}


	}
}
