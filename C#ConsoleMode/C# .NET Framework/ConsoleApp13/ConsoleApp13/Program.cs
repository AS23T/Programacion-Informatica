using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bueno

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ae = { { 1, 2, 3 }, 
                { 4, 5, 6 } }; //Matriz prehecha, la coma separa para hacerla bidimensional

            for (int f = 0; f < 2; f++) //Fila, horizontal (izquierda a derecha)
            {
                //Console.WriteLine(ae);

                for (int c = 0; c < 3; c++) //Columna, vertical (arriba hacia abajo)
                {
                    Console.Write(ae[f, c] + " ");
                    //Console.Write("{0}", ae[f, c]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
