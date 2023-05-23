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
        int nroFactura = 0;
        float recaudado;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        public void CargarCombos()
        {
            cmbEstacionamiento.DataSource = null;
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

            MessageBox.Show($"Se creo el estacionamiento {estacionamiento.Nombre}");
            clearFieldsEstacionamiento();
            

            if(empresa.Estacionamientos.Count >= 1)
            {
                btnCargarEstacionamientos.Visible = true;
            }else if(empresa.Estacionamientos.Count == 4)
            {
                btnCargarEstacionamientos.Visible = false;
            }
        }

        public void clearFieldsEstacionamiento()
        {
            txtCapacidadAlta.Clear();
            txtCapacidadBaja.Clear();
            txtNombreEstacio.Clear();
        }

        private void btnCargarEstacionamientos_Click(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            nroFactura++;

            ingreso.NroFactura = nroFactura;
            ingreso.TipoVehiculo = cmbVehiculo.SelectedItem.ToString();
            ingreso.CantHoras = int.Parse(txtCantHoras.Text);
            ingreso.Patente = txtPatente.Text;

            if(ingreso.TipoVehiculo == "Auto")
            {
                Auto auto = new Auto();
                auto.PrecioXHora = 220;
                auto.CantHoras = ingreso.CantHoras;
                recaudado += auto.calcularPrecio();
                MessageBox.Show($"{recaudado}");
                empresa.TotalRecaudado += recaudado;
            }else if(ingreso.TipoVehiculo == "Moto")
            {
                Moto moto = new Moto();
                moto.PrecioXHora = 100;
                moto.CantHoras= ingreso.CantHoras;
                recaudado += moto.calcularPrecio();
                MessageBox.Show($"{recaudado}");
                empresa.TotalRecaudado += recaudado;

            }else if(ingreso.TipoVehiculo == "Camion" && checkCamionGob.Checked)
            {
                Camion__Gobierno camionGob = new Camion__Gobierno();
                camionGob.PrecioXHora = 500;
                camionGob.CantHoras = ingreso.CantHoras;
                recaudado += camionGob.calcularPrecio();
                float desc = recaudado * 0.2f;
                recaudado -= desc;
                empresa.TotalRecaudado += recaudado;
            }else if (ingreso.TipoVehiculo == "Camioneta")
            {
                Camionetas camionetas = new Camionetas();
                camionetas.PrecioXHora = 350;
                camionetas.CantHoras = ingreso.CantHoras;
                camionetas.calcularPrecio();
            }else if(ingreso.TipoVehiculo == "Camion")
            {
                Camion camion = new Camion();
                camion.PrecioXHora= 500;
                camion.CantHoras= ingreso.CantHoras;
                recaudado = camion.calcularPrecio();
                empresa.TotalRecaudado += recaudado;
            }


                empresa.Estacionamientos.ForEach(Estacionamiento =>
            {
                if (Estacionamiento.Nombre == cmbEstacionamiento.Text)
                {
                    Estacionamiento.Ingresos.Add(ingreso);
                    MessageBox.Show($"{Estacionamiento.Ingresos.Count}");
                }
            });

            
        }

        private void cmbEstacionamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
