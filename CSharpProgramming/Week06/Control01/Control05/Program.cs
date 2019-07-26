using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control05
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i, s = 0, max = 0, min = 0;
            Console.Write($"How mamy number to input: ");
            n = double.Parse(Console.ReadLine());
            max = Int64.MinValue;
            min = Int64.MaxValue;
            Console.WriteLine("--------------------------------------------");
            for (i = 1; i <= n; i++)
            {
                Console.Write($"Input number {i} : ");
                s = double.Parse(Console.ReadLine());
                if (s > max)
                {
                    max = s;
                }
                if (s < min) 
                {
                    min = s;
                }

            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"The maximum number is {max} ");
            Console.WriteLine($"The minimum number is {min} ");
            Console.ReadKey();

        }
    }
}
