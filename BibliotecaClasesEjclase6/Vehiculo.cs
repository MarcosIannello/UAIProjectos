using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjclase6
{
    public abstract class Vehiculo
    {
		private string patente;

		public string Patente
		{
			get { return patente; }
			set { patente = value; }
		}

		private int cantHoras;

		public int CantHoras
		{
			get { return cantHoras; }
			set { cantHoras = value; }
		}

		private float precioXHora;

		public float PrecioXHora
		{
			get { return precioXHora; }
			set { precioXHora = value; }
		}

		public float calcularPrecio()
		{
			return precioXHora*cantHoras;
		}
	}
}
