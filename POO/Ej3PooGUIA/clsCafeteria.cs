using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3PooGUIA
{
    public class clsCafeteria
    {
		private int recaudacionTotal;

		public int RecaudacionTotal
		{
			get { return recaudacionTotal; }
			set { recaudacionTotal = value; }
		}

		private List<clsMaquinacafe> listadoMaquinas;

		public List<clsMaquinacafe> ListadoMaquinas
		{
			get { return listadoMaquinas; }
			set { listadoMaquinas = value; }
		}


	}
}
