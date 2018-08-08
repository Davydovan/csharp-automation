using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLess4Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");

            string word = Console.ReadLine();

            switch(word)
            {
                case "танцевать":
                    Console.WriteLine("dance");
                    break;

                case "собирать":
                    Console.WriteLine("collect");
                    break;

                case "любить":
                    Console.WriteLine("love");
                    break;

                case "рисовать":
                    Console.WriteLine("draw");
                    break;

                case "спать":
                    Console.WriteLine("sleep");
                    break;

                case "мыть":
                    Console.WriteLine("wash");
                    break;

                case "находить":
                    Console.WriteLine("find");
                    break;

                case "улыбаться":
                    Console.WriteLine("smile");
                    break;

                case "учиться":
                    Console.WriteLine("learn");
                    break;

                case "обучать":
                    Console.WriteLine("teach");
                    break;

                default:
                    Console.WriteLine("Вы ввели слово у которого нет перевода в нашем словаре.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
