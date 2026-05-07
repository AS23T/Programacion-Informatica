using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hacer un programa en C# que lea 10 números, los guarde en un arreglo A, luego lea otros 10 números,
//los guarde en un arreglo B, sume los números y guarde el resultado en un arreglo C. Imprima los 3 arreglos.

namespace ConsoleApp18
{
    internal class Program
    {
        static void LeerArreglosAyB(int[] arreglo, string nombre) //referencia por parametro
        {
            Console.WriteLine($"\nIngrese los elementos del arreglo {nombre} ");

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }
        
        static void SumarArreglos(int[] A, int[] B, int[] C)
        {
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i] + B[i];
            }
        }

        static void ImprimirArregloResultado(int[] A, int[] B, int[] C)
        {
            Console.WriteLine("Indice Arreglo A + Arreglo B = Arreglo C");

            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine($"{i} \t{A[i]}\t + {B[i]}\t = {C[i]}"); //Imprimo como tabla con el tabulador con WriteLine ({i} de cuantos van, tab, {A[i]} {B[i]} de A y B, tab, {C[i]} de resultado)
            }
        }

        static void Main(string[] args)
        {
            int[] A = new int[10]; //Va para la misma funcion de leer como parametro referencia posicional A
            int[] B = new int[10]; //Va para la misma funcion de leer como parametro referencia posicional B
            int[] C = new int[10]; //Guarda impresion y la suma

            LeerArreglosAyB(A, "A"); //referencia por parametro
            LeerArreglosAyB(B, "B"); //referencia por parametro

            SumarArreglos(A, B, C);

            ImprimirArregloResultado(A, B, C);

            Console.ReadKey();

        }
    }
}
