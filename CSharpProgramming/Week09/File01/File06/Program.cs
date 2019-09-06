using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File06
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine($"List Of students who must visit Advisor");
            Console.WriteLine($"---------------------------------------------");
            try
            {
                StreamReader sr = new StreamReader("D:\\Text File\\advisor duty.txt");
                string temp = "";
                int count = 0;
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    string id = data[0];
                    string sex = data[1];
                    string name = data[2];
                    int year = int.Parse(data[3]);
                    double grade = double.Parse(data[4]);
                    if (year >= 2 && grade < 2.50)
                    {
                        count++;
                        Console.WriteLine($"{count}) {id} {name} ({grade})");
                    }
                }
                
                sr.Close();
            }
            catch
            {
                Console.WriteLine($"Error: Cannot open file 'advisor duty.txt'");
            }
           
            Console.ReadKey();

        }
    }
}
