using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2guiaEstacionServicio
{
    public class clsEstacionServicio
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string Ubicacion;

		public string MyProperty
		{
			get { return Ubicacion; }
			set { Ubicacion = value; }
		}

		private int cantVentas;

		public int CantVentas
		{
			get { return cantVentas; }
			set { cantVentas = value; }
		}

		private List<clsSurtidor> surtidores;

		public List<clsSurtidor> Surtidores
		{
			get { return surtidores; }
			set { surtidores = value; }
		}

		









	}
}
