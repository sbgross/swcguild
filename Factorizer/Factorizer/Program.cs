using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Factorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> perfectNumber = new List<int>();
            int primeCount = 0;

            bool validInput = false;
            int number;

            do
            {
                Console.Write("What number would you like to factor? ");
                string input = Console.ReadLine();

                validInput = int.TryParse(input, out number);

                if (!validInput)
                {
                    Console.WriteLine("That was not a number. Please try again");
                }
            } while (!validInput);
                        
            Console.WriteLine("\nThe factors of {0} are:\n", number);            

            for (int i = 1; i < number; i++)
            {                
                if (number % i == 0)

                {
                    Console.WriteLine(i);
                    Console.WriteLine();
                    perfectNumber.Add(i);                    
                    primeCount++;
                }                                
            }  
          
            if (perfectNumber.Sum() == number)
            {                                
                Console.WriteLine("{0} is a perfect number.", number);      
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number.", number);
                Console.WriteLine();
            }

            if (primeCount == 1)
            {                
                Console.WriteLine("{0} is a prime number.", number);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.", number);
                Console.WriteLine();
            }
            Console.ReadLine();
        }        
    }
}
