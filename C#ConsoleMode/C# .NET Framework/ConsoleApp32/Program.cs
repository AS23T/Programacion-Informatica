using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Desglose de Monedas (Algoritmo Voraz) ---");

            Console.Write("Ingrese el monto (Múltiplo de 10 y menor a 5000): $");
            int monto = int.Parse(Console.ReadLine());

            // 1. VALIDACIÓN
            // Verificamos las dos reglas: Menor a 5000 Y que sea múltiplo de 10
            if (monto >= 5000 || monto % 10 != 0)
            {
                Console.WriteLine("Error: El monto debe ser menor a 5000 y terminar en 0.");
            }
            else
            {
                // 2. LÓGICA VORAZ (De mayor a menor)

                // A. Monedas de 500
                int monedas500 = monto / 500;  // ¿Cuántas de 500 caben?
                int resto = monto % 500;       // ¿Cuánto sobra?

                // B. Monedas de 100 (Trabajamos con lo que sobró)
                int monedas100 = resto / 100;
                resto = resto % 100;           // Actualizamos el resto

                // C. Monedas de 50 (Trabajamos con el nuevo resto)
                int monedas50 = resto / 50;
                resto = resto % 50;

                // D. Monedas de 10
                int monedas10 = resto / 10;
                // Ya no calculamos resto porque 10 es la moneda más chica posible

                // 3. SALIDA
                Console.WriteLine("\nPara formar $" + monto + " necesitas:");
                if (monedas500 > 0) Console.WriteLine($"- {monedas500} monedas de $500");
                if (monedas100 > 0) Console.WriteLine($"- {monedas100} monedas de $100");
                if (monedas50 > 0) Console.WriteLine($"- {monedas50} monedas de $50");
                if (monedas10 > 0) Console.WriteLine($"- {monedas10} monedas de $10");

                // Sumamos el total de monedas usadas
                int totalMonedas = monedas500 + monedas100 + monedas50 + monedas10;
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Total de monedas: {totalMonedas}");
            }

            Console.ReadKey();
        }
    }
}
