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
            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());

            if ((number >= 0) && (number <= 14))
                    {
                Console.WriteLine("Число относится к промежутку [0, 14]");
                    }
            else if ((number >= 15) && (number <= 35))
                    {
                Console.WriteLine("Число относится к промежутку [15, 35]");
                    }
             else if ((number >= 36) && (number <= 50)) 
                    {
                Console.WriteLine("Число относится к промежутку [36, 50]");
                    }
             else if ((number >= 50) && (number <= 100)) 
                    {
                Console.WriteLine("Число относится к промежутку [50, 100]");
                    }
             if ((number < 0) || (number > 101))
               {
                Console.WriteLine("Число не относится к промежуткам ");
               }

            Console.ReadKey();
        }
    }
}
