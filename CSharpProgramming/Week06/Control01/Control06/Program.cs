using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control06
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, i = 0, sum = 0;

                Console.Write($"input a positive number : ");
                n = double.Parse(Console.ReadLine());
                while (n <= 0)
                {
                    Console.Write($"Please,input a positive number only again : ");
                    n = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("");
            for (i = 1; i <= n; i++)
            {
                sum += i;
                Console.Write($"{i}");
               
                    if ( i < n)
                    {

                      Console.Write($" + ");
                    }
                   
                }
            Console.WriteLine($" = {sum}");
            Console.ReadKey();
        }

            
        }
    }

