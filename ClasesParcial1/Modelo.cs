using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial1
{
    public class Modelo: Empleado
    {
        public Modelo()
        {
            this.Plus = 10000;
        }

        private float extra;

        public float Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        

        public void calcularExtra()
        {
            if(this.HorasTrabajadas >= 10)
            {
                this.Extra = 25000;
                this.SueldoTotal += this.Extra;
            }
        }
    }
}
