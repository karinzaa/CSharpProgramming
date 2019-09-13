using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a message : ");
            string mes = Console.ReadLine().ToUpper();
            Console.WriteLine();
            CountVowel(mes, 'A');
            CountVowel(mes, 'E');
            CountVowel(mes, 'I');
            CountVowel(mes, 'O');
            CountVowel(mes, 'U');

            Console.ReadKey();
        }
        static void CountVowel(string mes, char let)
        {
            int sum = 0;
            for (int i = 0; i < mes.Length; i++)
            {
                if (mes[i] == let)
                {
                    sum += 1;
                }
            }
            Console.WriteLine("The number of leter '{0}' is {1}", let, sum);
        }
    }
}
