using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5POO
{
    public abstract class clsFuncion
    {
		private int valor1;

		public int Valor1
		{
			get { return valor1; }
			set { valor1 = value; }
		}

		private int valor2;

		public int Valor2
		{
			get { return valor1; }
			set { valor1 = value; }
		}

		public abstract int resolver();

	}
}
