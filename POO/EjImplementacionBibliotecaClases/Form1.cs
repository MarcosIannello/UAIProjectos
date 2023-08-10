using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace EjImplementacionBibliotecaClases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona persona = new Persona();

        private void Form1_Load(object sender, EventArgs e)
        {
            persona.Nombre = "Marcos";
            persona.Legajo = 1;

            MessageBox.Show($"Hola {persona.Nombre} su legajo es {persona.Legajo}");
        }
    }
}
