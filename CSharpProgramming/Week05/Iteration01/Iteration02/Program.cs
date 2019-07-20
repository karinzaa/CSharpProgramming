using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration02
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            Console.Write("Input a number : ");
            double n = double.Parse(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
