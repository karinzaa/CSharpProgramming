using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"NO.\tSTUDENT ID\tSTUDENT NANE");
            Console.WriteLine($"--------------------------------------");
            try
            {
                StreamReader sr = new StreamReader("D:\\Text File\\student programming.txt");
                string temp = "";
                int count = 0;
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    string id = data[0];
                    string name = data[2];
                    string[] flname = name.Split(' ');
                    string fname = flname[0];
                    string lname = flname[1];
                    int sec = int.Parse(data[3]);
                    if (sec == 2)
                    {
                        lname= name.Substring(0,1);
                        count++;
                        Console.WriteLine($"{count}\t{id}\t{lname}.{fname}");
                    }
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine($"Error: Cannot open file 'student programming.txt'");
            }

            Console.ReadKey();
        }
    }
}
