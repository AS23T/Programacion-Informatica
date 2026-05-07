using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        public class Rectangulo
        {
            public int y, x;

            public Rectangulo() { x = 5; y = 7; }
            public Rectangulo(int a) { x = a; y = a; }
            public Rectangulo(int a, int b) { x = a; y = b; }

        }

        static void Main(string[] args)
        {
            Rectangulo rectangulo1 = new Rectangulo();
            Rectangulo rectangulo2 = new Rectangulo(5);
            Rectangulo rectangulo3 = new Rectangulo(7, 2);
        }
    }
}
