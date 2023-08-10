using EjGuia6Polideportivo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesPolideportivo
{
    public class Polideportivo
    {

		public Polideportivo()
		{
			jueces = new List<Juez>();
			totalCanchas = new List<Cancha>();
		}

		private List<Cancha> totalCanchas;

		public List<Cancha> TotalCanchas
		{
			get { return totalCanchas; }
			set { totalCanchas = value; }
		}


		private List<Juez> jueces;

		public List<Juez> Jueces
		{
			get { return jueces; }
			set { jueces = value; }
		}

		private float recaudacionTotal;

		public float RecaudacionTotal
		{
			get { return recaudacionTotal; }
			set { recaudacionTotal = value; }
		}

		private float gananciaTotal;

		public float GananciaTotal
		{
			get { return gananciaTotal; }
			set { gananciaTotal = value; }
		}

		private float gastos;

		public float Gastos
		{
			get { return gastos; }
			set { gastos = value; }
		}


		public float CalcularGanacias()
		{
            if (jueces != null)
			{
				foreach(Juez juez in jueces)
				{
					this.gastos += juez.Recaudado;
				}
			}

			this.gananciaTotal = this.recaudacionTotal - this.gastos;
			return this.gananciaTotal;
		}

	}
}
