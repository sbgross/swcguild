using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class UserPrompt
    {
        public static int GetNumber()
        {
            do
            {
                Console.Write("Enter a positive number: ");
                var userInput = Console.ReadLine();

                int number;

                var validNumber = int.TryParse(userInput, out number);

                if (validNumber && number >= 0)
                {
                    return number;
                }

            } while (true);
        }        
    }
}
