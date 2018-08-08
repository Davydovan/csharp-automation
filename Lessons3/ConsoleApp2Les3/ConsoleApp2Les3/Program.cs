using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Les3
{
    class Program
    {
        //выполнение операций с переменными 
        //x + = y - x++ *z
        //z = --x -y *5
        //y/ = x + 4 % z
        //z = x++ +y *5
        // x = y - x++ *z
        static void Main(string[] args)
        {
           int x = 10, y = 12,z = 3;

            Console.WriteLine("1-е уравнение = {0}", x += y - x++ * z);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("2-е уравнение = {0}", z = --x - y * 5);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("3-е уравнение = {0}", y /= x + 4 % z);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("4-е уравнение = {0}", z = x++ + y * 5);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("5-е уравнение = {0}", x = y - x++ * z);

            Console.ReadKey();

              }
    }
}
