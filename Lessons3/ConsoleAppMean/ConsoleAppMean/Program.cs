using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMean
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x = 5, y = 8, z = 51, n = 3;

            Double sredArif = 0;

            sredArif = (x + y + z) / n;

            Console.WriteLine(sredArif);
            Console.ReadKey();


        }
    }
}
