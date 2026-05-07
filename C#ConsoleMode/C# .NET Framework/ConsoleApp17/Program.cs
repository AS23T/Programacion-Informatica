using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hacer un programa que dado 1 arreglo con los números del 1 al 10 genere las tablas de multiplicar
//y las imprima como tabla con sus resultados.

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = i + 1;
            }

            foreach (int n in arreglo)
            {
                Console.WriteLine($"\nTabla del {n}:");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{n} * {j} = {n * j}");
                }
            }

            Console.ReadKey();
        }
    }
}
