using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a message :");
            string message = Console.ReadLine();
            Console.WriteLine();

            int Word = 0;

            foreach(Char _mess in message)
            {
                if(_mess == ' ')
                {

                    Word = Word + 1;
                }
               
            }
            Console.WriteLine("The message have {0} words", Word + 1);
            Console.ReadKey();
        }
    }
}
