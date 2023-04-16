using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1GuiaPOO_Libreria
{
    public partial class frmLibreria : Form
    {
        public frmLibreria()
        {
            InitializeComponent();
        }

        int num;
        clsLibreria Libreria = new clsLibreria();
        List<clsProducto> ListaProductos = new List<clsProducto>();
        private void frmLibreria_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            num++;

            clsProducto Product = new clsProducto();

            Product.Nombre = txtNombreProdu.Text;
            Product.Precio = float.Parse(txtPrecioProdu.Text);
            Product.Cantidad = int.Parse(txtCantProdu.Text);
            Product.CodigoDeBarras = int.Parse(txtCodBarras.Text);

            borrarTXTS();

            string infoProducto = Product.ProductInfo();
            ListaProductos.Append(Product);

            MessageBox.Show(infoProducto);
        }

        public void borrarTXTS()
        {
            txtCodBarras.Clear();
            txtPrecioProdu.Clear();
            txtCantProdu.Clear();
            txtNombreProdu.Clear();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            foreach(var producto in ListaProductos)
            {
                int i;
                i = 0;
                txtListProducts.Lines[i] = ListaProductos[i].ToString();
                i++;
                txtListProducts.ForeColor = Color.White;
            }
            txtListProducts.Show();

        }
    }
}
