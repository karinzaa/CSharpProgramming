using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name : ");
            string text = Console.ReadLine().ToLower();
            while (true)
            {
                int check = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                        check += 1;
                }
                if (text[0] != ' ' && text[text.Length - 1] != ' ' && check == 1 && text.Contains(' '))
                    break;
                Console.Write("Input your name, again : ");
                text = Console.ReadLine().ToLower();
            }
            Console.WriteLine();
            string[] data = text.Split(' ');

            string lname = data[1];
            Console.WriteLine("Your TNI mail is {0}{1}.{2}_st@tni.ac.th", lname[0], lname[1], data[0]);

            Console.ReadKey();
        }
    }
}
