using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control02
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, sum;
            Console.Write("Input a number in rang 2 - 12 : ");
            double n = double.Parse(Console.ReadLine());
            while (n < 1)
            {
                Console.Write("Error!! TInput the number, again : ");
                n = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            if(n % 2 == 0)
            {
                for (i = 1; i <= n; i++)
                {
                    sum = n * i;
                    Console.WriteLine($"{n} x {i} = {sum}");
                }
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    sum = n * i;
                    Console.WriteLine($"I Love C#");
                }
            }
            
            Console.ReadKey();
        }
    }
}
