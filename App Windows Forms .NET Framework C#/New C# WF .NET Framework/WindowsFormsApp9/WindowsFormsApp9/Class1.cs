using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    internal class cubo
    {
        public int lado;
        public int area;
        public int volumen;

        public void CalcularArea()
        {
            area = lado * lado * 6; //llamo a variable del metodo de la clase
        }

        public void CalculeVolumen()
        {
            volumen = lado * lado * lado;
        }
    }
}
