using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1GuiaPOO_Libreria
{
    public class clsProducto
    {

		private int codigoDeBarras;

		public int CodigoDeBarras
		{
			get { return codigoDeBarras; }
			set { codigoDeBarras = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}


		public string ProductInfo()
		{
			string info = $"El producto {Nombre} Cuyo codigo de barras es {CodigoDeBarras} Posee un precio de ${Precio} y hay una existencia de {Cantidad} unidades";
			return info;
		}

	}
}
