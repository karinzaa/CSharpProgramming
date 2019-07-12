using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input hour   : ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Input minute : ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Input second : ");
            double s = double.Parse(Console.ReadLine());
            Console.Write($"Time is ");
            if (h < 10)
            {
                Console.Write($"0{h}:");
                Console.Write($"{m}:");
                Console.Write($"{s}");
            }
            if (m < 10)
            {
                Console.Write($"{h}:");
                Console.Write($"0{m}:");
                Console.Write($"{s}");
            }
            if (s < 10)
            {
                Console.Write($"0{h}:");
                Console.Write($"0{m}:");
                Console.Write($"{s}");
            }
            else
            {
                Console.Write($"{h}:");
                Console.Write($"{m}:");
                Console.Write($"{s}");
            }

            Console.ReadKey();

        }
    }
}
