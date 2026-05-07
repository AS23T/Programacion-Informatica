using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Clasificador de Etapa de Vida ---");

            Console.Write("Ingrese la edad de la persona: ");
            int edad = int.Parse(Console.ReadLine());

            string etapa; // Variable para guardar el resultado

            // VALIDACIÓN: Nadie tiene edad negativa
            if (edad < 0)
            {
                etapa = "Edad no válida (Error)";
            }
            // 1. ¿Es Niño? (0 a 12)
            else if (edad <= 12)
            {
                etapa = "Niño";
            }
            // 2. ¿Es Adolescente? (13 a 17)
            // No hace falta poner (edad >= 13 && edad <= 17)
            // Porque si llegamos aquí, YA SABEMOS que es mayor a 12.
            else if (edad <= 17)
            {
                etapa = "Adolescente";
            }
            // 3. ¿Es Adulto Joven? (18 a 59)
            else if (edad <= 59)
            {
                etapa = "Adulto Joven";
            }
            // 4. Si no es ninguno de los anteriores, es Tercera Edad
            else
            {
                etapa = "Tercera edad";
            }

            // SALIDA
            Console.WriteLine("La persona es considerada: " + etapa);

            Console.ReadKey();
        }
    }
}
