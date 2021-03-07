using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.Write("Enter the first number: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, you entered a string or character!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Select operation: '+' '-' '*' '/'");
                Console.Write("Your choice: ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        {
                            Console.WriteLine($"The result of the addition is: {firstValue + secondValue} \n");
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine($"The result of the subtraction is: {firstValue - secondValue} \n");
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine($"The result of the multiplication is: {firstValue * secondValue} \n");
                            break;
                        }
                    case "/":
                        {
                            if (secondValue == 0)
                            {
                                Console.WriteLine($"The division result is: {secondValue} \n");
                            }
                            else
                            {
                                Console.WriteLine($"The division result is: {firstValue / secondValue} \n");
                            }
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error, unknown action!\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }
                }
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
        }
    }
}
