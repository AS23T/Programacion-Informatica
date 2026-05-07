using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//bueno

namespace ConsoleApp12
{
    internal class Program
    {
        static int[] Lectura(int[] L)
        {

            Console.WriteLine("Ingrese los 10 elementos");

            for (int i = 0; i < L.Length; i++) //10 es el largo
            {
                L[i] = int.Parse(Console.ReadLine());
            }
            return L;
        }

        static void Duplicado(int[] D)
        {
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = D[i] * 2;
            }

            
        }

      /*static void a(int[] a)
        {

        }*/

        static void Main(string[] args)
        {
            int[] elementos = new int[10]; //la llave de acceso

            Lectura(elementos); //forma sucia de doble referencia y guardado

            Duplicado(elementos);

            //const int N = 10;
            //decimal N1 = 10;
            //double N2 = 10;
            //float N3 = 10;

            Console.WriteLine("Estos son los numeros duplicados: ");

            foreach (int recibo in elementos)
            {
                Console.Write(recibo + " ");
            }
            Console.ReadKey();
        }
    }
}
