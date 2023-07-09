using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Hospital
    {
		public Hospital() 
		{
			this.medicos = new List<Medico>();
			this.pacientes = new List<Paciente>();
		}

		private List<Medico> medicos;

		public List<Medico> Medicos
		{
			get { return medicos; }
			set { medicos = value; }
		}

		private List<Paciente> pacientes;

		public List<Paciente> Pacientes
		{
			get { return pacientes; }
			set { pacientes = value; }
		}
	}
}
