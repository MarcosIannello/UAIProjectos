using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2guiaEstacionServicio
{
    public class clsNafta
    {

		public clsNafta() {
            ListaNaftas = new List<clsNafta>();
        }

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private List<clsNafta> listaNaftaas;

		public List<clsNafta> ListaNaftas
		{
			get { return listaNaftaas; }
			set { listaNaftaas = value; }
		}

	}
}
