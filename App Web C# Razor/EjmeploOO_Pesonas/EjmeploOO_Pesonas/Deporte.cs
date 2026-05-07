using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmeploOO_Pesonas
{
    class Deporte : Pasatiempo
    {
        private int numJugadores;
        private string equipamiento;

        public int NumJugadores 
        {
            get { return numJugadores; }
            set { numJugadores = value; }
        }

        public string Equipamiento
        {
            get { return equipamiento; }
            set { equipamiento = value; }
        }

        public Deporte(string n, bool i, int nj, string eq):base(n,i)
        {
            this.numJugadores = nj;
            this.equipamiento = eq;
        }
    }
}
