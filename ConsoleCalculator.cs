using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (2 > 1)
            {
                double number1;
                double number2;
                int operater;

                Console.WriteLine("\nChoose operation: Multiply(1), Divide(2), Add(3), Subtract(4)");
                operater = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter first number:");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                number2 = Convert.ToDouble(Console.ReadLine());

                if (operater == 1)
                {
                    Console.Write("Result: " + (number1 * number2));
                    Console.Write("\nPress any key to reset");
                    Console.ReadKey();
                }
                if (operater == 2)
                {
                    Console.Write("Result: " + (number1 / number2));
                    Console.Write("\nPress any key to reset");
                    Console.ReadKey();
                }
                if (operater == 3)
                {
                    Console.Write("Result: " + (number1 + number2));
                    Console.Write("\nPress any key to reset");
                    Console.ReadKey();
                }
                if (operater == 4)
                {
                    Console.Write("Result: " + (number1-number2));
                    Console.Write("\nPress any key to reset");
                    Console.ReadKey();
                }
            }
        }
    }
}
