using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_6_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Jugador Messi = new Jugador();
        private void btnPatear_Click(object sender, EventArgs e)
        {
            Messi.Festejar += Messi_Festejar;
            Messi.Insultar += Messi_Insultar;
            Messi.Patear();
        }
        private void Messi_Insultar (string mensaje, int volumen)
        {
            label1.Text = mensaje + " " + volumen.ToString();
        }
        private void Messi_Festejar (string mensaje)
        {
            label1.Text = mensaje;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
