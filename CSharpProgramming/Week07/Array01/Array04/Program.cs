using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            double sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Input number index {0} :", i+1);
                number[i] = int.Parse(Console.ReadLine());
                sum = sum + number[i];
            }
            sum = sum / number.Length;
            Console.WriteLine();
            Console.WriteLine($"The number get more yhan or equal average ");

            foreach (int num1 in number)
            {
                if(num1 >= sum)
                {
                    Console.Write("{0} ", num1);
                }
            }
            Console.ReadKey();
        }
    }
}
