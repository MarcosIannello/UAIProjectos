using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjHotel
{
    public class Reserva
    {

		private string habitacion;

		public string Habitacion
		{
			get { return habitacion; }
			set { habitacion = value; }
		}

		private List<Huesped> huesped;

		public List<Huesped> Huesped
		{
			get { return huesped; }
			set { huesped = value; }
		}

		private int cantDias;

		public int CantDias
		{
			get { return cantDias; }
			set { cantDias = value; }
		}

		private string fechaInicio;

		public string FechaInicio
		{
			get { return fechaInicio; }
			set { fechaInicio = value; }
		}

		private string fechaFin;

		public string FechaFin
		{
			get { return fechaFin; }
			set { fechaFin = value; }
		}

		private float deposito;

		public float Deposito
		{
			get { return deposito; }
			set { deposito = value; }
		}

		private float precioFinal;

		public float PrecioFinal
		{
			get { return precioFinal; }
			set { precioFinal = value; }
		}

		private bool abonado;

		public bool Abonado
		{
			get { return abonado; }
			set { abonado = value; }
		}

		public string datosReserva()
		{
			string validacion;

			if (this.abonado)
			{
				validacion = "SI";
			}
			else
			{
                validacion = "NO";
            }

			string frase = $"La reserva de una Habitacion {this.habitacion} para {this.huesped.Count()} huespedes, " +
				$"Por un total de {this.cantDias} Dias tiene un precio final de {this.precioFinal} " +
				$"El valor total de la reserva {validacion} ha sido Cancelado";

			return frase;
		}


	}
}
