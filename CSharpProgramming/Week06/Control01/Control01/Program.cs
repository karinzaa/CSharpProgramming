using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control01
{
    class Program
    {
        static void Main(string[] args)
        {

            double i, sum;
            Console.Write("Input a number in rang 2 - 12 : ");
            double n = double.Parse(Console.ReadLine());
            while(n < 2 || n > 12)
            {
                Console.Write("The number out of rang ! Input the number again : ");
                n = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            for (i = 1; i <= 12; i++)
            {
                sum = n * i;
                Console.WriteLine($"{n} x {i} = {sum}");
            }
            Console.ReadKey();
        }
    }
}
