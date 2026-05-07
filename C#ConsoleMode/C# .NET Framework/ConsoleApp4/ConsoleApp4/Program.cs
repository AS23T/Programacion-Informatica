using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {

        static void ValidarMes(int mes)
        {
            if (mes == 1)
            {
                Console.WriteLine("Enero tiene 31 dias");
            }
            if (mes == 2)
            {
                Console.WriteLine("Febrero tiene 28 dias");
            }
            if (mes == 3)
            {
                Console.WriteLine("Marzo tiene 31 dias");
            }
            if (mes == 4)
            {
                Console.WriteLine("Abril tiene 30 dias");
            }
            if (mes == 5)
            {
                Console.WriteLine("Mayo tiene 31 dias");
            }
            if (mes == 6)
            {
                Console.WriteLine("Junio tiene 30 dias");
            }
            if (mes == 7)
            {
                Console.WriteLine("Julio tiene 31 dias");
            }
            if (mes == 8)
            {
                Console.WriteLine("Agosto tiene 31 dias");
            }
            if (mes == 9)
            {
                Console.WriteLine("Septiembre tiene 30 dias");
            }
            if (mes == 10)
            {
                Console.WriteLine("Octubre tiene 31 dias");
            }
            if (mes == 11)
            {
                Console.WriteLine("Noviembre tiene 30 dias");
            }
            if (mes == 12)
            {
                Console.WriteLine("Diciembre tiene 31 dias");
            }
            

        }

        static void Main(string[] args)
        {
            int dia;

            Console.Write("Ingrese un numero de dia del 1 al 7: ");
            dia = int.Parse(Console.ReadLine());

            if (dia > 7 || dia < 1)
            {
                Console.WriteLine("Error, superaste el maximo o el minimo");
                Console.ReadKey();
                return;
            }

            if (dia == 1)
            {
                Console.WriteLine("Lunes");
            }

            if (dia == 2)
            {
                Console.WriteLine("Martes");
            }

            if (dia == 3)
            {
                Console.WriteLine("Miercoles");
            }

            if (dia == 4)
            {
                Console.WriteLine("Jueves");
            }

            if (dia == 5)
            {
                Console.WriteLine("Viernes");
            }

            if (dia == 6)
            {
                Console.WriteLine("Sabado");
            }

            if (dia == 7)
            {
                Console.WriteLine("Domingo");
            }

            Console.Write("Ingrese un numero de mes del 1 al 12: ");
            int mes = int.Parse(Console.ReadLine());
            ValidarMes(mes);

            Console.ReadKey();

        }
    }
}
