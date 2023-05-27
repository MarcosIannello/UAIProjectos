using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjclase6
{
    public class Empresa
    {

		public Empresa()
		{
			Estacionamientos = new List<Estacionamiento>();
			IngresosTotal = new List<Ingreso>();
		}

		private float totalRecaudado;

		public float TotalRecaudado
		{
			get { return totalRecaudado; }
			set { totalRecaudado = value; }
		}

		private List<Estacionamiento> estacionamientos;

		public List<Estacionamiento> Estacionamientos
		{
			get { return estacionamientos; }
			set { estacionamientos = value; }
		}

        private List<Ingreso> ingresosTotal;

        public List<Ingreso> IngresosTotal
        {
            get { return ingresosTotal; }
            set { ingresosTotal = value; }
        }

		private int descAplicados;

		public int DescAplicados
		{
			get { return descAplicados; }
			set { descAplicados = value; }
		}

	}
}
