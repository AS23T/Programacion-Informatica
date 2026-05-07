using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCertamen12
{
    internal class Program
    {
        static void CalculoWhile()
        {
            int numeroRepeticiones;
            int i = 0;
            Console.WriteLine("Cuantos numeros de tres en tres quiere mostrar?");
            numeroRepeticiones = int.Parse(Console.ReadLine());

            int sucesion = 0;

            while ( i < numeroRepeticiones )
            {
                sucesion = sucesion + 3;
                i++;
                Console.WriteLine($"Aqui esta: {sucesion}");
            }
        }
        static void CalculoFor()
        {
            Console.WriteLine("Cuantos numeros quieres ver?");
            int limite = int.Parse(Console.ReadLine());

            int sucesion = 0;

            for (int i = 0; i < limite; i++)
            {
                sucesion = sucesion + 3;
                Console.WriteLine($"Valor: {sucesion}");
            }
        }
        static void Main(string[] args)
        {
            

            CalculoWhile();

            CalculoFor();

            Console.ReadKey();
        }
    }
}
