using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Conversor de 24h a 12h ---");

            // 1. Entrada de datos
            Console.Write("Ingrese la HORA (0-23): ");
            int hora24 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los MINUTOS (0-59): ");
            int minutos = int.Parse(Console.ReadLine());

            // Variables para el resultado
            int hora12;
            string periodo;

            // 2. Lógica del Periodo (AM/PM)
            if (hora24 >= 12)
            {
                periodo = "PM";
            }
            else
            {
                periodo = "AM";
            }

            // 3. Lógica de la Conversión Numérica
            if (hora24 == 0)
            {
                hora12 = 12; // Caso especial: Medianoche
            }
            else if (hora24 > 12)
            {
                hora12 = hora24 - 12; // Caso normal de tarde (ej: 14 - 12 = 2)
            }
            else
            {
                hora12 = hora24; // Casos de la mañana (ej: 9 es 9) y mediodía (12 es 12)
            }

            // 4. Salida
            // Usamos "D2" en los minutos para que 5 minutos se vea como "05"
            Console.WriteLine("\nLa hora convertida es:");
            Console.WriteLine($"{hora12}:{minutos.ToString("D2")} {periodo}");

            Console.ReadKey();
        }
    }
}
