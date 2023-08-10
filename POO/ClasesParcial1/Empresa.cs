using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial1
{
    public class Empresa
    {
        public Empresa() 
		{
			this.auxiliares = new List<auxiliar>();
			this.modelos = new List<Modelo>();
			this.publicitarios = new List<Publicitario>();
			this.presentadores = new List<Presentador>();
		}

		private float recaudacionTotal;

		public float RecaudacionTotal
		{
			get { return recaudacionTotal; }
			set { recaudacionTotal = value; }
		}


		private List<auxiliar> auxiliares;

		public List<auxiliar> Auxiliares
		{
			get { return auxiliares; }
			set { auxiliares = value; }
		}

		private List<Modelo> modelos;

		public List<Modelo> Modelos
		{
			get { return modelos; }
			set { modelos = value; }
		}

		private List<Presentador> presentadores;

		public List<Presentador> Presentadores
		{
			get { return presentadores; }
			set { presentadores = value; }
		}

		private List<Publicitario> publicitarios;

		public List<Publicitario> Publicitarios
		{
			get { return publicitarios; }
			set { publicitarios = value; }
		}



	}
}
