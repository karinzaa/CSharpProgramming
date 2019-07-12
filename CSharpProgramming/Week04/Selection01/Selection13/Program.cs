using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input salary per month : ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Salary per month\t{salary,22:n2} baht.");
            double yearsalary = salary * 12;
            Console.WriteLine($"Salary per year\t{yearsalary,30:n2} baht.");
            Console.WriteLine("----------------------------------------------------");
            if (yearsalary >= 0 && yearsalary <= 150000)
            {
                Console.WriteLine(">> Salary in range 0 to 150,000 baht. ");
                Console.WriteLine();
                Console.WriteLine(">> Tax to paid is 0 baht");
            }
            else if (yearsalary > 150000 && yearsalary <= 300000)
            {
                Console.WriteLine(">> Salary in range 150,001 to 300,000 baht. ");
                Console.WriteLine();
                Console.WriteLine($">> Tax to paid is {(yearsalary - 150000) * 0.05:n2} baht. ");
            }
            else if (yearsalary > 300000 && yearsalary <= 500000)
            {
                Console.WriteLine(">> Salary in range 300,001 to 500,000 baht. ");
                Console.WriteLine();
                Console.WriteLine($">> Tax to paid is {((yearsalary - 300000) * 0.1) + 7500:n2} baht. ");
            }
            else if (yearsalary > 500000 && yearsalary <= 750000)
            {
                Console.WriteLine(">> Salary in range 500,001 to 750,000 baht. ");
                Console.WriteLine();
                Console.WriteLine($">> Tax to paid is {((yearsalary - 500000) * 0.15) + 27500:n2} baht. ");
            }
            else if (yearsalary > 750000 && yearsalary <= 1000000)
            {
                Console.WriteLine(">> Salary in range 750,001 to 1,000,000 baht. ");
                Console.WriteLine();
                Console.WriteLine($">> Tax to paid is {((yearsalary - 750000) * 0.2) + 65000:n2} baht. ");
            }
            else if (yearsalary > 1000000 && yearsalary <= 2000000)
            {
                Console.WriteLine(">> Salary in range 1,000,001 to 2,000,000 baht. ");
                Console.WriteLine();
                Console.WriteLine($">> Tax to paid is {((yearsalary - 1000000) * 0.25) + 115000:n2} baht. ");
            }
            else if (yearsalary > 2000000 && yearsalary <= 4000000)
            {
                Console.WriteLine(">> Salary in range 2,000,001 to 4,000,000 baht. ");
                Console.WriteLine();
                Console.WriteLine($">> Tax to paid is {((yearsalary - 2000000) * 0.3) + 365000:n2} baht. ");
            }
            else
            {
                Console.WriteLine(">> Salary in range 4,000,001+ baht. ");
                Console.WriteLine();
                Console.WriteLine($">> Tax to paid is {((yearsalary - 4000000) * 0.35) + 965000:n2} baht. ");
            }
            Console.ReadKey();
        }
    }
}