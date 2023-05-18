using BibliotecaClasesEjclase6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticoClase6EJParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Empresa empresa = new Empresa();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        public void CargarCombos()
        {
            cmbEstacionamiento.Items.Clear();

            cmbEstacionamiento.DataSource = empresa.Estacionamientos;
            cmbEstacionamiento.DisplayMember = "Nombre";
        }

        private void btnAltaEstaciona_Click(object sender, EventArgs e)
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            estacionamiento.Nombre = txtNombreEstacio.Text;
            estacionamiento.CapacidadPlantaAlta = int.Parse(txtCapacidadAlta.Text);
            estacionamiento.CapacidadPlantaBaja = int.Parse(txtCapacidadBaja.Text);
            estacionamiento.DisponibilidadBaja = 0;
            estacionamiento.DisponibilidadAlta= 0;

            empresa.Estacionamientos.Add(estacionamiento);
        }
    }
}
