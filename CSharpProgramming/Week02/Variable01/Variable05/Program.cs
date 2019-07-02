using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable05
{
    class Program
    {
        static void Main(string[] args)
        {
            string id, name, major;
            int birthYear,currentYear,age;
            id = "1913110001";
            name = "Malee Aroina";
            major = "IT";
            currentYear = 2019;
            birthYear = 2001;
            age = currentYear - birthYear;
            Console.WriteLine("STUDEN : {0} {1}",id,name);
            Console.WriteLine("MAJOR  : {0}", major);
            Console.WriteLine("AGE    : {0}", age);
            Console.ReadKey();
        }
    }
}
