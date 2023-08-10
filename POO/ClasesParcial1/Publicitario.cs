using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial1
{
    public class Publicitario: Empleado
    {
        public Publicitario() 
        {

        }

        public void calcularExtra()
        {
            if(this.HorasTrabajadas >= 7)
            {
                this.Plus = 7000;
            }
        }
    }
}
