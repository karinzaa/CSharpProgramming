using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input exercie score : ");
            double ex = double.Parse(Console.ReadLine());
            Console.Write("Input mid-term score :");
            double mid = double.Parse(Console.ReadLine());
            Console.Write("Input final score : ");
            double final = double.Parse(Console.ReadLine());
            double totlal = ex + mid + final;
            if(totlal > 100 || totlal < 0)
            {

             Console.Write($"Your total score is {totlal}, get grade Error");
            }
            else
            {
                if (totlal > 80)
                {
                    Console.Write($"Your total score is {totlal}, get grade A");
                }
                else if (totlal > 75)
                {
                    Console.Write($"Your total score is {totlal}, get grade B+");
                }
                else if (totlal > 70)
                {
                    Console.Write($"Your total score is {totlal}, get grade B");
                }
                else if (totlal > 65)
                {
                    Console.Write($"Your total score is {totlal}, get grade C+");
                }
                else if (totlal > 60)
                {
                    Console.Write($"Your total score is {totlal}, get grade C");
                }
                else if (totlal > 55)
                {
                    Console.Write($"Your total score is {totlal}, get grade D+");
                }
                else if (totlal > 50)
                {
                    Console.Write($"Your total score is {totlal}, get grade D");
                }
                else if (totlal < 50)
                {
                    Console.Write($"Your total score is {totlal}, get grade F");
                }
            }
           
            Console.ReadKey();
        }
    }
}
