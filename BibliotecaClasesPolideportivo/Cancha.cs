using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGuia6Polideportivo
{
    public class Cancha
    {

		public Cancha() 
		{
			jueces = new List<Juez>();
			
		}

		private int numCancha;

		public int NumCancha
		{
			get { return numCancha; }
			set { numCancha = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		private float valorXHora;

		public float ValorXHora
		{
			get { return valorXHora; }
			set { valorXHora = value; }
		}

		private int cantidadVecesAlquiladas;

		public int CantidadVecesAlquiladas
		{
			get { return cantidadVecesAlquiladas; }
			set { cantidadVecesAlquiladas = value; }
		}

		private bool ocupada;

		public bool Ocupada
		{
			get { return ocupada; }
			set { ocupada = value; }
		}


		private List<Juez> jueces;

		public List<Juez> Jueces
		{
			get { return jueces; }
			set { jueces = value; }
		}

	}
}
