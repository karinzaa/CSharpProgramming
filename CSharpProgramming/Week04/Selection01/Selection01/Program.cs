using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input exam socre : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("The result is {0}", a >= 50 ? "PASS" : "FAIL");
            Console.ReadKey();


        }
    }
}
