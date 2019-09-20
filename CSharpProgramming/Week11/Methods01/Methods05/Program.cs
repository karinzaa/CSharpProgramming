using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods05
{
    class Program
    {
        struct Subject
        {
            public string id;
            public int credit;
            public float grade;
        }
        static void Main(string[] args)
        {
     
           
            Console.Write($"How many subject to enroll : ");
            int sub = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Subject[] enroll = new Subject[sub];
            for (int i = 0; i < sub ; i++)
            {
                Console.Write($"Input subject ID     : ");
                enroll[i].id = Console.ReadLine();
                Console.Write($"Input subject credit : ");
                enroll[i].credit = int.Parse(Console.ReadLine());
                Console.Write($"Input subject grade  : ");
                enroll[i].grade = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            ShowHeader();
            ShowGrade(enroll);
            Console.Write("GPA = {0:f}", CalculateGPA(enroll));
            Console.ReadKey();

        }

        static void ShowHeader()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ID\t\tCREDIT\t\tGRADE");
            Console.WriteLine("--------------------------------------------------");
        }
        static void ShowGrade(Subject[] sub)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                Console.WriteLine($"{sub[i].id}\t\t  {sub[i].credit}\t\t{sub[i].grade:N1}");
            }
            Console.WriteLine("--------------------------------------------------");

        }
        static float CalculateGPA(Subject[] sub)
        {
            float total = 0,totalcradit = 0;
            float gpa;
            for (int i = 0; i < sub.Length; i++)
            {
                totalcradit += sub[i].credit;
                total += (sub[i].credit * sub[i].grade);
            }
            gpa = total / totalcradit;
            return gpa;
        }
    }
}
