using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static double CalculoTemperaturaCelsius(double TFahrenheit)
        {
            double tempCelsius;
            
            tempCelsius = (TFahrenheit - 32) * 5 / 9;

            return tempCelsius;
        }
        static double CalculoMilimetroAgua(double PAgua)
        {
            double milimAgua;

            milimAgua = PAgua * 25.4;

            return milimAgua;
        }

        static void Main(string[] args)
        {
            double tempFahrenheit, tCelsius, pulgAgua, mmAgua;

            Console.WriteLine("Ingrese la temperatura en grados Fahrenheit");
            tempFahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de agua precipitada en pulgadas");
            pulgAgua = double.Parse(Console.ReadLine());

            if (pulgAgua < 0)
            {
                return;
            }

            tCelsius = CalculoTemperaturaCelsius(tempFahrenheit);
            mmAgua = CalculoMilimetroAgua(pulgAgua);

            Console.WriteLine($"La temperatura en grados celsius es: {tCelsius:F2}");
            Console.WriteLine($"La cantidad de agua en milimetros es: {mmAgua:F2}");

            Console.ReadKey();
        }
    }
}
