using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        public class Vehiculo //public me permite mas referencias
        {
            public string marca;
            public string modelo;
            public int año;
        }

        static void Main(string[] args)
        {
            Vehiculo miAuto = new Vehiculo();
            miAuto.año = 2025;
            miAuto.marca = "Toyota";
            miAuto.modelo = "Tucson";

            Console.WriteLine("La marca es: "+ miAuto.marca);

            Console.ReadKey();
        }
    }
}
