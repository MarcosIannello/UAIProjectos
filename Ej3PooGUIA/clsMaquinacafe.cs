using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3PooGUIA
{
    public class clsMaquinacafe
    {
		public clsMaquinacafe()
		{
			List<clsTipoCafe> tiposDeCafe = new List<clsTipoCafe>();
			List<clsTipodeVaso> tipoDeVaso = new List<clsTipodeVaso>();
		}	

		private int capacidad;

		public int Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}

		private int cantidadRecargas;

		public int CantidadRecargas
		{
			get { return cantidadRecargas; }
			set { cantidadRecargas = value; }
		}

		private int recaudacionTotal;

		public int RecaudacionTotal
		{
			get { return recaudacionTotal; }
			set { recaudacionTotal = value; }
		}


		private List<clsTipoCafe> listadoCafes;

		public List<clsTipoCafe> ListadoCafes
		{
			get { return listadoCafes; }
			set { listadoCafes = value; }
		}

		private List<clsTipodeVaso> listadoVasos;

		public List<clsTipodeVaso> ListadoVasos
		{
			get { return listadoVasos; }
			set { listadoVasos = value; }
		}





	}
}
