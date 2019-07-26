using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control09
{
    class Program
    {
        static void Main(string[] args)
        {
            double unit, price = 0, sum = 0 , ofsum = 0;
            char runto = 'y';
            while (runto == 'y' || runto == 'Y')
            {
                Console.Write($"Input price per unit : ");
                price = double.Parse(Console.ReadLine());
               
                Console.Write($"Input number of unit : ");
                unit = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                sum = price * unit;
                Console.WriteLine($"Total price is {sum:n} bath");

                ofsum += sum;
                Console.WriteLine("--------------------------------------------");
                Console.Write($"Do you have orther product? : ");
                runto = char.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------");
            }


            Console.WriteLine("");
            Console.WriteLine($"Total price of all product is {ofsum:n} bath. ");
            Console.ReadKey();
        }
    }
}
