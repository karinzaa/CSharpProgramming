using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            double num = double.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.Write($"{num} is Negative Number and ");
            }
            else
            {
                Console.Write($"{num} is Positive Number and ");
            }
            
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number.");
            }
            else
            {
                Console.WriteLine("Odd number.");
            }

            Console.ReadKey();
        }
    }
    
}
