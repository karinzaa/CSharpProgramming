using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input num 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input num 2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input operator : ");
            string ope = Console.ReadLine();
            Console.WriteLine();
            if (ope == "+")
            {
                sum(num1, num2);
            }
            else if (ope == "-")
            {
                sub(num1, num2);
            }
            else if (ope == "x" || ope == "X")
            {
                multi(num1, num2);
            }
            else if (ope == "/")
            {
                divi(num1, num2);
            }
            else
            {
                Console.WriteLine("Input wrong operator...");
            }

            Console.ReadKey();
        }
        static void sum(int num1, int num2)
        {
            Console.WriteLine("The result of Summation is {0}", num1 + num2);
        }
        static void sub(int num1, int num2)
        {
            Console.WriteLine("The result of Subtraction is {0}", num1 - num2);
        }
        static void multi(int num1, int num2)
        {
            Console.WriteLine("The result of Multiplication is {0}", num1 * num2);
        }
        static void divi(int num1, int num2)
        {
            double num3 = num1, num4 = num2;
            Console.WriteLine("The result of Division is {0:n}", num3 / num4);
        }
    }
}
