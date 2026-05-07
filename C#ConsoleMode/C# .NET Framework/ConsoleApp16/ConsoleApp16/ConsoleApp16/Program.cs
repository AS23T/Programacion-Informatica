using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bueno

namespace ConsoleApp16
{
    internal class Program
    {
        static void MatrizBidimensional(double[,] matriz)
        {
            for (int f = 0; f < matriz.GetLength(0); f++) //(0, 1, 2) = 3
            {

                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine($"Ingrese cualquier numero decimal [{f},{c}]: ");
                    matriz[f, c] = double.Parse(Console.ReadLine());

                }

            }
            
        }

        static void Main(string[] args)
        {
            double[,] matriz = new double[3, 3];

            MatrizBidimensional(matriz); //void
            ImprimirResultadosSumaEnDosVectoresArreglosCadaUno(matriz); //void

            double[] filas = CalcularSumaDeTotalFilas(matriz);
            double[] columnas = CalcularSumaTotalColumnas(matriz);

            Console.WriteLine("Suma filas:");
            foreach (double f in filas)
            {
                Console.Write(f + " ");
            }

            Console.WriteLine("Suma de columnas:");
            foreach (double c in columnas)
            {
                Console.Write(c + " ");
            }

        }

        //metodo funcion
        static double[] CalcularSumaTotalColumnas(double[,] matriz)
        {
            double[] sumaColumnas = new double[matriz.GetLength(1)];

            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                double suma = 0;
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    suma = suma + matriz[f, c];
                }
                sumaColumnas[c] = suma;
            }

            return sumaColumnas;


        }
        static double[] CalcularSumaDeTotalFilas(double[,] matriz)
        {
            double[] sumarFilas = new double[matriz.GetLength(0)];

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                double suma = 0;
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    suma = suma + matriz[f, c];
                }
                sumarFilas[f] = suma;
            }

            
            return sumarFilas;
            
        }
        
        static void ImprimirResultadosSumaEnDosVectoresArreglosCadaUno(double[,] matriz)
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {

                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                    

                }
                Console.WriteLine();

            }
        }

    }
}
