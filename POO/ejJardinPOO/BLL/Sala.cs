using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Sala : IComparable<Sala>
    {
		public Sala(string nombre,int cupoAlumnos, int cupoMaestras)
		{
			this.nombre = nombre;
			this.cupoMaxAlumnos = cupoAlumnos;
			this.cupoMaxMaestras = cupoMaestras;
			this.alumnos = new List<Alumno>();
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private int cupoMaxAlumnos;

		public int CupoMaxAlumnos
		{
			get { return cupoMaxAlumnos; }
			set { cupoMaxAlumnos = value; }
		}

		private int cupoMaxMaestras;

		public int CupoMaxMaestras
		{
			get { return cupoMaxMaestras; }
			set { cupoMaxMaestras = value; }
		}

		private List<Alumno> alumnos;

		public List<Alumno> Alumnos
		{
			get { return alumnos; }
			set { alumnos = value; }
		}

		private bool poseeCupos;

		public bool PoseeCupos
		{
			get { return poseeCupos; }
			set { poseeCupos = value; }
		}


		public void validarCupoAlumnos()
		{
			if (this.Alumnos.Count >= this.cupoMaxAlumnos)
			{
				this.PoseeCupos = false;
			}
			else
			{
				this.PoseeCupos = true;
			}
		}

		public int CompareTo(Sala sala)
		{
			return this.nombre.CompareTo(sala.nombre);
		}


	}
}
