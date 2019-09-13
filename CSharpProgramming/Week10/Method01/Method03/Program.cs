using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your e - mail : ");
            string mail = Console.ReadLine();
            string[] data = mail.Split('@');
            string first = data[0].Substring(0, 1);
            string last = data[0].Substring(data[0].Length - 1);
            while (first == "@" || first == " " || first == "_" || first == "-" || first == "." || first == "*" || first == "+" || first == "|" || first == "\"" || first == "/" || first == "?" || first == "!" || first == "^" || first == "%" || first == "&" || first == "{" || first == "}" || first == "[" || first == "]" || first == ":" || first == ";" || first == "~")
            {
                Console.Write("Input your name, again : ");
                mail = Console.ReadLine();
                data = mail.Split('@');
                if(first != "@" || first != " " || first != "_" || first != "-" || first != "." || first != "*" || first != "+" || first != "|" || first != "\"" || first != "/" || first != "?" || first != "!" || first != "^" || first != "%" || first != "&" || first != "{" || first != "}" || first != "[" || first != "]" || first != ":" || first != ";" || first != "~")
                {
                    break;
                }
            }
            while (last == " " || last == "_" || last == "-" || last == "." || last == "*" || last == "+" || last == "|" || last == "\"" || last == "/" || last == "?" || last == "!" || last == "^" || last == "%" || last == "&" || last == "{" || last == "}" || last == "[" || last == "]" || last == ":" || last == ";" || last == "~" )
            {
                Console.Write("Input your name, again : ");
                mail = Console.ReadLine();
                data = mail.Split('@');
                if(last != " " || last != "_" || last != "-" || last != "." || last != "*" || last != "+" || last != "|" || last != "\"" || last != "/" || last != "?" || last != "!" || last != "^" || last != "%" || last != "&" || last != "{" || last != "}" || last != "[" || last != "]" || last != ":" || last != ";" || last != "~")
                {
                    break;
                }
            }
            while (data[1] != "hotmail.com" && data[1] != "gmail.com" && data[1] != "windowslive.com")
            {
                Console.Write("Input your name, again : ");
                mail = Console.ReadLine();
                data = mail.Split('@');
            }
            Console.WriteLine();
            Console.WriteLine("Your e-mail is \"{0}\"", mail.ToUpper());
            Console.ReadKey();
        }  
    }
}
