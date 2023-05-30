using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGuia6Polideportivo
{
    public abstract class Cancha
    {
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


		//public float calcularPrecioConJuez()
		//{

		//}
	}
}
