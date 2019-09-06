using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"ID\t\tUnit\t\tStatus");
            Console.WriteLine($"---------------------------------------------");
            try
            {
                StreamReader sr = new StreamReader("D:\\Text File\\products.txt");
                string temp = "";
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    string id = data[0];
                    int unit = int.Parse(data[1]);
                    string sta = "";
                    if (unit == 0)
                    {
                        sta = "OUT OF STOCK";
                    }
                    else if (unit <= 20)
                    {
                        sta = "LOW";
                    }
                    else
                    {
                        sta = "NOMAL";
                    }

                    Console.WriteLine($"{id}\t\t{unit}\t\t{sta}");
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine($"Error: Cannot open file 'products.txt'");
            }
            Console.WriteLine($"---------------------------------------------");
            Console.ReadKey();

        }
    }
}
