using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCertamen1
{
    internal class Program
    {
        static double FuncionPromedioPonderado(double nota1, double nota2)
        {
            double notaPromedio = (nota1 * 0.4) + (nota2 * 0.6);
            return notaPromedio;

        }

        static void FuncionResultados(double notaPromedio) // Mejorar optimizacion con syntax a favor y logica
        {
            if (notaPromedio >= 1.0 && notaPromedio <= 3.9)
            {
                Console.WriteLine("su promedio es:" + notaPromedio);
                Console.WriteLine("Insuficiente");
            }
            if (notaPromedio >= 4.0 && notaPromedio <= 5.0)
            {
                Console.WriteLine("su promedio es:" + notaPromedio);
                Console.WriteLine("Suficiente");
            }
            if (notaPromedio >= 5.1 && notaPromedio <= 6.0)
            {
                Console.WriteLine("su promedio es:" + notaPromedio);
                Console.WriteLine("Bueno");
            }
            if (notaPromedio >= 6.0 && notaPromedio <= 7.0)
            {
                Console.WriteLine("su promedio es:" + notaPromedio);
                Console.WriteLine("Muy bueno");
            }
            

        }

        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double notaPromedio;

            Console.WriteLine("Ingrese la nota 1 del estudiante: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2 del estudiante: ");
            nota2 = double.Parse(Console.ReadLine());

            if (nota1 > 7 || nota1 < 1 || nota2 > 7 || nota2 < 1)
            {
                Console.WriteLine("No esta en el rango de 1 a 7");
                Console.ReadKey();
                return;
            }

            notaPromedio = FuncionPromedioPonderado(nota1, nota2);
            FuncionResultados(notaPromedio);
            Console.ReadKey();
        }
    }
}
