using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[4, 4];

            LeerMatriz(matriz);

            ImprimirMatriz(matriz);

            
        }
        static void LeerMatriz(double[,] matrizO)
        {

            for (int f = 0; f < 4; f++) //4 por 4, osea 16 veces
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Ingresa la Fila: {f} La columna {c}: ");

                    matrizO[f, c] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

        }
        static void ImprimirMatriz(double[,] matrizI)
        {
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(matrizI[f, c] + "\t");

                }

                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
