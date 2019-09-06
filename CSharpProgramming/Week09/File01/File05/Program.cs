using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Input book title to search :");
            string stitle = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader("D:\\Text File\\book.txt");
                string temp = "";
                bool check = false;
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split('*');
                    string title = data[1];
                    double price = double.Parse(data[2]);
                    if (stitle == title)
                    {
                        Console.WriteLine();
                        Console.Write($"{title} is {price} baht.");
                        check = true;
                        break;
                    }
                   
                }
                if (!check)
                {
                    Console.WriteLine();
                    Console.Write($"\"{stitle}\" is not found...");

                }
                sr.Close();
              
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine($"Error: Cannot open file 'book.txt'");
            }
            Console.ReadKey();
        }
    }
}
