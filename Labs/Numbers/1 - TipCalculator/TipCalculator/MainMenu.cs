using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class MainMenu
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Tip Calculator");
                Console.WriteLine("==============");

                var dollarAmount = UserPrompts.PromptForDollarValue();
                var tipPercent = UserPrompts.PromptForTipPercent();

                var tipAmount = Calculator.CalculateTip(dollarAmount, tipPercent);
                var totalAmount = Calculator.CalculateTotal(dollarAmount, tipAmount);

                Console.WriteLine("\nAmount: {0,13:C}", dollarAmount);
                Console.WriteLine("Tip: {0,16:C}", tipAmount);
                Console.WriteLine("Total: {0,14:C}", totalAmount);
                
                Console.Write("\nWould you like to calculate another amount Y or N? ");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }

                Console.Clear();
            } while (true);
        }
    }
}
