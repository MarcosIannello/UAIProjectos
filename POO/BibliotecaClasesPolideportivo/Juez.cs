using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGuia6Polideportivo
{
    public class Juez
    {
		private string nombreCompleto;

		public string NombreCompleto
		{
			get { return nombreCompleto; }
			set { nombreCompleto = value; }
		}

		private int legajo;

		public int Legajo
		{
			get { return legajo; }
			set { legajo = value; }
		}

		private int partidosDirigidos;

		public int PartidosDirigidos
		{
			get { return partidosDirigidos; }
			set { partidosDirigidos = value; }
		}

		private float recaudado;

		public float Recaudado
		{
			get { return recaudado; }
			set { recaudado = value; }
		}

		private bool ocupado;

		public bool Ocupado
		{
			get { return ocupado; }
			set { ocupado = value; }
		}



	}
}
