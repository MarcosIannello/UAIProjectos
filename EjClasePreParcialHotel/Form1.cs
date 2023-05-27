using BibliotecaClasesEjHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjClasePreParcialHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hotel hotel = new Hotel();
        bool primerHuesped = true;
        List<Huesped>huespedes=new List<Huesped>();
        string fechaInicioEstadia = "";
        string fechaFinEstadia = "";
        int cantDias = 0;
        float precioFinalEstadia;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarHuesped_Click(object sender, EventArgs e)
        {
            Huesped huesped = new Huesped();
            string habitacionSeleccionada = cmbTipoHabitaciones.Text;

            huesped.Nombre = txtNombreHuesped.Text;
            huesped.Apellido = txtApellidoHuesped.Text;
            huesped.Edad = int.Parse(txtEdad.Text);
            huesped.Dni = int.Parse(txtdni.Text);
            huesped.FechaNacimiento = txtFechaNacimiento.Text;

            huespedes.Add(huesped);

            if (primerHuesped)
            {
                switch (cmbTipoHabitaciones.Text)
                {
                    case "Simple":
                        HabitacionSimple habitacionSimple = new HabitacionSimple();
                        txtDineroReserva.Text = "200";
                        break;

                    case "Doble":
                        HabitacionDoble habitacionDoble = new HabitacionDoble();
                        txtDineroReserva.Text = "350";
                        break;
                    case "Triple":
                        HabitacionTriple habitacionTriple = new HabitacionTriple();
                        txtDineroReserva.Text = "550";
                        break;

                    case "Cuadruple":
                        HabitacionCuadruple habitacionCuadruple = new HabitacionCuadruple();
                        txtDineroReserva.Text = "700";
                        break;

                }
                primerHuesped = false;
            }

            string frase = $"La cantidad de huespedes en la habitacion {habitacionSeleccionada} es de {huespedes.Count}";

            MessageBox.Show(frase);
            borrarDatosHuesped();
        }

        private void cmbMesEstadia_SelectedValueChanged(object sender, EventArgs e)
        {
            fechaInicioEstadia = $"{txtInicioEstadia.Text} de {cmbMesEstadia.Text}";
            fechaFinEstadia = $"{txtFinEstadia.Text} de {cmbMesEstadia.Text}";

            cantDias =int.Parse(txtFinEstadia.Text) - int.Parse(txtInicioEstadia.Text) ;

            MessageBox.Show($"{cantDias}");

            precioFinalEstadia = (cantDias * int.Parse(txtDineroReserva.Text));

            float reservaMin = (cantDias * int.Parse(txtDineroReserva.Text)) * 0.1f;

            txtDineroReserva.Text = reservaMin.ToString();
            
        }

        private void btnFinalizarReserva_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();

            if (chkAbonaTotal.Checked)
            {
                reserva.Abonado = true;
            }
            else
            {
                reserva.Abonado = false;
            }

            reserva.Habitacion = cmbTipoHabitaciones.Text;
            reserva.FechaInicio = fechaInicioEstadia;
            reserva.FechaFin = fechaFinEstadia;
            reserva.CantDias = cantDias;
            reserva.Deposito = float.Parse(txtDineroReserva.Text);
            reserva.PrecioFinal = precioFinalEstadia;
            reserva.Huesped = huespedes;

            hotel.Reservas.Add( reserva );

            MessageBox.Show("Reserva Concretada con exito");
            string frase = reserva.datosReserva();
            MessageBox.Show(frase);

        }

        //metodos de borrado de textbox form
        public void borrarDatosHuesped()
        {
            txtApellidoHuesped.Clear();
            txtNombreHuesped.Clear();
            txtEdad.Clear();
            txtFechaNacimiento.Clear();
            txtdni.Clear();
        }

        private void txtNombreHuesped_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombreHuesped.Clear();
        }

        private void txtApellidoHuesped_MouseClick(object sender, MouseEventArgs e)
        {
            txtApellidoHuesped.Clear();
        }

        private void txtFechaNacimiento_MouseClick(object sender, MouseEventArgs e)
        {
            txtFechaNacimiento.Clear();
        }

        private void txtEdad_MouseClick(object sender, MouseEventArgs e)
        {
            txtEdad.Clear();
        }

        private void txtdni_MouseClick(object sender, MouseEventArgs e)
        {
            txtdni.Clear();
        }

        private void txtDineroReserva_MouseClick(object sender, MouseEventArgs e)
        {
            txtDineroReserva.Clear();
        }

        private void txtFinEstadia_MouseClick(object sender, MouseEventArgs e)
        {
            txtFinEstadia.Clear();
        }

        private void txtInicioEstadia_MouseClick(object sender, MouseEventArgs e)
        {
            txtInicioEstadia.Clear();
        }
    }
}
