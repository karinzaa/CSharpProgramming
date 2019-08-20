using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array07
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            Console.Write("Input a message :");
            string message = Console.ReadLine().ToLower();
            Console.WriteLine();
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'a' || message[i] == 'e' || message[i] == 'i' || message[i] == 'o' || message[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine("The number of vowels in message is {0}", total);
            Console.ReadKey();

        }
    }
}
