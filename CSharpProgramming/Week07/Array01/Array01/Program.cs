using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] number = new int[7];
            for (int i = 0; i < number.Length; i++)
            { 
                Console.Write("Input number index {0} :",i);
                number [i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write($"Elements in array are :");

            foreach (int num1 in number)
            {
                Console.Write("{0} ", num1);
            }
            Console.ReadKey();
        }
    }
}
