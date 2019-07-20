using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input a number : ");
            int val = int.Parse(Console.ReadLine());
            Console.Write("Input a number : ");
            int x = int.Parse(Console.ReadLine());
            int i, j, k;

            switch(x)
            {
                case 1:
                    for (i = 1; i <= val; i++)
                    {
                        for (j = 1; j <= i; j++)
                        {
                            Console.Write("");
                        }
                        for (k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                    Console.ReadLine();
                    break;

                case 2:
                    for (i = 1; i <= val; i++)
                    {
                        for (j = 1; j <= val - i; j++)
                        {
                            // Console.Write(" ");  
                        }
                        for (k = 1; k <= j; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                    Console.ReadLine();

                    break;

                case 3:
                    for (i = 1; i >= val; i--)
                    {
                        for (j = 1; j >= val - i; j++)
                        {
                            Console.Write("*");
                        }
                        for (k = val; k >= val; val--)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("");
                    }
                    Console.ReadLine();
                    break;

                case 4:
                    for (i = 1; i <= val; i++)
                    {
                        for (j = 1; j <= val - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                    Console.ReadLine();
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
