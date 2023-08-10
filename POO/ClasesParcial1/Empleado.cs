using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial1
{
    public class Empleado
    {

        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

		private string tipoEmp;

		public string TipoEmp
		{
			get { return tipoEmp; }
			set { tipoEmp = value; }
		}


		private float sueldoBasico = 78500;

		public float SueldoBasico
		{
			get { return sueldoBasico ; }
			set { sueldoBasico = value; }
		}

		private float plus;

		public float Plus	
		{
			get { return plus; }
			set { plus = value; }
		}

		private int horasTrabajadas;

		public int HorasTrabajadas
		{
			get { return horasTrabajadas; }
			set { horasTrabajadas = value; }
		}

		private float sueldoTotal;

		public float SueldoTotal
		{
			get { return sueldoTotal; }
			set { sueldoTotal = value; }
		}

		private int cantEventos;

		public int CantEventos
		{
			get { return cantEventos; }
			set { cantEventos = value; }
		}

		private int precioHora = 4000;

		public int PrecioHora
		{
			get { return precioHora; }
			set { precioHora = value; }
		}

		private int cantHorasTrabajadas;

		public int CantHorasTrabajadas
		{
			get { return cantHorasTrabajadas; }
			set { cantHorasTrabajadas = value; }
		}



		public void calcularSueldo()
		{
			this.sueldoTotal = this.sueldoBasico + this.Plus + (this.horasTrabajadas * this.precioHora);
		}
	}
}
