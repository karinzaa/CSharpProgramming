using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number 1 : ");
            double num1 = int.Parse(Console.ReadLine());
            Console.Write("Input number 2 : ");
            double num2 = int.Parse(Console.ReadLine());
            Console.Write("Input number 3 : ");
            double num3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double sum = num1 + num2 + num3;
            Console.WriteLine($"Summary of  {num1}, {num2} and {num3} is {sum}");
            double sumAvg = (num1 + num2 + num3)/3;
            Console.WriteLine($"Average is {sumAvg:n2}");
            Console.ReadKey();
        }
    }
}
