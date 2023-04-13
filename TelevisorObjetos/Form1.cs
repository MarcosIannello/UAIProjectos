using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelevisorObjetos
{
    public partial class frmFormCompletar : Form
    {
        public frmFormCompletar()
        {
            InitializeComponent();
        }

        //instancia de television, aka objeto
        clsTelevision TV = new clsTelevision();

        private void Form1_Load(object sender, EventArgs e)
        {
            //carga de datos del objeto
            
            
        }

        private void btnCrearTv_Click(object sender, EventArgs e)
        {
            TV.Id = int.Parse(txtIdTV.Text);
            TV.Nombre = txtTVNombre.Text;
            TV.Definicion = int.Parse(txtTVDefinicion.Text) ;

            txtIdTV.Clear();
            txtTVDefinicion.Clear();
            txtTVNombre.Clear();

            MessageBox.Show("Television creada correctamente");
        }

        private void btnMostrarCaracteristicas_Click(object sender, EventArgs e)
        {
            if (TV != null)
            {
                
                lblTVID.Text = TV.Id.ToString();
                lblTVNombre.Text = TV.Nombre;
                lblTVDefinicion.Text = TV.Definicion.ToString() + " /FULL HD";
            }
        }
    }
}
