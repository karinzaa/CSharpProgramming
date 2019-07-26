using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control08
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i, m,fi, p = 0, f = 0 ,sum = 0;
            Console.Write($"How mamy studen in classroom : ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            for (i = 1; i <= n; i++)
            {
                Console.Write($"Input mid-term score : ");
                m = double.Parse(Console.ReadLine());
                while (m < 0 || m > 40)
                {
                    Console.Write($"Input mid-term score , again : ");
                    m = double.Parse(Console.ReadLine());
                }
                
                Console.Write($"Input final score : ");
                fi = double.Parse(Console.ReadLine());
                while (fi < 0 || fi > 60)
                {
                    Console.Write($"Input final score , again : ");
                    fi = double.Parse(Console.ReadLine());
                }

                sum = m + fi;
                 Console.Write($"STUDEN #{i} is ");
                if (sum >= 50)
                {
                    Console.WriteLine($"PASS with {sum} score ");
                    p++;
                    Console.WriteLine($"");
                }
                else
                {
                   Console.WriteLine($"FAIL with {sum} score ");
                   Console.WriteLine($"");
                    f++;
                }
            }
            Console.WriteLine("--------------------------------------------");

            if (p > f)
            {
                Console.WriteLine($"Number of PASS students is {p} of {f} students.");
            }
            else
            {
                Console.WriteLine($"Number of FAIL students is {f} of {p} students.");
            }
            Console.ReadKey();
        }
    }
}
