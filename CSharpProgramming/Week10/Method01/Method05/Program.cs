using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            while (num <= 1)
            {
                Console.Write("Input a number, again : ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Power(num);
            Factorial(num);
            Console.ReadKey();
        }
        static void Power(int num)
        {
            Console.WriteLine("The answer of {0}^2 = {1}", num, Math.Pow(num, 2));
        }
        static void Factorial(int num)
        {
            int fac = 1;
            for (int i = 1; i <= num; i++)
            {
                fac *= i;
            }
            Console.WriteLine("The answer of {0}! = {1}", num, fac);
        }
    }
}
