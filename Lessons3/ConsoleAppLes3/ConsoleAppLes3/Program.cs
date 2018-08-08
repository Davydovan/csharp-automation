using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLes3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 235;
            int b = 1356;

            Console.WriteLine(a+b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);


            var result = (double)a / b;
            Console.WriteLine("{0}", result);
            

            Console.ReadKey();
        }
    }
}
