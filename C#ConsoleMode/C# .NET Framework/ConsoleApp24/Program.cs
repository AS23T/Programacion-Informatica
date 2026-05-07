using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CONSTANTE: 
            // 5 días a la semana * 4 semanas al mes = 20 días
            const int DIAS_MES = 20;

            // VARIABLES
            int valorPasaje, viajesDiarios, gastoTotal;

            // ENTRADA
            Console.WriteLine("Calculadora de Transporte Mensual");

            Console.Write("Ingrese el valor de un pasaje: $");
            // Usamos int.Parse directo
            valorPasaje = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de viajes diarios: ");
            viajesDiarios = int.Parse(Console.ReadLine());

            // PROCESO
            // Fórmula: (Precio * Cantidad) * Días del mes
            gastoTotal = (valorPasaje * viajesDiarios) * DIAS_MES;

            // SALIDA
            Console.WriteLine("\nDías considerados al mes: " + DIAS_MES);
            // Usamos :C0 para que ponga los puntos de mil y en formato moneda (ej: $40.000)
            Console.WriteLine("Gasto Mensual Estimado: {0:C0}", gastoTotal);

            Console.ReadKey();

        }
    }
}
