using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable01
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1,num2,sum1,sum2,sum3,sum4;
            num1 = 15;
            num2 = 47;
            sum1 = num1 + num2;
            sum2 = num1 - num2;
            sum3 = num1 * num2;
            sum4 = num1 / num2;
            Console.WriteLine("Summation\tof {0} and {1} is {2}", num1, num2, sum1);
            Console.WriteLine("Subtraction\tof {0} and {1} is {2}", num1, num2, sum2);
            Console.WriteLine("Multiplication\tof {0} and {1} is {2}", num1, num2, sum3);
            Console.WriteLine("Division\tof {0} and {1} is {2:f}", num1, num2, sum4);
            Console.ReadKey();
        }
    }
}
