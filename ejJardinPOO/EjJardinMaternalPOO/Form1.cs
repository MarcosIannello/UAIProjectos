using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjJardinMaternalPOO
{
    public partial class frmHome : Form
    {
        public frmHome(Jardin jardin)
        {
            InitializeComponent();
            this.jardin = jardin;
        }
        Jardin jardin = new Jardin();

        private void inscripcionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion=new frmInscripcion(jardin);
            inscripcion.Show();
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Sala Lactarios = new Sala("Lactarios", 12, 2);
            Sala Deambuladores = new Sala("Deambuladores", 15, 2);
            Sala Deambuladores2 = new Sala("Deambuladores2", 15, 1);
            Sala Sala2 = new Sala("Sala2", 18, 1);
            Sala Sala3 = new Sala("Sala3",20, 1);
            jardin.Salas.AddRange(new List<Sala>{Lactarios, Deambuladores, Deambuladores2, Sala2, Sala3});
        }
    }
}
