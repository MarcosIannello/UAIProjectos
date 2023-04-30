using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2guiaEstacionServicio
{
    public partial class frmCrearCombustible : Form
    {
        public frmCrearCombustible()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            clsNafta nafta = new clsNafta();

            nafta.Nombre = cbNombreCombustible.SelectedItem.ToString();

            if (cbNombreCombustible.SelectedItem.ToString() == "Super")
            {
                nafta.Precio = 18.85f;
                txtPrecioNafta.Text = nafta.Precio.ToString();

            }else if (cbNombreCombustible.SelectedItem.ToString() == "Premium")
            {
                nafta.Precio = 21.30f;
                txtPrecioNafta.Text = nafta.Precio.ToString();
            }
            else if (cbNombreCombustible.SelectedItem.ToString() == "Normal")
            {
                nafta.Precio = 17.80f;
                txtPrecioNafta.Text = nafta.Precio.ToString();
            }


            MessageBox.Show($"Se creo la nafta {nafta.Nombre} cuyo precio es {nafta.Precio}");
            nafta.ListaNaftas.Add(nafta);
        }
    }
}
