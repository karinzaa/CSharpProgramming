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
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Input minute : ");
            int minute = int.Parse(Console.ReadLine());
            Console.Write("Input second : ");
            int second = int.Parse(Console.ReadLine());
            Console.Write($"Time is ");
            if (hour < 10 && minute >= 10 && second < 10)
            {
                Console.WriteLine($"Time is 0{hour}:{minute}:0{second}");
            }
            else if (hour >= 10 && minute < 10 && second < 10)
            {
                Console.WriteLine($"Time is {hour}:0{minute}:0{second}");
            }
            else if (hour < 10 && minute < 10 && second >= 10)
            {
                Console.WriteLine($"Time is 0{hour}:0{minute}:{second}");
            }
            else
            {
                if (hour >= 10 && minute >= 10 && second >= 10)
                {
                    Console.WriteLine($"Time is {hour}:{minute}:{second}");
                }
                else
                {
                    Console.WriteLine($"Time is 0{hour}:0{minute}:0{second}");
                }
            }

            Console.ReadKey();

        }
    }
}
