using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, sum1, sum2;
            num1 = 252;
            num2 = 147;
            num3 = 368;
            sum1 = (num1 + num2 + num3);
            sum2 = sum1 / 3;
            Console.WriteLine("Number 1 = {0}", num1);
            Console.WriteLine("Number 2 = {0}", num2);
            Console.WriteLine("Number 3 = {0}", num3);
            Console.WriteLine("Summary of {0} , {1} and {2} is {3}", num1, num2, num3, sum1);
            Console.WriteLine("Average is {0:f}",sum2);
            Console.ReadKey();
        }
    }
}
