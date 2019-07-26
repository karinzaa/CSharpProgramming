using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control03
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0 , i, sum = 0;
            for (i = 1; i <= 5; i++)
            {
                Console.Write($"The number {i} : ");
                n = double.Parse(Console.ReadLine());
                while (n <= 0)
                {
                    sum += n;
                    Console.Write($"The number {i} again : ");
                    n = double.Parse(Console.ReadLine());
                }
                sum += n;
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Sum of 5 numbers is {sum:n0} ");
            sum = sum / 5;
            Console.WriteLine($"Average is {sum:n} ");
            Console.ReadKey();
        }
    }
}
