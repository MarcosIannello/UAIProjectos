using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Jardin
    {
		public Jardin() 
		{
			this.Salas = new List<Sala>();
			this.cantAlumnos = 0;
			this.ALUMNOSJARDIN = new List<Alumno>();
		}

		private List<Sala> salas;

		public List<Sala> Salas
		{
			get { return salas; }
			set { salas = value; }
		}

		private List<Alumno> AlumnosJardin;

		public List<Alumno> ALUMNOSJARDIN
		{
			get { return AlumnosJardin; }
			set { AlumnosJardin = value; }
		}


		private int cantAlumnos;

		public int CantAlumnos
		{
			get { return cantAlumnos; }
			set { cantAlumnos = value; }
		}

	}
}
