using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\t\tTNI Delivery");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Press 1 : Takoyaki\t\t180\tBaht.");
            Console.WriteLine("Press 2 : Udon\t\t\t100\tBaht.");
            Console.WriteLine("Press 3 : Taiyaki\t\t250\tBaht.");
            Console.WriteLine("Press 4 : Calculate");
            Console.WriteLine("-------------------------------------------------");
            
            int num, sum = 0;
            do
            {
                Console.Write("Input the number of menu : ");
                num = int.Parse(Console.ReadLine());
           
                if (num == 1)
                {
                    sum += 180;
                }
                else if (num == 2)
                {
                    sum += 100;
                }
                else if (num == 3)
                {
                    sum += 250;
                }
                


            }
            while (num != 4);

            Console.WriteLine();
            Console.WriteLine("Total price is {0:n0} Baht.", sum);
            Console.WriteLine("Current time is {0}", DateTime.Now.ToString("hh:mm"));

            Console.WriteLine("Order will be dilivered at {0}", DateTime.Now.AddMinutes(30).ToString("hh:mm"));
            Console.ReadKey();
        }
    }
}
