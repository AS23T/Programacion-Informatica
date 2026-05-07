using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCertamen2
{
    internal class Program
    {
        static void LeerArregloA(double[] A)
        {

            Console.WriteLine("Ingresa 6 numeros: ");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
            }
        }

        //Optimizar funcion metodo
        static void LlenadoArregloB(double[] B, double[] A)
        {
            int contador = 0;

            for (int i = A.Length -1; i >= 0; i--) //Aqui esta la solucion para recorrer alreves un arreglo (ESTA ES LA CLAVE)
            {
                B[contador] = A[i] / 2;
                contador++;

            }
        }

        static void ImprimirAyB(double[] A, double[] B)
        {

            Console.WriteLine("Arreglo A:");
            foreach (double recibo in A)
            {
                
                Console.Write(recibo + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Arreglo B modificado:");
            foreach (double recibo1 in B)
            {
                
                Console.Write(recibo1 + "\t");
            }
            Console.WriteLine();

            //Console.WriteLine("El arreglo A limpio: " + A);
            //Console.WriteLine("El arreglo B con las modificaciones de A: " + B);
        }
        static void Main(string[] args)
        {
            double[] A = new double[6];
            double[] B = new double[6];

            LeerArregloA(A);
            LlenadoArregloB(B, A);

            ImprimirAyB(A, B);

            Console.ReadKey();
        }
    }
}
