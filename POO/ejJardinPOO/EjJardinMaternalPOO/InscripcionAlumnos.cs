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
    public partial class frmInscripcion : Form
    {
        Jardin jardin = new Jardin();
        List<Sala> salas = new List<Sala>();
        public frmInscripcion(Jardin Jardin)
        {
            InitializeComponent();
            this.jardin = Jardin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(jardin);
            home.Show();
            this.Hide();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cboSalas.Items.Clear();
            jardin.Salas.ForEach(salas => cboSalas.Items.Add(salas));
            salas = jardin.Salas;
            cboSalas.DisplayMember = "Nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var salaCombo = cboSalas.SelectedItem;
                Alumno alumno = new Alumno(txtNombre.Text, int.Parse(txtEdad.Text));
            
                foreach(Sala sala in salas)
                {
                    if(sala == salaCombo)
                    {
                        sala.validarCupoAlumnos();
                    
                        if(sala.PoseeCupos)
                        {
                            sala.Alumnos.Add(alumno);
                            jardin.ALUMNOSJARDIN.Add(alumno);
                            MessageBox.Show("Se ha cargado el alumno");
                        }
                        else
                        {
                            MessageBox.Show("La sala no posee cupos");
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            
            
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            jardin.Salas.Sort();
            //datgrid.DataSource = null;
            //datgrid.DataSource = jardin.ALUMNOSJARDIN;
            datgrid.DataSource = null;
            datgrid.DataSource = jardin.Salas;
        }
    }
}
