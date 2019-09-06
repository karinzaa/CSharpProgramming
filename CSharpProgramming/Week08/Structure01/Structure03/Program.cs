using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure03
{
    class Program
    {
        struct stu
        {
            public string id, name;
            public char gen;
            public double score;
        }

        static void Main(string[] args)
        {
            stu stu = new stu();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("INPUT STUDENT INFORMTION TO STRUTURE");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Input Student Id : ");
            stu.id = Console.ReadLine();
            Console.Write("Input Student Name : ");
            stu.name = Console.ReadLine();
            Console.Write("Input Student Gender : ");
            stu.gen = char.Parse(Console.ReadLine());
            while (stu.gen != 'M' && stu.gen != 'm' && stu.gen != 'F' && stu.gen !='f')
            {
                Console.Write("Input Student Gender,again : ");
                stu.gen = char.Parse(Console.ReadLine());
            }
            Console.Write("Input Student Score : ");
            stu.score = double.Parse(Console.ReadLine());
            while (stu.score < 0 || stu.score > 100)
            {
                Console.Write("Input Student Score,again : ");
                stu.score = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("INPUT STUDENT INFORMTION TO STRUTURE");
            Console.WriteLine("-----------------------------------------------------------");
            if(stu.gen == 'M' || stu.gen == 'm')
            {
                Console.WriteLine($"Mr. {stu.name} ({stu.id})");
            }
            else
            {
                Console.WriteLine($"Ms. {stu.name} ({stu.id})");
            }
            if(stu.score <50)
            {
                Console.WriteLine($"Exam score is {stu.score} (FAIL)");
            }
            else
            {
                Console.WriteLine($"Exam score is {stu.score} (PASS)");
            }

            Console.ReadKey();
        }
    }
}
