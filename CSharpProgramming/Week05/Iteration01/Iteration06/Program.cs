using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration06
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int odd = 0;
            int even = 0;

            Console.Write("Input a number : ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("");
  
            for (int x = 1; x <= n; x++)
            {
                sum += x;
                if (x % 2 == 0)
                    even += x;
                else
                    odd += x;
            }
            Console.WriteLine($"Sum of all even number between 1 to {n} is {even:n0}");
            Console.WriteLine($"Sum of all odd  number between 1 to {n} is {odd:n0}");

            Console.ReadKey();
        }
    }
}
