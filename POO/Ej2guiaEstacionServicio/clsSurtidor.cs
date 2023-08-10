using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2guiaEstacionServicio
{
    public class clsSurtidor
    {

		private int numSurtidor;

		public int NumSurtidor
		{
			get { return numSurtidor; }
			set { numSurtidor = value; }
		}


		private clsNafta nafta;	

		public clsNafta Nafta
		{
			get { return nafta; }
			set { nafta = value; }
		}

		private int litroscargados;

		public int LitrosCargados
		{
			get { return litroscargados; }
			set { litroscargados = value; }
		}

		private int capacidad;

		public int Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}






	}
}
