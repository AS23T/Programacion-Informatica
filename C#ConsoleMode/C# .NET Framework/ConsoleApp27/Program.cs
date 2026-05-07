using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para analizar: ");
            int numero = int.Parse(Console.ReadLine());

            // CONDICIÓN DOBLE:
            // 1. (numero % 5 == 0)  -> ¿Es divisible por 5?
            // 2. &&                 -> Y ADEMÁS
            // 3. (numero % 10 != 0) -> ¿NO es divisible por 10? (!= significa distinto)

            if (numero % 5 == 0 && numero % 10 != 0)
            {
                Console.WriteLine($"¡Correcto! El número {numero} cumple la condición, es divisible por 5.");
            }
            else
            {
                Console.WriteLine($"El número {numero} NO cumple, no es divisible por 5.");

                if (numero % 10 == 0)
                    Console.WriteLine("(Falló porque es divisible por 10).");
                else if (numero % 5 != 0)
                    Console.WriteLine("(Falló porque ni siquiera es divisible por 5).");
            }

            Console.ReadKey();
        }
    }
}
