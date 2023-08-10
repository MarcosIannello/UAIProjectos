using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisorObjetos
{
    public class clsTelevision
    {
        //propiedad creada con propfull + doble tab

        private int id;

        //public getters y setters son los que se usan desde el formulario para usar las propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int definicion;
                
        public int Definicion
        {
            get { return definicion; }
            set { definicion = value; }
        }

    }
}
