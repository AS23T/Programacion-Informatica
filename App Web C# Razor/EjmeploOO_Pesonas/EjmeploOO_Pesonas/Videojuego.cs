using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmeploOO_Pesonas
{
    class Videojuego : Pasatiempo
    {
        private string genero;
        private string plataforma;

        public string Genero 
        { 
            get { return genero; }
            set { genero = value; }
        }

        public string Plataforma
        { 
            get { return plataforma; }
            set { plataforma = value; }
        }

        public Videojuego(string n, bool i, string g, string p):base(n,i)
        {
            this.genero = g;
            this.plataforma = p;
        }    
    }
}
