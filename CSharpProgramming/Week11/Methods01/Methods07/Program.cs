using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Methods07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Input gender of advisee : ");
            string gen = Console.ReadLine().ToLower();
            while (gen != "m" && gen != "f")
            {
                Console.Write($"Input gender of advisee,again : ");
                gen = Console.ReadLine().ToLower();
            }
            Console.WriteLine();
            Console.WriteLine($"The number of advisee is {CountAdvisee(gen)}");
            ShowAdvisee(gen);
            Console.ReadKey();
        }

        static int CountAdvisee(string frontname)
        {
            StreamReader sr = new StreamReader("D:advisor duty.txt");
            string temp = "";
            int countadv = 0;
            if (frontname == "m")
            {
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (data[1] == "Mr.")
                    {
                        countadv++;
                    }
                }
            }
            if (frontname == "f")
            {
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (data[1] == "Miss")
                    {
                        countadv++;
                    }
                }
            }
            
            return countadv;
        }
        static void ShowAdvisee(string frontname)
        {
            Console.WriteLine("--------------------------------------------------");
            StreamReader sr = new StreamReader("D:advisor duty.txt");
            string temp = "";
            int countadv = 0;
            if (frontname == "m")
            {
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (data[1] == "Mr.")
                    {
                        Console.WriteLine($"{data[0]}\t\t{data[2]}");
                    }
                }
            }
            if (frontname == "f")
            {
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (data[1] == "Miss")
                    {
                        Console.WriteLine($"{data[0]}\t\t{data[2]}");
                    }
                }
            }
        }

    }
}
