using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable04
{
    class Program
    {
        static void Main(string[] args)
        {
            double min,h,m;
            min = 378;
            h = min / 60;
            m = min % 60;
            
            Console.WriteLine("All minutes is {0}", min);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\tTime is 0{0:n000} hour {1} minute", h, m);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}
