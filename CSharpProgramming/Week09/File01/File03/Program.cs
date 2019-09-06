using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File03
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("D:\\Text File\\book.txt", true);
            int n = 0;
            for(int i = 0; i <=10 ;i++)
            {
                Console.Write($"Input Book ISBN     : ");
                string isbn = Console.ReadLine();
                if (isbn == "0")
                {
                    break;
                }
                Console.Write($"Input Book Title    : ");
                string  title = Console.ReadLine();
                Console.Write($"Input Book Price    : ");
                double price = double.Parse(Console.ReadLine());
                Console.Write($"Input Public Year   : ");
                int publicYear = int.Parse(Console.ReadLine());
                Console.WriteLine($"---------------------------------------------");
                sw.WriteLine("{0}*{1}*{2}*{3}", isbn, title, price, publicYear);
                n++;
               
            }
            sw.Close();
            Console.WriteLine();
            Console.Write($"you have {n} book, in file 'book.txt' already...");
            Console.ReadKey();

        }
    }
}
