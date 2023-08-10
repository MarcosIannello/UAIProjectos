using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjclase6
{
    public class Ingreso
    {
		private int nroFactura;

		public int NroFactura
		{
			get { return nroFactura; }
			set { nroFactura = value; }
		}

		private string patente;

		public string Patente
		{
			get { return patente; }
			set { patente = value; }
		}

		private string tipoVehiculo;

		public string TipoVehiculo
		{
			get { return tipoVehiculo; }
			set { tipoVehiculo = value; }
		}

		private int cantHoras;

		public int CantHoras
		{
			get { return cantHoras; }
			set { cantHoras = value; }
		}

	}
}
