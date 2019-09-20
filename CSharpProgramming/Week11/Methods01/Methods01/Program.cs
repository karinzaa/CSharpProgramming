using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a message : ");
            string msg = Console.ReadLine();
            Console.WriteLine($"Length message = {msg.Length}");
            Console.WriteLine($"Number of Upper-Case = {CountUpper(msg)}");
            Console.WriteLine($"Number of Lower-Case = {CountLower(msg)}");
            Console.WriteLine($"Number of Spacebar   = {CountSpacebar(msg)}");
            Console.ReadKey();
        }

        static int CountSpacebar(string msg)
        {
            int i,Length = msg.Length, CountSpacebar=0;
            for (i = 0; i < msg.Length; i++)
            {
                if (msg[i] == ' ')
                {
                    CountSpacebar++;
                }

            }
            return CountSpacebar;
        }
        static int CountUpper(string msg)
        {
            int i,CountUpper = 0;
            for (i = 0; i < msg.Length; i++)
            {
                if(char.IsUpper(msg[i]))
                {
                    CountUpper++;
                }
                
            }
            return CountUpper;
        }
        static int CountLower(string msg)
        {
            int i, CountLower = 0;
            for (i = 0; i < msg.Length; i++)
            {
                if (char.IsLower(msg[i]))
                {
                    CountLower++;
                }

            }
            return CountLower;
        }
    }
}
