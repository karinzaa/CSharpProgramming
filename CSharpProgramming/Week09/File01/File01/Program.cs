using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File01
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("D:\\Text File\\products.txt", true);
            string id;
            int s = 0,n = 0;
            int loop = 0;
            while (loop == 0)
            {
                Console.Write($"Input product Id   : ");
                id = Console.ReadLine();
                if (id == "-")
                {
                    break;
                }
                Console.Write($"Input product Unit : ");
                s = int.Parse(Console.ReadLine());
                while (s < 0)
                {
                    Console.Write($"Input product Unit , again : ");
                    s = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                n++;
                sw.WriteLine("{0},{1}", id, s);
            }
             sw.Close();
            Console.WriteLine();
            Console.Write($"Save {n} product in file alrady...");
            Console.ReadKey();

        }
    }
}
