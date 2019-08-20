using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] number = new int[5];
            for (i = 0; i < number.Length; i++)
            {
                Console.Write("Input number index {0} : ", i+1);
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();


            Console.Write($"List of even number = ");
            foreach (int num1 in number)
            {
                if(num1 % 2 == 0)
                {
                  
                    Console.Write(" {0}", num1);
                }

            }
            Console.WriteLine($"");
            Console.Write($"List of odd number  = ");
            foreach (int num1 in number)
            {
                if (num1 % 2 != 0)
                {
                    
                    Console.Write(" {0}", num1);
                }

            }
            Console.ReadKey();
        }
    }
}
