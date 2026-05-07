using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buscando el número Mayor");

            // 1. Pedimos los 3 números
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            // 2. LOGICA: Comparamos parejas

            // CASO A: ¿Es el primero el mayor de todos?
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El mayor es el PRIMERO: " + num1);
            }
            // CASO B: Si no fue el primero... ¿Es el segundo mayor que el primero Y que el tercero?
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El mayor es el SEGUNDO: " + num2);
            }
            // CASO C: Si no fue ni el 1 ni el 2, por descarte es el 3
            else
            {
                Console.WriteLine("El mayor es el TERCERO: " + num3);
            }

            Console.ReadKey();
        }
    }
}
