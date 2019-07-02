using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable08
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Pen", name2 = "Pencil", name3 = "Book";
            double price1 = 13.5, price2 = 210.3, price3 = 1090;
            int stock1 = 200, stock2 = 500, stock3 = 45;
            Console.WriteLine("Name\t\tStock\t\tPrice");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("{0}\t\t{1}               {2:n}", name1, price1, stock1);
            Console.WriteLine("{0}\t\t{1}              {2:n}", name2, price2, stock2);
            Console.WriteLine("{0}\t\t{1}                {2:n}", name3, price3, stock3);
            Console.WriteLine("----------------------------------------");
            double totalPrice, totalStock;
            totalPrice = price1 + price2 + price3;
            totalStock = stock1 + stock2 + stock3;
            Console.WriteLine("Total {0}                        {1:n}", totalStock, totalPrice);
            Console.ReadKey();
        }
    }
}
