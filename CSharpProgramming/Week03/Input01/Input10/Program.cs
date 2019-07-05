using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input money : ");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Type\t\tUnit\t\tValue ");
            Console.WriteLine("---------------------------------------");
            int unit = money / 1000,value = unit * 1000;
            money = money - value;
            Console.WriteLine($"1000\t\t{unit,-19}{value} ");
            unit = money / 500;
            value = unit * 500;
            money = money - value;
            Console.WriteLine($"500\t\t{unit,-20}{value} ");
            unit = money / 100;
            value = unit * 100;
            money = money - value;
            Console.WriteLine($"100\t\t{unit,-20}{value} ");
            unit = money / 50;
            value = unit * 50;
            money = money - value;
            Console.WriteLine($"50\t\t{unit,-21}{value} ");
            unit = money / 20;
            value = unit * 20;
            money = money - value;
            Console.WriteLine($"20\t\t{unit,-21}{value} ");
            unit = money / 1;
            value = unit * 1;
            money = money - value;
            Console.WriteLine($"Coin\t\t{unit,-22}{value} ");
            Console.ReadKey();
        }
    }
}
