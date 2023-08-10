using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2guiaEstacionServicio
{
    public class clsVenta
    {
		private clsSurtidor surtidor;

		public clsSurtidor Surtidor
		{
			get { return surtidor; }
			set { surtidor = value; }
		}

		private clsNafta tipoCombustible;

		public clsNafta TipoCombustible
		{
			get { return tipoCombustible; }
			set { tipoCombustible = value; }
		}


		private float total;

		public float Total
		{
			get { return total; }
			set { total = value; }
		}





	}
}
