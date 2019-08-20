using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a message :");
            string message = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Show in upper case = ");
            foreach (Char _mes in message)
            {
                if (_mes >= 97 && _mes <= 122)
                {
                    Console.Write((char)(_mes-32));
                  
                }
                else

                    Console.Write(_mes);

            }
            Console.ReadKey();
        }
    }
}
