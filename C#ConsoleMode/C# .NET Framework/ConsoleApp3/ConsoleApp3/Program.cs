using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//tiene algunos errores

namespace ConsoleApp3
{
    internal class Program
    {
        static bool VerificarMayor(int a, int b)
        {
            if (a > b)
            {
                return true; //Console.WriteLine("El primer numero es mayor\n");
            }
            else
            {
                return false;//Console.WriteLine("El segundo numero es mayor");
            }
            
        }

        static bool VerificarIgualdad(int a, int b)
        {
            if (a == b)
            {
                return true; //Console.WriteLine("El primer y el segundo numero son iguales");
            }
            else
            {
                return false; //Console.WriteLine("El primer y el segundo numero no son iguales");
            }
            
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Ingresar dos numeros distintos:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());


            if (a < b)
            {
                if (a < b)
                {
                    Console.WriteLine("El primer numero es menor\n");

                }
                else
                {
                    Console.WriteLine("El segundo numero es menor");
                }
            }


            if (a > b)
            {
                if (VerificarMayor(a, b))
                {
                    Console.WriteLine("El primer numero es mayor\n");
                }
                else
                {
                    Console.WriteLine("El segundo numero es mayor");
                }
            
            
            
            }

            if (a == b)
            {
                if (VerificarIgualdad(a, b))
                {
                    Console.WriteLine("El primer y el segundo numero son iguales");
                }
                else
                {
                    Console.WriteLine("El primer y el segundo numero no son iguales");
                }
            }

            

            //VerificarMayor(a, b);

            //VerificarIgualdad(a, b);

            Console.ReadKey(); //espera respuesta de tecla
            /*Console.ReadLine(); //para cerrar el programa */

        }
    }
}
