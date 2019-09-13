using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a message : ");
            string mes = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("MESSSAGE IN UPPER CASE = {0}", mes.ToUpper());
            Console.WriteLine("MESSSAGE IN LOWER CASE = {0}", mes.ToLower());
            Console.WriteLine("LENGTH OF MESSAGE\t= {0}", mes.Length);
            Console.WriteLine("THE FIRST LETTER\t= {0}", mes[0]);
            Console.WriteLine("THE LAST LETTER\t\t= {0}", mes[mes.Length - 1]);
            Console.ReadKey();
        }
    }
}
