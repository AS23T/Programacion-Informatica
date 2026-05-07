using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmeploOO_Pesonas
{
    class Deportista : Persona
    {
        private int altura;
        private int peso;
        public Deporte d;

        public int Altura 
        {
            get { return altura; }
            set
            {
                if (value > 240) altura = 240;
                else altura = value;
            }
        }

        public int Peso 
        {
            get { return peso; }
            set 
            {
                if (value > 140) peso = 140;
                else peso = value;
            }
        }


        public Deportista(int e, string n, int h, int w):base(e,n) 
        {
            this.altura = h;
            this.peso = w;
            this.d = new Deporte("Futbol", false, 22, "Pelota");
        }
        public override void jugar()
        {
            Console.WriteLine("Estas practicando el siguiente deporte: \n"
                + this.d.Nombre + "\n"
                + this.d.NumJugadores + " jugadores\n"
               + "Equipamiento Requerido: "+ this.d.Equipamiento + "\n"
            );

        }
        public override void mostrarDatos()
        {
            Console.WriteLine(this.Nombre 
                + " " + this.Edad
                + " " + this.altura
                + " " + this.peso
                );
        }

    }
}
