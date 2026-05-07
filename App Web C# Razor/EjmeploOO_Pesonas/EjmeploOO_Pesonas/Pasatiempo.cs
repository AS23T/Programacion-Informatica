using System;
using System.Collections.Generic; //El uso de Generic para listas
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmeploOO_Pesonas
{
    abstract class Pasatiempo //Abstract no se puede instanciar
    {
        private string nombre;
        private bool individual;

        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; }
        }

        public bool Individual { 
            get { return individual; }
            set { individual = value; }
        }


        public Pasatiempo(string n, bool i)
        {
            this.nombre = n;
            this.individual = i;

        }
    }
}
