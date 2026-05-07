using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un número de 3 dígitos (ej. 307): ");
            int numero = int.Parse(Console.ReadLine());

            // Dividimos entre 100. C# ignora los decimales.
            // 307 / 100 = 3
            int centenas = numero / 100;

            // Primero sacamos el resto de 100 (lo que sobra de las centenas) -> 307 % 100 = 7
            // Luego dividimos entre 10 para quitar la unidad -> 7 / 10 = 0
            // (Otro ejemplo: si fuera 345 -> 345%100 = 45 -> 45/10 = 4)
            int decenas = (numero % 100) / 10;

            // Es simplemente el resto de dividir por 10.
            // 307 % 10 = 7
            int unidades = numero % 10;

            int resultado = centenas + decenas + unidades;
            
            Console.WriteLine("\nCentenas: " + centenas);
            Console.WriteLine("Decenas:  " + decenas);
            Console.WriteLine("Unidades: " + unidades);
            
            Console.WriteLine("\nLa suma de " + centenas + "+" + decenas + "+" + unidades + " es: " + resultado);

            Console.ReadKey();

        }
    }
}
