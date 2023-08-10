using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjHotel
{
    public abstract class Habitacion
    {
		private int numHabitacion;

		public int NumHabitacion
		{
			get { return numHabitacion; }
			set { numHabitacion = value; }
		}


		private string cama;

		public string Cama
		{
			get { return cama; }
			set { cama = value; }
		}

		private float costo;

		public float Costo
		{
			get { return costo; }
			set { costo = value; }
		}

		private bool vistaAlMar;

		public bool VistaAlMar
		{
			get { return vistaAlMar; }
			set { vistaAlMar = value; }
		}

		private bool ocupada;

		public bool Ocupada
		{
			get { return ocupada; }
			set { ocupada = value; }
		}


		private List<Cama> camas;

		public List<Cama> Camas
		{
			get { return camas; }
			set { camas = value; }
		}

		private List<Artefactos> artefactos;

		public List<Artefactos> Artefactos
		{
			get { return artefactos; }
			set { artefactos = value; }
		}

		private float precioAdicional;

		public float PrecioAdicional
		{
			get { return precioAdicional; }
			set { precioAdicional = value; }
		}

		private List<Huesped> huespedes;

		public List<Huesped> Huespedes
		{
			get { return huespedes; }
			set { huespedes = value; }
		}


	}
}
