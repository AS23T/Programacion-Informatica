using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static double ObtenerTotalVentas()
        {
            double sumVentas = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Ingrese el monto de la venta " + i + ": $");
                double venta = double.Parse(Console.ReadLine());

                sumVentas += venta;

            }
            return sumVentas;
        }

        static void CalculoMuestroSueldo(double TotalVendido)
        {
            
            double comision = TotalVendido * Configuracion_Sueldos.COMISION;

            
            double sueldoBruto = Configuracion_Sueldos.SUELDO_BASE + comision;

            
            double descuento = sueldoBruto * Configuracion_Sueldos.IMPUESTO;

            
            double sueldoNeto = sueldoBruto - descuento;

            Console.WriteLine("\n LIQUIDACION DE SUELDO");
            Console.WriteLine("Sueldo Base:      {0:C0}", Configuracion_Sueldos.SUELDO_BASE);
            Console.WriteLine("Comisión (12%): + {0:C0}", comision);
            Console.WriteLine(" ");
            Console.WriteLine("SUELDO BRUTO:     {0:C0}", sueldoBruto);
            Console.WriteLine("Descuento (10%):- {0:C0}", descuento);
            Console.WriteLine(" ");
            Console.WriteLine("SUELDO NETO:      {0:C0}", sueldoNeto);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a mi programa para determinar tu sueldo neto!");
            
            double TotalVendido = ObtenerTotalVentas();

            CalculoMuestroSueldo(TotalVendido);

            Console.ReadKey();

            /*
            double venta = double.Parse(Console.ReadLine());

            double ganancia = venta * Configuracion_Sueldos.COMISION;

            Console.WriteLine("Tu comisión es: " + ganancia);
            */
        }
    }
}
