using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la hora (0-23): ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Ingrese minutos (0-59): ");
            int m = int.Parse(Console.ReadLine());

            // Creamos una fecha "ficticia" (hoy) con esa hora y minutos
            DateTime tiempo = new DateTime(2023, 1, 1, h, m, 0);

            // "hh" minúscula es formato 12 horas
            // "tt" es el AM/PM automático
            Console.WriteLine("Hora: " + tiempo.ToString("hh:mm tt"));
        }
    }
}
