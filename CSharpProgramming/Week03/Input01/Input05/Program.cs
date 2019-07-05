using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input redius : ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            double r2 = Math.PI * (r * r);
            Console.WriteLine($"Circle area = {r2:n3}");
            double r3 = (2 * Math.PI) * r;
            Console.WriteLine($"Circleference = {r3:n3}");
            double r4 = ((4.0 / 3.0) * Math.PI) * r * r * r;
            Console.WriteLine($"Volume round = {r4:n3}");
            Console.ReadKey();
        }
    }
}
