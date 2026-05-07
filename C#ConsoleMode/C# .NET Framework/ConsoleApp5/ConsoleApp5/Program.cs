using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            while (p!=20)
            {
                p = p + 2;
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
