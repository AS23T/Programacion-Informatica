using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pies, pulgadas;
            double cm1, cm2, sumaCM, metros;

            Console.WriteLine("Ingrese la estatura de una persona en formato ingles (ej: 3 pies y 2 pulgadas):");

            Console.WriteLine("Ingrese los pies");
            pies = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las pulgadas");
            pulgadas = int.Parse(Console.ReadLine());

            cm1 = pies * 30.48;
            cm2 = pulgadas * 2.54;
            sumaCM = cm1 + cm2;
            metros = sumaCM / 100;

            Console.WriteLine($"La estatura en metros de una persona es: {metros:F2}");

            Console.ReadKey();
        }
    }
}
