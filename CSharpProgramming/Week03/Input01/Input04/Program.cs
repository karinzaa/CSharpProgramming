using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\tCalculate Your BMI");
            Console.WriteLine("---------------------------------------");
            Console.Write("Input your height (cm.) : ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Input your weight (kg.) : ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            double hm = h/100,bmi = w / (hm * hm);
            Console.WriteLine($"Find BMI = {w} / ({hm} x {hm})");
            Console.WriteLine($"         = {bmi:n2}");
            Console.ReadKey();
        }
    }
}
