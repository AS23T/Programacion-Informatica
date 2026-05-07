using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//guia 3 ejercicio 6

namespace ConsoleApp9
{
    internal class Program
    {
        static void ParteA()
        {
            int numero;

            do
            {
                Console.WriteLine("Ingrese un numero entre 1-100: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("Error: Fuera de rango. Intente de nuevo.");
                }
            } while (numero > 100 || numero < 1);

            Console.WriteLine("Dato valido");

            Console.WriteLine();
        }

        static void ParteB()
        {
            char letra = 'X';
            int veces;
            int contador = 0;

            Console.WriteLine("Ingrese la cantidad de veces que desea repetir la letra X");
            veces = int.Parse(Console.ReadLine());

            if (veces > 0)
            {
                do
                {
                    Console.WriteLine(letra);
                    contador++;
                } while (contador < veces);
            }
            else
            {
                Console.Error.WriteLine("Debe ser mayor a 0");
            }
            

        }
        static void ParteC()
        {
            double numero;
            char validacion;
            

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = double.Parse(Console.ReadLine());

                Console.WriteLine("Desea leer otro numero s/n");
                validacion = char.Parse(Console.ReadLine());

                if (validacion == 'n' || validacion == 'N')
                {
                    break;
                }

            } while (validacion == 's' || validacion == 'S');

        }
        static void ParteD()
        {
            char parar;
            
            Console.WriteLine("Esto es un ciclo infinito de guiones, presione cualquier tecla para continuar (presione solo P para salir del ciclo)");
            Console.ReadKey();

            do
            {

                Console.Write("-");

                

                if (Console.KeyAvailable)
                {
                    parar = char.Parse(Console.ReadLine());
                    if (parar == 'P' || parar == 'p')
                    {
                        break;
                    }
                }
            } while (true);

        }

        static void Main(string[] args)
        {

            int opcion;

            Console.WriteLine("Ingrese una opcion del 1 al 4: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                ParteA();
            }
            else if (opcion == 2)
            {
                ParteB();
            }
            else if (opcion == 3)
            {
                ParteC();
            }
            else if (opcion == 4)
            {
                ParteD();
            }
            else
            {
                Console.Error.WriteLine("Valor invalido");
            }
                
        }
    }
}
