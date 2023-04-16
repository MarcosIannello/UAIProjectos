using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1GuiaPOO_Libreria
{
    public class clsLibreria
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private float totalVendido;

		public float TotalVendido
		{
			get { return totalVendido; }
			set { totalVendido = value; }
		}

		private float ventaMax;

		public float VentaMax
		{
			get { return ventaMax; }
			set { ventaMax = value; }
		}

		private float ventaMin;

		public float VentaMin
		{
			get { return ventaMin; }
			set { ventaMin = value; }
		}

		private List<clsProducto> _productos;

		public List<clsProducto> Productos
		{
			get { return _productos; }
			set { _productos = value; }
		}

		public void agregarProducto(clsProducto producto)
		{
			Productos.Add(producto);
		}
		


	}
}
