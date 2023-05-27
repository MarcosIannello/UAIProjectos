using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjHotel
{
    public class Hotel
    {
        public Hotel()
        {
            habitaciones = new List<Habitacion>();
            reservas = new List<Reserva> ();
        }

        private List<Habitacion> habitaciones;

        public List<Habitacion> Habitaciones
        {
            get { return habitaciones; }
            set { habitaciones = value; }
        }

        private List<Reserva> reservas;

        public List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }

    }
}
