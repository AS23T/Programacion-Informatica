using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            //char letraIncluyente = 'ñ';

            Console.Write("Ingrese una letra: ");
            letra = char.Parse(Console.ReadLine());


            if (letra >= 'a' && letra <= 'z' || letra == 'ñ')
            {
                Console.WriteLine("Es minuscula");
            }
            else
            {
                Console.WriteLine("No es una minuscula");
            }

            if (letra >= 'A' && letra <= 'Z' || letra == 'Ñ')
            {
                Console.WriteLine("Es MAYUSCULA");
            }
            else
            {
                Console.WriteLine("No es una MAYUSCULA");
            }

            //if (letraIncluyente >= 'ñ' && letraIncluyente <= 'ñ')

            Console.ReadKey();
        }
    }
}
