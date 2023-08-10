using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinalPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void delegado(string texto);

        delegado d;

        private void Form1_Load(object sender, EventArgs e)
        {
            d = mostrarTexto;
        }

        public void mostrarTexto(string texto)
        {
            MessageBox.Show("Bienvenido al sistema " + texto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d(textBox1.Text);
        }
    }
}
