using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure06
{
    class Program
    {
        struct stu
        {
            public string id;
            public double score;
        }

        static void Main(string[] args)
        {
            stu[] stu = new stu[5];
            for (int i = 0; i < stu.Length; i++)
            {
                Console.Write("Input Student Id : ");
                stu[i].id = Console.ReadLine();
                Console.Write("Input Student Score : ");
                stu[i].score = double.Parse(Console.ReadLine());
                while (stu[i].score < 0 || stu[i].score > 100)
                {
                    Console.Write("Input Student Score,again : ");
                    stu[i].score = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("-----------------------------------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("List of PASS studen  ");
            foreach (stu _stu in stu)
            {
                if(_stu.score >= 50)
                {
                    Console.WriteLine($">> {_stu.id}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("List of FAIL studen  ");
            foreach (stu _stu in stu)
            {
                if (_stu.score <= 50)
                {
                    Console.WriteLine($">> {_stu.id}");
                }
            }
            Console.ReadKey();
        }
    }
}
