using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration03
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Input a number : ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Input choice 0 or 1 : ");
                int c  = int.Parse(Console.ReadLine());
            char b = (char)c;
            if (c == 18)
            {
                Console.Write($"1 ");
            }

            for (int i = c += 2; i <= n; i+=2)
                {
              
                    Console.Write($"{i} ");
                }

            Console.ReadLine();
        }

    }
}
