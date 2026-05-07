using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos signos peso quieres mostrar pa: ");
            int signos = int.Parse(Console.ReadLine());

            int contador = 0;

            while (contador < signos)
            {
                Console.Write("$");
                contador++;
            }

            Console.WriteLine("\nContinuamos?");
            Console.ReadKey();

            //hacer alguna validacion o romper ciclo para salir de el ciclo infinito
            Console.WriteLine("Imprimiendo puntos infinitos (Ctrl + c para detener)");
            while (true)
            {
                Console.Write(".");

                System.Threading.Thread.Sleep(200);
            }

            Console.WriteLine("\nContinuamos?");
            Console.ReadKey();

            Console.WriteLine("Hasta que numero quiere contar?");

            int X = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= X)
            {
                Console.WriteLine(i + " ");
                i++;

            }

            Console.WriteLine("\nContinuamos?");
            Console.ReadKey();

            int contador1 = 0;
            double suma = 0;

            while (contador < 10)
            {
                Console.WriteLine("Ingrese el numero " + (contador1 + 1) + ": ");
                double numero = double.Parse(Console.ReadLine());
                suma += numero;
                contador1++;
            }

            double promedio = suma / 10;
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("La suma total es: " + suma);
        }
    }
}
