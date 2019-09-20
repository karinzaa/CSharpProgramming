using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Student ID : ");
            string Id = Console.ReadLine();
            while (!CheckId(Id))
            {
                Console.Write("Input Student ID, again : ");
                Id = Console.ReadLine();
            }
            Console.WriteLine();
            if(CheckId(Id))
            {
                Console.WriteLine($"Your Student ID = {Id}");
            }
            Console.ReadKey();
        }
        static bool CheckId(string Id)
        {
            const int maxlen = 10;
            bool CheckId = false;
            
                if (Id.Length != maxlen)
                {
                    CheckId = false;
                    return CheckId;
                }
               CheckId = int.TryParse(Id, out int ids);
              return CheckId;
        }
    }
}
