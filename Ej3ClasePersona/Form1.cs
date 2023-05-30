using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            SetRegion();
        }

        List<clsPersona> ListaPersonas = new List<clsPersona>();
        
        
        int femenino = 0;
        int masculino = 0;
        int total = 0;
        bool firstPerson = true;
        int legajo = 1;
        
        private void btnCargarPersona_Click(object sender, EventArgs e)
        {
            clsPersona persona = new clsPersona();
            
                persona.Legajo = ListaPersonas.Count+1;
                persona.Nombre = txtNombrePersona.Text;
                persona.Edad = int.Parse(txtEdad.Text);
                persona.Genero = cbgenero.SelectedItem.ToString();

                ListaPersonas.Add(persona);

                MessageBox.Show($"Se creo la persona {persona.Nombre}");

                contar(persona);
                CargarGridView();

                clearAll();
                firstPerson = false;
                legajo++;
            
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
            cbgenero.SelectedIndex = -1;
        }


        private void btnEnlazar_Click(object sender, EventArgs e)
        {
            enlazar();
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaPersonas.Remove(temp);
                CargarGridView();
                borrarContador();
                borrarListas();
                enlazar();

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            clearAll();
        }

        private void borrarContador()
        {
            if (temp.Genero == "Femenino")
            {
                femenino--;
                total--;
            }
            else if (temp.Genero == "Masculino")
            {
                masculino--;
                total--;
            }

            txtMujeres.Text = femenino.ToString();
            txtHombres.Text = masculino.ToString();
            txtTotal.Text = total.ToString();
        }

        private void borrarListas()
        {
            if (lstNombres.Text == temp.Nombre && lstEdad.Text == temp.Edad.ToString())
            {
                lstNombres.Items.Remove(temp.Nombre);
                lstEdad.Items.Remove(temp.Edad.ToString());
            }
        }

        private void enlazar()
        {
            lstNombres.DataSource = null;
            lstNombres.DataSource = ListaPersonas;
            lstNombres.DisplayMember = "Nombre";

            lstEdad.DataSource = null;
            lstEdad.DataSource = ListaPersonas;
            lstEdad.DisplayMember = "Edad";

            CargarGridView();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var i = 0;

            //try
            //{
                foreach (clsPersona persona in ListaPersonas)
                {
                    if (persona.Legajo == temp.Legajo)
                    {
                        temp.Nombre = txtNombrePersona.Text;
                        temp.Edad = int.Parse(txtEdad.Text);
                        temp.Genero = cbgenero.SelectedItem.ToString();

                        ListaPersonas[i] = temp;

                        MessageBox.Show($"Usuario Modificado: {ListaPersonas[i].Nombre}, {ListaPersonas[i].Edad},{ListaPersonas[i].Genero},{ListaPersonas[i].Legajo}");

                        enlazar();
                        break;
                    }

                    i++;
                }
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show("Error al modificar el usuario contactese con administrador!");
            //}

            clearAll();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void SetRegion()
        {
            
            GraphicsPath path = new GraphicsPath();
            int radius = 15; 

            
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();

        
            this.Region = new Region(path);
        }

        private void btnExiApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
