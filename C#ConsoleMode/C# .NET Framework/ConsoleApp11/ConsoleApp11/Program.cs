using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bueno

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edad = new int[7];
            

            Console.WriteLine("Ingrese 7 edades:");

            for (int i = 0; i < edad.Length; i++)
            {
                Console.WriteLine($"Ingresa la edad de la persona {i++}");
                edad[i] = int.Parse(Console.ReadLine());
            }

            int contador = ContarMenores(edad);

            Console.WriteLine("cantidad de menores de edad: " + contador);

            Console.ReadKey();
        }

        static int ContarMenores(int[] edades)
        {
            int cuenta = 0;

            for (int i = 0; i < edades.Length; i++) //verifica si es mayor de edad
            {
                if (edades[i] < 18)
                {
                    cuenta++;
                }
            }
            return cuenta;
        }
    }
}
