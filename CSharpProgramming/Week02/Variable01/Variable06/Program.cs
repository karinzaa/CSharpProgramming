using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable06
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            double num,subjectPrice,total;
            num = 7;
            subjectPrice = 3000;
            id ="1913110001";
            total = subjectPrice * num;
            Console.WriteLine("STUDEN ID = {0}", id);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("ENROLLMENT   {0} Subject.({1:n0} Bath/Subject)",num, subjectPrice);
            Console.WriteLine("TOTAL PTICE  {0:n} Bath.", total);
            Console.ReadKey();
        }
    }
}
