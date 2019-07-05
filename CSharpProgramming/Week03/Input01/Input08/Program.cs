using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input time parking (minute) : ");
            int time = int.Parse(Console.ReadLine());
            int h, m;
            h = time / 60;
            m = time % 60;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"\tTime : 0{h:n000} hour {m} minute");
            Console.WriteLine("---------------------------------------");
            double priceh = h * 30, pricem = m * 0.5,pricetotal;
            pricetotal = priceh + pricem;
            Console.WriteLine($"Total price = {pricetotal:n} bath.");
            Console.ReadKey();
        }
    }
}
