using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number in varible 'A' : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input number in varible 'B' : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"After swap two number!! ");
            Console.WriteLine("---------------------------------------");
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"Input number in varible 'A' is {a} ");
            Console.WriteLine($"Input number in varible 'B' is {b} ");

            Console.ReadKey();
        }
    }
}
