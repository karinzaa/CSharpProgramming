using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a message :" );
             string message= Console.ReadLine();

            int A = 0, E = 0, I = 0, O = 0, U = 0;

            foreach (char message1 in message)
            {
                if (message1 == 'A' || message1 == 'a')
                {
                    A++;
                }
                if (message1 == 'E' || message1 == 'e')
                {
                    E++;
                }
                if (message1 == 'I' || message1 == 'i')
                {
                    I++;
                }
                if (message1 == 'O' || message1 == 'o')
                {
                    O++;
                }
                if (message1 == 'U' || message1 == 'u')
                {
                    U++;
                }

            }

            Console.WriteLine();
            if(A != 0)
            {
                Console.WriteLine($"The number of letter 'A' is {A}");
            }
            if (E!= 0)
            {
                Console.WriteLine($"The number of letter 'E' is {E}");
            }
            
            if (I != 0)
            {
                Console.WriteLine($"The number of letter 'I' is {I}");
            }
           
            if (O != 0)
            {
                Console.WriteLine($"The number of letter 'O' is {O}");
            }
           
            if (U != 0)
            {
                Console.WriteLine($"The number of letter 'U' is {U}");
            }
            Console.ReadKey();


        }
    }
}
