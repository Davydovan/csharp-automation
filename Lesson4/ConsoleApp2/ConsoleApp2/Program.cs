using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть знак арафметичної операції: +, -, *, / :");
            
            // Приймаємо введення від користувача.
            string sing = Console.ReadLine();
            double operand1 = 25, operand2 = 2;
            
            switch (sing)
            {
                case "+":
                Console.WriteLine(operand1 + operand2);
                break;
                
                case "-":
                  Console.WriteLine(operand1-operand2);
                break;

               case "*":
                    Console.WriteLine(operand1 * operand2);
                break;

                case "/":
                        if (operand2 != 0)
                        {
                        Console.WriteLine(operand1 / operand2);
                    }
                        else
                        {
                            Console.WriteLine("На нуль ділити не можна");
                        }
                    
                break;

                default:
                    Console.WriteLine("Невірний вибір. Введіть знак арафметичної операції: +, -, *, / .");
                break;

            }
            Console.ReadKey();
            }
    }
}
