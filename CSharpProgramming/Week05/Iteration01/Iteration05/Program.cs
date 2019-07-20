using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration05
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            double sum = 0;
            Console.Write("How many number to input : ");
            double n = double.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write($"input number {i} : ");
                double a = double.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine($"Sum of all number frome 1 to {n} is {sum:n0} ");
            Console.ReadKey();
        }
    }
}
