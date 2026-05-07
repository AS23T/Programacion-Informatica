using System;
// See https://aka.ms/new-console-template for more information

//Necesita arreglarse

public class Program
{

    static double CalculoAprobados(int NtotalAlumnos, int NtotalReprobados)
    {
        int NtotalAprobados;
        int PorcAprobados;

        NtotalAprobados = NtotalAlumnos - NtotalReprobados;
        PorcAprobados = (NtotalAprobados * 100) / NtotalAlumnos;

        return PorcAprobados;
    }
    static void Main()
    {
        
        int NtotalAlumnos;
        int NTotalAprobados;
        int NTotalReprobados;
        double PorcAprobados;
        double PorcReprobados;

        Console.WriteLine("Ingrese numero total de alumnos");
        NtotalAlumnos = int.Parse(Console.ReadLine());

        if (NtotalAlumnos <= 0)
        {
            return;
        }

        Console.WriteLine("Ingrese numero total de reprobados");
        NTotalReprobados = int.Parse(Console.ReadLine());



        NTotalAprobados = NtotalAlumnos - NTotalReprobados;
        
        PorcAprobados = (NTotalAprobados * 100) / NtotalAlumnos;
        PorcReprobados = (NTotalReprobados * 100) / NtotalAlumnos;

        Console.WriteLine("El % de alumnos aprobados es  " + PorcAprobados + "%");
        Console.WriteLine("El % de alumnos reprobados es " + PorcReprobados + "%");

        
    }
}