using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class UserPrompts
    {
        public static int TermNumber()
        {
            do
            {
                Console.Write("Enter the number of terms you would like to generate: ");
                var userInput = Console.ReadLine();

                int term;

                var validSelection = int.TryParse(userInput, out term);

                if (validSelection && term > 0)
                {
                    return term;
                }
            } while (true);
            
        }
    }
}
