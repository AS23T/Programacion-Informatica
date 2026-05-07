using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmeploOO_Pesonas
{
    abstract class Persona
    {
        private string nombre;
        private int edad;

        public int Edad 
        {
            get { return edad; }
            set 
            { 
                if(value>120) edad = 120;
                  else edad = value;
            }
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public Persona(int e, string n)
        { 
            this.nombre = n;
            this.edad = e;
        }

        public virtual void jugar()
        {
            Console.WriteLine("Aun no tienes un pasatiempo\n");
        }

        public virtual void mostrarDatos()
        {
            Console.WriteLine(this.Nombre + " " + this.Edad);
        }
    }
}
