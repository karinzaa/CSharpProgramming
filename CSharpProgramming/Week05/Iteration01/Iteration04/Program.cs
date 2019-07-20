using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration04
{
    class Program
    {
        static void Main(string[] args)
        {
            double i,sum;
            Console.Write("Input a number : ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (i = 1; i <= 12; i++)
            {
                sum = n * i;
                Console.WriteLine($"{n} x {i} = {sum}");
            }
            Console.ReadKey();
        }
    }
}
