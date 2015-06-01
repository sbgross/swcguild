using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringProgram
{
    class MainMenu
    {
        public void Execute()
        {
            Console.WriteLine("Welcome to the Flooring Calculation program");
            Console.WriteLine("============================================");
            Console.WriteLine();
            do
            {
                //this format is a static call. If "new" instantiation had been used, User Prompt methods
                //could have been set to non-static
                var width = UserPrompts.WidthPrompt();
                var length = UserPrompts.LengthPrompt();
                var cost = UserPrompts.CostPrompt();

                var materialCost = FlooringCalculator.MaterialCalculation(width, length, cost);
                var laborCost = FlooringCalculator.LaborCalculation(width, length);
                
                Console.WriteLine("\nThe material cost of tiling this area is {0:C2}.", materialCost);
                Console.WriteLine("The labor cost of of tiling this area is {0:C2}.\n", laborCost);
                Console.WriteLine("Your total charge is {0:C2}.\n", materialCost + laborCost);

                Console.Write("Would you like to calculate another tile job Y or N? ");
                var userResponse = Console.ReadLine().ToUpper(); 

                if (userResponse == "N")
                {
                    break;
                }                
                Console.Clear();
            } while (true);
        }

        
    }
}
