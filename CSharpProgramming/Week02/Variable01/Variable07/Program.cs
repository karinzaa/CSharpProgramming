using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable07
{
    class Program
    {
        static void Main(string[] args)
        {
            string productID, productNAME;
            double price,item;

            productID = "BN-158";
            productNAME = "Notebook N-Series 7";
            
            price = 17500.25;
            item = 3;
            Console.WriteLine("PRODUCT ID   = {0}", productID);
            Console.WriteLine("PRODUCT NAME = {0}",productNAME);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ITEM = \t\t  3 item.");
            Console.WriteLine("PRICE =   {0:N} bath.", price);
            price = price * item;
            Console.WriteLine("TOTAL =   {0:n} bath.", price);
            Console.WriteLine("--------------------------------");
            price = price + (price * 0.07);
            Console.WriteLine("VAT 7% =  {0:n} bath.",price);
            Console.ReadKey();
        }
    }
}
