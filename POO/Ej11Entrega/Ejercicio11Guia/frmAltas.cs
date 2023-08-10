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

namespace Ejercicio11Guia
{
    public partial class frmAltas : Form
    {
        public frmAltas(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        public Hospital hospital;

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        private void frmAltas_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMedico.Checked){
                gpPersonalMedico.Visible= true;
            }
            else
            {
                gpPersonalMedico.Visible = false;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (chkMedico.Checked)
            {
                Especialidad oEspecialidad = new Especialidad(cmbEspecialidad.Text);
                Medico medico = new Medico(oEspecialidad,txtNombre.Text, int.Parse(txtId.Text), int.Parse(txtTarifa.Text), int.Parse(cmbNumTurnos.Text));
                hospital.Medicos.Add(medico);
                MessageBox.Show($"Se ha Cargado correctamente el medico {medico.Nombre}");
            }
            else
            {
                Paciente Paciente = new Paciente(txtNombre.Text, int.Parse(txtId.Text),txtCoberturaMedica.Text);
                hospital.Pacientes.Add(Paciente);
                MessageBox.Show($"Se ha Cargado correctamente el paciente {Paciente.Nombre}");
            }
            ClearForm();
        }

        private void btnVerListPacientes_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = hospital.Pacientes;
        }

        private void btnVerListMedicos_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = hospital.Medicos;
        }

        public void ClearForm()
        {
            txtCoberturaMedica.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            txtTarifa.Text = "";
            cmbEspecialidad.SelectedIndex = -1;
            cmbNumTurnos.SelectedIndex = -1;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            hospital.Medicos.Sort();
            dataGrid.DataSource = null;
            dataGrid.DataSource = hospital.Medicos;
        }

        Medico temp;
        Paciente temp2;
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (Medico)dataGrid.Rows[e.RowIndex].DataBoundItem;
            //temp2 = (Paciente)dataGrid.Rows[e.RowIndex].DataBoundItem;

            txtTurnosDisponibles.Visible = true;
            lblTurnos.Visible= true;
            txtTurnosDisponibles.Text = temp.calcularTurnos(temp.CantTurnosMAx, temp.Turnos.Count).ToString();
        }
    }
}
