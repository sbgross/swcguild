using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class UserPrompts
    {
        public static decimal PromptForDollarValue()
        {
            do
            {
                Console.Write("Enter a dollar amount: ");
                string userInput = Console.ReadLine();

                decimal dollarAmount;

                bool validDollar = decimal.TryParse(userInput, out dollarAmount);

                if (validDollar && dollarAmount > 0)
                {
                    return dollarAmount;
                }
            } while (true);
        }

        public static decimal PromptForTipPercent()
        {
            do
            {
                Console.Write("Enter the percent amount you would like to tip (ex. 15): ");
                string userInput = Console.ReadLine();

                decimal tipAmount;

                bool validDollar = decimal.TryParse(userInput, out tipAmount);

                if (validDollar && tipAmount > 0)
                {
                    return tipAmount/100;
                }
            } while (true);
        }
    }
}
