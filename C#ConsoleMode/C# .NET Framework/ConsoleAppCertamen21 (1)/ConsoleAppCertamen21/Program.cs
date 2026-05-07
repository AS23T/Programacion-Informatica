using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCertamen21
{
    internal class Program
    {
        static void LeermatrizAyB(int[,] matrizA, int[,] matrizB)
        {
            for (int f = 0; f < matrizA.GetLength(0); f++)
            {
                for (int c = 0; c < matrizA.GetLength(1); c++)
                {
                    Console.Write($"Ingrese el numero de matriz A: [{f}],{c}] ");
                    matrizA[f, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int f = 0; f < matrizB.GetLength(0); f++)
            {
                for (int c = 0; c < matrizB.GetLength(1); c++)
                {
                    Console.WriteLine($"Ingrese el numero de matriz B: [{f}],{c}] ");
                    matrizB[f, c] = int.Parse(Console.ReadLine());
                }
            }
            
        }
        //Mejorarlo y optimizarlo la funcion metodo
        static int[,] MultiplicacionMatricesAyB(int[,] matrizA, int[,] matrizB) //Se podria hacer con foreach tambien
        {
            int[,] resultado = new int[3,3];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int p = 0; p < matrizB.GetLength(1); p++)
                {

                    for (int l = 0; l < matrizA.GetLength(1); l++)
                    {
                        resultado[i,p] = resultado[i,p] + matrizA[i,l] * matrizB[l,p];
                    }
                }
            }
            return resultado;
        }
        static void VerificarMatrizResultante(int[,] matrizR) //me falta la tabla de ifs para ver si es excelente o no, etc tambien
        {
            int contador = 0;

            for (int f = 0; f < matrizR.GetLength(0); f++)
            {
                for (int c = 0; c < matrizR.GetLength(1); c++)
                {
                    Console.Write(matrizR[f, c] + "\t");

                    if (matrizR[f, c]>=10)
                    {
                        contador++;
                    }
                }
                if (true)
                {

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];

            LeermatrizAyB(matrizA, matrizB);
            int[,] Resultado = MultiplicacionMatricesAyB(matrizA, matrizB);

            VerificarMatrizResultante(Resultado);

            Console.ReadKey();
        }
    }
}
