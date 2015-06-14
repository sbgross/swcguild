using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLetterCombinations
{
    public class MainMenu
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Phone Letter Program");
                Console.WriteLine("==========================");
                Console.WriteLine("This program determines the phone pad letter combinations for two numbers.");

                bool validNumber;
                int phoneNumber = 0;
                do
                {
                    Console.Write("\nEnter two numbers, each between 2 and 9: ");
                    var userNumber = Console.ReadLine().ToLower();
                    
                    validNumber = int.TryParse(userNumber, out phoneNumber);
                } while (!validNumber);

                string stringNumber = phoneNumber.ToString();

                Combinations n = new Combinations();
                List<string> letterCombos = n.GenerateCombinations(stringNumber);

                foreach (var c in letterCombos)
                {
                    Console.WriteLine(c);
                }

                Console.Write("\nWould you like to enter another number? ");
                var userInput = Console.ReadLine().ToUpper();

                if (userInput == "N")
                {
                    break;
                }

                Console.Clear();

            } while (true);
        }
    }
}
