using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Detector de Números Capicúa ---");
            Console.Write("Ingrese un número de 4 dígitos: ");
            int numero = int.Parse(Console.ReadLine());

            // 1. VALIDACIÓN: Aseguramos que sea de 4 dígitos
            // El rango válido es del 1000 al 9999
            if (numero >= 1000 && numero <= 9999)
            {
                // 2. DESCOMPOSICIÓN MATEMÁTICA

                // Unidad de Mil (El primero): 1221 / 1000 = 1
                int mil = numero / 1000;

                // Centena (El segundo): (1221 / 100) % 10 = 2
                int centena = (numero / 100) % 10;

                // Decena (El tercero): (1221 / 10) % 10 = 2
                int decena = (numero / 10) % 10;

                // Unidad (El último): 1221 % 10 = 1
                int unidad = numero % 10;

                // 3. COMPARACIÓN ESPEJO
                // ¿Es el primero igual al último?  Y  ¿Es el segundo igual al tercero?
                if (mil == unidad && centena == decena)
                {
                    Console.WriteLine($"¡SÍ! El número {numero} es CAPICÚA.");
                }
                else
                {
                    Console.WriteLine($"NO. El número {numero} no es capicúa.");
                }
            }
            else
            {
                Console.WriteLine("Error: Por favor ingrese un número estrictamente de 4 dígitos.");
            }

            Console.ReadKey();
        }
    }
}
