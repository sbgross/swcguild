using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculator
{
    class UserPrompts
    {
        public static int StartYearPrompt()
        {
            do
            {
                Console.Write("Enter the start year: ");
                string userInput = Console.ReadLine();

                int startYear;

                var validYear = int.TryParse(userInput, out startYear);

                if (validYear && startYear > 0)
                {
                    return startYear;
                }

            } while (true);
        }

        public static int EndYearPrompt()
        {
            do
            {
                Console.Write("Enter the end year: ");
                string userInput = Console.ReadLine();

                int endYear;

                var validYear = int.TryParse(userInput, out endYear);

                if (validYear && endYear > 0)
                {
                    return endYear;
                }

            } while (true);
        }
    }
}
