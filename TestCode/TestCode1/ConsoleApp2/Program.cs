using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input employee salary : ");
            int salary= int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("SALARY {0,10:n2} ", salary);
            double social = (salary * 3) / 100;
            Console.WriteLine("SOCIAL {0,10:n2} ", social);
            double tax = (salary * 4) / 100;
            Console.WriteLine("TAX {0,13:n2}", tax);
            double salarySum = salary - social - tax;
            Console.WriteLine("EMPLOYEE SALARY = {0:n2}", salarySum);
            Console.ReadKey();
        }
    }
}
