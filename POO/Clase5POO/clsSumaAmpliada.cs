using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5POO
{
    internal class clsSumaAmpliada:clsSuma
    {
		private int valor3;

		public int Valor3
		{
			get { return valor3; }
			set { valor3 = value; }
		}

        public override int resolver()
        {
            return Valor1 + Valor2 + valor3;
        }

    }
}
