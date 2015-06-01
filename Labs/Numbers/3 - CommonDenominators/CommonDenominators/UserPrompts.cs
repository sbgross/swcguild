using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDenominators
{
    public class UserPrompts
    {
        public static int Numerator1()
        {
            do
            {
                Console.Write("\nEnter the numerator of the first fraction: ");
                var userInput = Console.ReadLine();

                int numerator1;

                var validInput = int.TryParse(userInput, out numerator1);

                if (validInput)
                {
                    return numerator1;
                }
            } while (true);            
        }

        public static int Numerator2()
        {
            do
            {
                Console.Write("\nEnter the numerator of the second fraction: ");
                var userInput = Console.ReadLine();

                int numerator2;

                var validInput = int.TryParse(userInput, out numerator2);

                if (validInput)
                {
                    return numerator2;
                }
            } while (true);
        }

        public static int Denominator1()
        {
            do
            {
                Console.Write("Enter the denominator of the first fraction: ");
                var userInput = Console.ReadLine();

                int denominator1;

                var validInput = int.TryParse(userInput, out denominator1);

                if (validInput)
                {
                    return denominator1;
                }
            } while (true);
        }

        public static int Denominator2()
        {
            do
            {
                Console.Write("Enter the denominator of the second fraction: ");
                var userInput = Console.ReadLine();

                int denominator2;

                var validInput = int.TryParse(userInput, out denominator2);

                if (validInput)
                {
                    return denominator2;
                }
            } while (true);
        }
    }
}
