using BibliotecaClasesPolideportivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjGuia6Polideportivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Polideportivo polideportivo = new Polideportivo();
        int contadorCanchas;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaCancha_Click(object sender, EventArgs e)
        {
            contadorCanchas++;
            switch (cbTipoNuevaCancha.Text)
            {
                case "Tenis":
                    CanchaTenis canchaTenis = new CanchaTenis();
                    canchaTenis.Nombre = cbTipoNuevaCancha.Text;
                    canchaTenis.NumCancha = contadorCanchas;
                    canchaTenis.ValorXHora = 200;
                    polideportivo.CanchasTenis.Add(canchaTenis);
                    polideportivo.TotalCanchas.Add(canchaTenis.Nombre);
                    break;

                case "Futbol5":
                    CanchaF5 Futbol5 = new CanchaF5();
                    Futbol5.Nombre = cbTipoNuevaCancha.Text;
                    Futbol5.NumCancha += contadorCanchas;
                    Futbol5.ValorXHora = 500;
                    polideportivo.CanchasF5.Add(Futbol5);
                    polideportivo.TotalCanchas.Add(Futbol5.Nombre);
                    break;

                case "Futbol7":
                    CanchaF7 Futbol7 = new CanchaF7();
                    Futbol7.Nombre = cbTipoNuevaCancha.Text;
                    Futbol7.NumCancha = contadorCanchas;
                    Futbol7.ValorXHora = 650;
                    polideportivo.canchasF7.Add(Futbol7);
                    polideportivo.TotalCanchas.Add(Futbol7.Nombre);
                    break;

                case "Futbol11":
                    CanchaF11 Futbol11 = new CanchaF11();
                    Futbol11.Nombre = cbTipoNuevaCancha.Text;
                    Futbol11.NumCancha = contadorCanchas;
                    Futbol11.ValorXHora = 800;
                    polideportivo.CanchasF11.Add(Futbol11);
                    polideportivo.TotalCanchas.Add(Futbol11.Nombre);
                    break;
            }
            cargarGridView();
        }
            public void cargarGridView()
            {
                gvCanchas.DataSource = null;
                gvCanchas.DataSource = polideportivo.TotalCanchas;
                
            }
    }
}
