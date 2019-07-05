using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Product id     : ");
            string id = Console.ReadLine();
            Console.Write("Input Product name   : ");
            string name = Console.ReadLine();
            Console.Write("Input Product stock  : ");
            double stock = double.Parse(Console.ReadLine());
            Console.Write("Input Product   : ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"{id} {name}");
            double sum = price * stock;
            Console.WriteLine($"{stock} x {price:n} = {sum:n} bath.");
            Console.WriteLine("---------------------------------------");
            Console.Write("Input Discout   (%)   : ");
            double dis = double.Parse(Console.ReadLine());
            double sumDis =(sum * dis)/100 ;
            double sumtotal = sum - sumDis;
            Console.WriteLine("---------------------------------------");
            Console.Write($"Total price =  {sumtotal:n} bath");
            Console.ReadKey();
        }
    }
}
