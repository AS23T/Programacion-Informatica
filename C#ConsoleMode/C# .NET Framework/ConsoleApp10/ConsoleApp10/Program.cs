using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] enteros = new int[4];
            enteros[0] = 100;
            enteros[1] = 200;
            // nada asignado a enteros [2];
            enteros[3] = 300;
            // impresio de cada elemento vector
            foreach (int i in enteros)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
