using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_6_23
{
    public class Jugador
    {
        public delegate void delFestejar (string mensaje);
        public delegate void delInsultar (string mensaje, int volumen);

        public event delFestejar Festejar;
        public event delInsultar Insultar;

        Random rnd = new Random();
        public void Patear ()
        {
            int res = rnd.Next(0, 3);  
            switch (res)
            {
                case 0:
                    {
                        if (Festejar != null)
                        {
                            this.Festejar("Golazo");
                        }
                        break;

                    }
                case 1:
                    {
                        if (Insultar != null)
                        {
                            this.Insultar("Buurrrooo", 101);
                        }
                    }
                    break;

            }
        }
    }
}
