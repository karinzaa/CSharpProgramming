using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration01
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            double sum = 0;
            Console.Write("Input a number : ");
            double n = double.Parse(Console.ReadLine());  
            for (i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Summary of 1 to {n} is {sum:n0} ");
            Console.ReadKey();
        }
    }
}
