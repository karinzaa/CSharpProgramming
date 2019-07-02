using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable03
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, sum1;
            num1 = 1000;
            num2 = 2010;
            num3 = 145000;
            num4 = 125.25;
            Console.WriteLine("Number 1 = {0:n3}", num1);
            Console.WriteLine("Number 2 = {0:n3}", num2);
            Console.WriteLine("Number 3 = {0:n1}", num3);
            Console.WriteLine("Number 4 = {0:f}", num4);
            Console.ReadKey();
        }
    }
}
