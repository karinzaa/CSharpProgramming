using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 299;
            Console.Write("Input number of customer: ");
            int custom = int.Parse(Console.ReadLine());
            double total = custom  * price;
            Console.WriteLine();
            Console.WriteLine("Total price {0,14:n2} B.", total);
            double vat = (total*3)/100;
            Console.WriteLine("Add water 3%{0,14:n2} B.", vat);
            double totalall = vat + total;
            Console.WriteLine("Total price {0,14:n2} B.", totalall);
            Console.ReadKey();
        }
    }
}
