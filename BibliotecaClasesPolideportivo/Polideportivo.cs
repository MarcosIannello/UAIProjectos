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
			canchasTenis = new List<CanchaTenis>();
			canchasF5 = new List<CanchaF5>();
			canchasF7 = new List<CanchaF7>();
			canchasF11 = new List<CanchaF11>();
			jueces = new List<Juez>();
			totalCanchas = new List<string>();
		}

		private List<string> totalCanchas;

		public List<string> TotalCanchas
		{
			get { return totalCanchas; }
			set { totalCanchas = value; }
		}


		private List<CanchaTenis> canchasTenis;

		public List<CanchaTenis> CanchasTenis
		{
			get { return canchasTenis; }
			set { canchasTenis = value; }
		}

		private List<CanchaF5> canchasF5;

		public List<CanchaF5> CanchasF5
		{
			get { return canchasF5; }
			set { canchasF5 = value; }
		}

		public List<CanchaF7> canchasF7;

        public List<CanchaF7> CanchasF7
        {
            get { return canchasF7; }
            set { canchasF7 = value; }
        }

		private List<CanchaF11> canchasF11;

		public List<CanchaF11> CanchasF11
		{
			get { return canchasF11; }
			set { canchasF11 = value; }
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
