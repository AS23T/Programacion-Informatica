using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Diseñar un programa en C# que lea una cantidad de segundos en indique a cuantas horas, minutos y
//segundos equivale:
//a.Ejemplo 400 segundos equivalen a 0 horas, 6 minutos y 40 segundos.
//b. Otro ejemplo: 9000 segundos equivalen a 2 horas, 30 minutos y 0 segundos.

namespace ConsoleApp21
{
    internal class Program
    {
        static int LeerSegundos()
        {
            
            Console.WriteLine("Ingrese la cantidad de segundos a convertir: ");
            int segundos = int.Parse(Console.ReadLine());
            return segundos;

        }

        static void ConvertirSegundos(int segundos)
        {

            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int segs = (segundos % 3600) % 60;

            Console.WriteLine("{0} segundos equivalen a {1} horas, {2} minutos y {3} segundos", segundos, horas, minutos, segs);

        }

        static void Main(string[] args)
        {

            int segundos = 0;

            segundos = LeerSegundos();

            ConvertirSegundos(segundos);

            Console.ReadKey();

            /*
            int segundos;

            Console.WriteLine("Ingrese la cantidad de segundos a convertir: ");
            segundos = int.Parse(Console.ReadLine());

            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int segs = (segundos % 3600) % 60;
            
            Console.WriteLine("{0} segundos equivalen a {1} horas, {2} minutos y {3} segundos", segundos, horas, minutos, segs);
            Console.ReadKey();
            */
        }
    }
}
