using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace EjconsoleAPPBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            per.Nombre = "marcos";
            per.Edad = 22;
            per.Legajo = 1;

            Console.WriteLine($"Welcome {per.Nombre} your age is {per.Edad} and your number is {per.Legajo}");
        }
    }
}
