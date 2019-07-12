using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input time (minute) : ");
            int time = int.Parse(Console.ReadLine());
            double hour = time / 60, minute = time % 60;
            if (hour == 3 && minute == 0)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Time = {hour:0} hour {minute} minute");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Park Free!!");
            }
            else if (hour >= 3 && minute >= 15)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Time = {hour:0} hour {minute} minute");
                Console.WriteLine($"New  = {++hour:0} hour 0 minute");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Amount to be paid {(hour - 3) * 40:n2} baht.");
            }
            else if (hour > 3 || hour == 3)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Time = {hour:0} hour {minute} minute");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Amount to be paid {((hour - 3) * 40) + ((minute / 2)):n2} baht.");

            }
            else if (minute >= 15)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Time = {hour:0} hour {minute} minute");
                Console.WriteLine($"New = {++hour:0} hour 0 minute");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Park Free!!");
            }
            else if (hour <= 3 || minute >= 60)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Time = {hour:0} hour {minute} minute");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Park Free!!");
            }
            Console.ReadKey();
        }

    }
}