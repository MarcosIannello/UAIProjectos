using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class Medico : Persona, IComparable<Medico>, ICalculable
	{
		public Medico(Especialidad especialidad, string nombre, int id, int tarifa, int cantTurnosMax)
		{
			this.Especialidad = especialidad;
			this.Nombre = nombre;
			this.Id = id;
			this.tarifa = tarifa;
			this.cantTurnosMax = cantTurnosMax;
			this.Turnos = new List<Turno>();
		}

		private Especialidad especialidad;

		public Especialidad Especialidad
		{
			get { return especialidad; }
			set { especialidad = value; }
		}
		private int cantTurnosMax;

		public int CantTurnosMAx
		{
			get { return cantTurnosMax; }
			set { cantTurnosMax = value; }
		}

		private int tarifa;

		public int Tarifa
		{
			get { return tarifa; }
			set { tarifa = value; }
		}

		private List<Turno> turnos;

		public List<Turno> Turnos
		{
			get { return turnos; }
			set { turnos = value; }
		}

		public int CompareTo(Medico medico)
		{
			return this.Id.CompareTo(medico.Id);
		}

		public int calcularTurnos(int turnosTotales, int turnosTomados)
		{
			int turnosRestantes = turnosTotales - turnosTomados;
			return turnosRestantes;
		}

		int ICalculable.calcularTurnos(int turnosTotales, int turnosTomados)
		{
			throw new NotImplementedException();
		}

    }
}
