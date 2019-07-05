using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input student id        : ");
            string id = Console.ReadLine();
            Console.Write("Input student name      : ");
            string name = Console.ReadLine();
            Console.Write("Input mid-term score    : ");
            double mid = int.Parse(Console.ReadLine());
            Console.Write("Input final score       : ");
            double final = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"STUDENT  :{name} ({id})");
            double sum = mid + final;
            Console.WriteLine($"GET SCORE  :{sum} ({mid} + {final})");

            Console.ReadKey();
        }
    }
}
