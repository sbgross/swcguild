using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CommonDenominators
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Common Denominator Program");
                Console.WriteLine("==========================");

                Console.WriteLine("\nThis program will calculate the least and greatest common denominators " +
                    "\ngiven two fractions.");

                int numerator1 = UserPrompts.Numerator1();
                int denominator1 = UserPrompts.Denominator1();

                int numerator2 = UserPrompts.Numerator2();
                int denominator2 = UserPrompts.Denominator2();

                DenominatorCalculator n = new DenominatorCalculator();
                var numbers = n.CommonDenominator(denominator1,denominator2);              

                Console.WriteLine("\nThe least common denominator is {0}.", numbers.Min());
                Console.WriteLine("The greatest common denominator is {0}.", numbers.Max());

                Console.Write("\nWould you like to enter another fraction? ");
                var userInput = Console.ReadLine().ToUpper();

                if (userInput == "N")
                {
                    break;
                }

                Console.Clear();

            } while (true);
        }
    }
}

