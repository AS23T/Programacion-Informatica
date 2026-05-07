using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mate = new int[3, 3]; //matriz sin rellenar //la coma dentro del arreglo es para hacerlo matriz bidimensional

            for (int f = 0; f < 3; f++)
            {
                
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("valor: ");
                    mate[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int f = 0; f < 3; f++)
            {

                for (int c = 0; c < 3; c++)
                {
                    Console.Write(mate[f,c]+" ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Algunos elementos de la matriz:");
            Console.WriteLine("[0, 0]:{0} [1,2]:{1} [2,0]:{2}", mate[0,0], mate[1,2], mate[2,0]); //muestro por posicion
            Console.ReadKey();
        }
    }
}
