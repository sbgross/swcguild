using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculator
{
    class MainMenu
    {
        public void Execute()
        {
            Console.WriteLine("Leap Year Calculation program");
            Console.WriteLine("=============================\n");
            Console.WriteLine("This program will return all leap years in a given date range.");

            do
            {
                int startYear = UserPrompts.StartYearPrompt();
                int endYear = UserPrompts.EndYearPrompt();

                var leapYearList = LeapYear.LeapYearCalculator(startYear, endYear);

                Console.WriteLine();

                foreach (var y in leapYearList)
                {
                    Console.WriteLine(y);
                }

                Console.Write("\nWould you like to see another date range Y or N? ");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }

                Console.Clear();

            } while (true);
        }
    }
}
