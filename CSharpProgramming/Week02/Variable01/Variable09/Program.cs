using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable09
{
    class Program
    {
        static void Main(string[] args)
        {
            int customer = 7,bucket = 5, bottle = 8;
            float buffet = 299, ice = 15, drink = 25;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Type\t\tUnit\t\tPrice\t\tTotal");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Custommer{customer,11}{buffet,14}{buffet * customer,20:n2}");
            Console.WriteLine($"Ice      {bucket,11}{ice,14}{bucket * ice,20:n2}");
            Console.WriteLine($"Drink    {bottle,11}{drink,14}{bottle * drink,20:n2}");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Total price (No service charge)    {(bottle * drink) + (bucket * ice) + (bottle * drink),20:n2}");
            Console.ReadKey();
        }
    }
}
