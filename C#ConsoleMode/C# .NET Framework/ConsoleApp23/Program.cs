using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Diseñe un programa en C# que exprese la capacidad de un disco duro en megabytes, kilobytes y bytes,
//conociendo la capacidad del disco en Gigabytes.

namespace ConsoleApp23
{
    internal class Program
    {
        static void imprimirCapacidad(double gigas) //le pasamos la variable del Main GB_Disco
        {

            double terabytes = gigas / Factores.FactorA;

            double megabytes = gigas * Factores.FactorA;

            double kilobytes = megabytes * Factores.FactorA;

            double bytes = kilobytes * Factores.FactorA;

            Console.WriteLine($"Analizando todo {gigas} GB");

            Console.WriteLine($"Terabytes: {terabytes.ToString("N4")} TB");
            Console.WriteLine($"Megabytes: {megabytes.ToString("N0")} MB");
            Console.WriteLine($"Kilobytes: {kilobytes.ToString("N0")} KB");
            Console.WriteLine($"Bytes: {bytes.ToString("N0")} B");



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de GB: ");
            double GB_Disco = double.Parse( Console.ReadLine());

            imprimirCapacidad(GB_Disco);

        }
    }
}
