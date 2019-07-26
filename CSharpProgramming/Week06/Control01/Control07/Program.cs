using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control07
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("How many odd number to display from 1 :  ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
            }


            Console.ReadKey();
        }
    }
}
