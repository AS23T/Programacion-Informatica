using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmeploOO_Pesonas
{
    class Gamer : Persona
    {
        private string nick;
        private int lvl;
        public Videojuego vg;

        public string Nick { 
            set 
            { 
                if (value == null) nick = "NN";
                else nick = value;
            }
            get { return nick; }    
        }
         public int Lvl { 
            set { lvl = value; }
            get { return lvl; }
         }

        public Gamer(int e, string n, int l, string ni):base(e,n)
        {
            this.lvl = l;
            this.Nick = ni;
            this.vg = new Videojuego("LOL", false, "MMORPG", "PC");
        }
        public override void jugar()
        {
            Console.WriteLine("Estas jugando el siguiente videojuego: \n"
                + this.vg.Nombre +"\n"
                + this.vg.Plataforma +"\n"
                + this.vg.Genero +"\n"
                );

        }

        public override void mostrarDatos()
        {
            Console.WriteLine(this.Nombre
                + " " + this.Edad
                + " " + this.Lvl
                + " " + this.Nick
                );
        }


    }
}
