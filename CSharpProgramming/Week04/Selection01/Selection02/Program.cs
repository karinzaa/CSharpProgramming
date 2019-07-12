using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name  : ");
            string name = Console.ReadLine();
            Console.Write("Input birth year : ");
            double a = double.Parse(Console.ReadLine());
            a = 2019 - a;
            Console.Write($"Welcome, {name} ({a} year old) ");
            Console.WriteLine("Result {0}", a >= 18 ? "CAN VOTE" : "CANOT VOTE");
            Console.ReadKey();

        }
    }
}
