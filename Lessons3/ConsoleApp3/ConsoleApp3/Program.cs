using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаю константу с именем pi, типа double и присваиваем ей значение 3.141
           
            const double pi = 3.141;

            double r = 34; // радиус
            double y = 2;  // степень
            Double S = 0;  // переменная площади 

            S = pi * Math.Pow(r, y);  // Площадь круга

            Console.Write(S);
            Console.ReadKey();


        }
    }
}
