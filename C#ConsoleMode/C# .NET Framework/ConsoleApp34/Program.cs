using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calculadora del Domingo de Pascua ---");
            Console.Write("Ingrese el año que desea consultar: ");

            int anio = int.Parse(Console.ReadLine());

            // 1. APLICAMOS LAS FÓRMULAS DEL ENUNCIADO
            // Usamos 'int' porque todas son operaciones con enteros
            int A = anio % 19;
            int B = anio % 4;
            int C = anio % 7;

            // Ojo con los paréntesis para respetar el orden matemático
            int D = (19 * A + 24) % 30;
            int E = (2 * B + 4 * C + 6 * D + 5) % 7;

            int N = 22 + D + E;

            // 2. LÓGICA DE MESES (Marzo vs Abril)
            // N representa los días contados desde el inicio de Marzo.

            if (N <= 31)
            {
                // Si N es 31 o menos, cae en Marzo.
                Console.WriteLine($"\nEl Domingo de Pascua cae el: {N} de MARZO.");
            }
            else
            {
                // Si N es mayor a 31 (ej: 32, 33...), saltamos a Abril.
                // Restamos 31 para saber qué día de Abril es (32 - 31 = 1 de Abril).
                int diaAbril = N - 31;
                Console.WriteLine($"\nEl Domingo de Pascua cae el: {diaAbril} de ABRIL.");
            }

            Console.ReadKey();
        }
    }
}
