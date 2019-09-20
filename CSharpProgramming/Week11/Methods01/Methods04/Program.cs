using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sale = InputArray();
            Console.WriteLine();
            ShowHeader();
            ShowData(sale);
            Console.ReadKey();
        }

        static int[] InputArray()
        {
            int[] sale = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Input sale employee {i+1} : ");
                sale[i] = int.Parse(Console.ReadLine());
            }
            return sale;
        }
        static void ShowHeader()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("No\t{0,9}\t{1,10}\t{2,9}", "SALE", "COMMISSION", "NET");
            Console.WriteLine("--------------------------------------------------");
        }
        static void ShowData(int[] sale)
        {

           
          for(int i = 0; i < 5; i++)
            {
                double com = sale[i] * 0.05;
                double net = com + sale[i];
                Console.WriteLine("{0}\t{1,9:N0}\t{2,10:N1}\t{3,9:N1}",i+1, sale[i], com, net);
            }
        }
    }
}
