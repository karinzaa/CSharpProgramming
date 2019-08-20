using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Input number index {0} :", i+1);
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Elements in array (reverse) :");
            for (int b = number.Length-1; b >= 0; b--)
            {
                    Console.Write("{0} ", number[b]);
                
            }
            
            Console.ReadKey();
        }
    }
}
