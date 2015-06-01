using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnChange
{
    class UserPrompts
    {        
        public static int ItemPrompt()
        {
            do
            {
                Console.Write("\nSelect an item by Item ID from the list above: ");
                string userInput = Console.ReadLine();

                int itemChoice;

                var validSelection = int.TryParse(userInput, out itemChoice);

                if (validSelection && itemChoice > 0)
                {
                    Console.Clear();
                    return itemChoice;
                }

            } while (true);
        }

        public static decimal PaymentPrompt(decimal itemCost)
        {
            do
            {
                Console.Write("Enter your payment amount: ");
                string userInput = Console.ReadLine();

                decimal payment;

                var validAmount = decimal.TryParse(userInput, out payment);

                if (validAmount && payment > 0 && payment > itemCost)
                {
                    return payment;
                }
                
                Console.WriteLine("Payment must be greater than the item cost.");
                
            } while (true);
        }

        public static void Header()
        {
            Console.WriteLine("Change Return Program");
            Console.WriteLine("=============================\n");
        }
        
    }
}
