using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Prime Number Program");
                Console.WriteLine("====================\n");

                int number = UserPrompt.GetNumber();

                int prime = PrimeGenerator.NextPrime(number);

                Console.WriteLine("The next prime number is {0}.\n", prime);

                Console.Write("Would you like to retrieve another prime number Y or N? ");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
                Console.Clear();

            } while (true);
        }
    }
}
