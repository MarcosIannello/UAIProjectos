﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3ClasePersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<clsPersona> ListaPersonas = new List<clsPersona>();
        
        
        int femenino = 0;
        int masculino = 0;
        int total = 0;
        
        private void btnCargarPersona_Click(object sender, EventArgs e)
        {
            clsPersona persona = new clsPersona();

            persona.Legajo = int.Parse(txtLegajo.Text);
            persona.Nombre = txtNombrePersona.Text;
            persona.Edad = int.Parse(txtEdad.Text);
            persona.Genero = cbgenero.SelectedItem.ToString();

            ListaPersonas.Add(persona);

            MessageBox.Show($"Se creo la persona {persona.Nombre}");
            CargarGridView();
            contar(persona);

            clearAll();
        }



        public void CargarGridView()
        {
            GridPersonas.DataSource = null;
            GridPersonas.DataSource = ListaPersonas;

        }


        public void contar(clsPersona persona)
        {
            if (persona.Genero == "Femenino")
            {
                femenino++;
                total++;
            }else if (persona.Genero == "Masculino")
            {
                masculino++;
                total++;
            }

            txtMujeres.Text = femenino.ToString();
            txtHombres.Text = masculino.ToString();
            txtTotal.Text = total.ToString();
        }

        clsPersona temp;
        private void GridPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (clsPersona)GridPersonas.Rows[e.RowIndex].DataBoundItem;
            txtLegajo.Text = temp.Legajo.ToString();
            txtNombrePersona.Text = temp.Nombre;
            txtEdad.Text = temp.Edad.ToString();    
            cbgenero.Text = temp.Genero.ToString();
        }

        public void clearAll()
        {
            txtEdad.Clear();
            txtNombrePersona.Clear();
            txtLegajo.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaPersonas.Remove(temp);
        }
    }
}
