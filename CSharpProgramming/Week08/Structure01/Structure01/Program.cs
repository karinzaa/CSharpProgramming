using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure01
{
    class Program
    {
        struct book
        {
            public string title;
            public double price;
        }
        struct writer
        {
            public string name, email;
            public int year;
        }
        static void Main(string[] args)
        {
            book book = new book();
            writer writer = new writer();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("INPUT BOOK INFOMATION");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Input book title : ");
            book.title = Console.ReadLine();
            Console.Write("Input book price : ");
            book.price =double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("INPUT AUTHOR INFORMATION");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Input author name : ");
            writer.name = Console.ReadLine();
            Console.Write("Input author email : ");
            writer.email = Console.ReadLine();
            Console.Write("Input author birth year : ");
            writer.year = int.Parse(Console.ReadLine());
           
            int tyear = DateTime.Now.Year - writer.year;
            Console.WriteLine($"The book named \"{book.title}\" write by {writer.name} ({tyear} year old) ");
            Console.WriteLine($"Costs {book.price} baht. (Write contact: {writer.email})");
            Console.ReadKey();
        }
    }
}
