using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c;
            a = "\nмоя строка 1";
            b = "\tмоя строка 2";
            c = "\aмоя строка 3";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Write(c);

           

            Console.ReadKey(); 
        }
    }
}
