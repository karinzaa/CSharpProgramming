using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,i,s,p = 0,f = 0;
            Console.Write($"How mamy studen in classroom : ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            for (i = 1; i <= n; i++)
            {
                Console.Write($"Input score student {i} : ");
                s = double.Parse(Console.ReadLine());
                while (s < 0 || s > 100)
                {
                    Console.Write($"Input score student {i}, again : ");
                    s = double.Parse(Console.ReadLine());
                }
                if(s >= 50)
                {
                    p++;
                }
                else
                {
                    f++;
                }
            }
            Console.WriteLine("--------------------------------------------");
            if (p > f)
            {
                Console.WriteLine("The number of pass students greater than fail students.");
            }
            else if(p == f)
            {
                Console.WriteLine("The number of both pass and fail students are equal.");
            }
            else
            {
                Console.WriteLine("The number of pass students less than fail students.");
            }
            Console.ReadKey();
        }
    }
}
