using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many customer     : ");
            double customer = double.Parse(Console.ReadLine());
            Console.Write("How many ice bucket   : ");
            double ice = double.Parse(Console.ReadLine());
            Console.Write("How many drink bottle : ");
            double bottle = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Type\t\tUnit\t\tPrice\t\t  Total");
            Console.WriteLine("--------------------------------------------------------");
            const double cusprice = 299,iceprice = 15,drinkprice = 20;
            double sumPrice = cusprice * customer;
            Console.WriteLine($"Cust\t\t{customer}\t\t{cusprice}\t\t{sumPrice:n2} ");
            double sumPrice1 = iceprice * ice;
            Console.WriteLine($"Ice\t\t {ice}\t\t {iceprice}\t\t  {sumPrice1:n2} ");
            double sumPrice2 = drinkprice * bottle;
            Console.WriteLine($"Drink\t\t{bottle}\t\t {drinkprice}\t\t  {sumPrice2:n2} ");
            Console.WriteLine("--------------------------------------------------------");
            double utotal = sumPrice + sumPrice1 + sumPrice2;
            Console.WriteLine($"Total price\t\t\t\t\t{utotal:n2} ");
            Console.WriteLine("Add service charge\t\t\t\t      3%");
            double ser = 0.03;
            double total =utotal  + (utotal * ser);
            Console.WriteLine($"Total price\t\t\t\t\t{total:n2} ");
            Console.ReadKey();
        }
    }
}
