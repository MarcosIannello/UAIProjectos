using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsSuma suma = new clsSuma();
        clsResta resta = new clsResta();
        clsMultiplicacion multiplicacion = new clsMultiplicacion();
        clsDividir dividir = new clsDividir();
        clsSumaAmpliada sumaAmpliada = new clsSumaAmpliada();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int resultado;
            suma.Valor1 = int.Parse(txtValor1.Text);
            suma.Valor2 = int.Parse(txtValor2.Text);

            resultado = suma.resolver();

            lblResultadoSuma.Text = resultado.ToString();
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            lblResultadoresta.Text = "";
            int resultado;
            resta.Valor1 = int.Parse(txtValor1.Text);
            resta.Valor2 = int.Parse(txtValor2.Text);

            resultado = resta.resolver();

            lblResultadoresta.Text = resultado.ToString();
        }
    }
}
