using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnChange
{
    class MainMenu
    {
        public void Execute()
        {
            UserPrompts.Header();
            Console.Write("This program will calculate the number of quarters, dimes, nickels and pennies \n" +
                              "given change due after a purchase.\n\n" +
                              "Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            do
            {
                UserPrompts.Header();

                decimal change = 0;
                var list = new ItemList();
                var newList = list.GetAll();
                ChangeList changeList = new ChangeList();

                foreach (var i in newList)
                {
                    Console.WriteLine("Item ID: " + i.ItemId + "; Item Name: " + i.ItemName + "; Item Cost: {0:C2}",i.ItemCost);
                }

                int itemChoice = UserPrompts.ItemPrompt();
                var selection = newList.Where(i => i.ItemId == itemChoice);                              

                foreach (var i in selection)
                {
                    Console.WriteLine("You have selected {0} at a cost of {1:C2}",i.ItemName,i.ItemCost);
                    decimal paymentAmount = UserPrompts.PaymentPrompt(i.ItemCost);  
                    change = ChangeCalculator.Change(i.ItemCost, paymentAmount);
                }                           

                Console.WriteLine("\nYour change of {0:C2} will be made up of the following: ",change);

                changeList = ChangeCalculator.CoinBreakout(change);

                Console.WriteLine("Number of Quarters: {0}", changeList.Quarters);
                Console.WriteLine("Number of Dimes: {0}", changeList.Dimes);
                Console.WriteLine("Number of Nickels: {0}", changeList.Nickels);
                Console.WriteLine("Number of Pennies: {0}", changeList.Pennies);

                Console.Write("\nWould you like to see the breakout of another change amount Y or N? ");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }

                Console.Clear();

            } while (true);
        }
    }
}
