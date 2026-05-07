using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crear un programa en C# que realice lo siguiente:
//Pida el valor de N
//Luego que lea sólo N números positivos
//Finalmente imprimir la suma de todos los números.


namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que suma numeros positivos");

            Console.Write("Cuantos numeros N quiere sumar: ");
            int N = int.Parse(Console.ReadLine());

            double suma = 0; //variable para almacenar el resultado suma

            int contador = 0; //contador de numeros positivos leidos

            while (contador < N)
            {
                Console.Write("Ingrese un numero positivo: ");
                double numero = double.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    suma += numero; //sumar el numero positivo a la suma
                    contador++; //incrementar el contador de numeros positivos leidos
                }
                else
                {
                    Console.WriteLine("El numero ingresado no es positivo. Intente de nuevo.");
                }
            }

            Console.WriteLine("La suma de los " + N + " numeros positivos es: " + suma);

            Console.ReadKey();
        }
    }
}
