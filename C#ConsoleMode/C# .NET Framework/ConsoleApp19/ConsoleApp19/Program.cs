using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        public class cubo
        {
            public int lado;
            public int area;
            public int volumen;

            public void CalcularArea()
            {
                area = lado * lado * 6;
            }

            public void CalculeVolumen()
            {
                volumen = lado * lado * lado;
            }
        }
        static void Main(string[] args)
        {
            cubo cuboPrimeroGesimo = new cubo(); //Es una forma de llamar a la clase con una instancia

            cuboPrimeroGesimo.lado = int.Parse(Console.ReadLine());

            cuboPrimeroGesimo.CalcularArea();
            
            cuboPrimeroGesimo.CalculeVolumen();

            Console.WriteLine("El area es: " + cuboPrimeroGesimo.area);
        }
    }
}
