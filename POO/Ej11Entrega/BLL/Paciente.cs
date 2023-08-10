using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Paciente:Persona
    {
		public Paciente(string nombre, int id, string coberturaMedica)
		{
            this.Nombre = nombre;
			this.Id = id;
			this.CoberturaMedica = coberturaMedica;
		}

		private string coberturaMedica;

		public string CoberturaMedica
		{
			get { return coberturaMedica; }
			set { coberturaMedica = value; }
		}
	}
}
