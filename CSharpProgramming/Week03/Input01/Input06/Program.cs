using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input employee salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Employee salary      {salary:n2} bath.");
            double social = salary * 0.03,tax = salary * 0.04, total = salary-tax-social;
            Console.WriteLine($"Social Security         {social:n2} bath.");
            Console.WriteLine($"Tax                     {tax:n2} bath.");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Get salary            {total:n2} bath.");
            Console.ReadKey();
        }
    }
}
