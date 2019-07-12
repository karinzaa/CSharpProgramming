using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input year : ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || (y % 100 == 0) || (y % 4 == 0))
            {
                Console.Write($"{y} is not Leap year ");
            }
            else
            {
                Console.Write($"{y} is Leap year");
            }
            Console.ReadKey();
        }
    }
    
}
