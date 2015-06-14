using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class MainMenu
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Palindrome Program");
                Console.WriteLine("==========================");
                Console.WriteLine("This program determines whether a word or phrase is a palindrome.");

                Console.Write("\nEnter a word or phrase: ");
                string reverseThis = Console.ReadLine().ToLower();

                ReverseCheck r = new ReverseCheck();
                bool palindrome = r.Reverse(reverseThis);

                if (palindrome)
                {
                    Console.WriteLine("\nThe string '{0}' is a palindrome.", reverseThis);
                }
                else
                {
                    Console.WriteLine("\nThe string '{0}' is not a palindrome.", reverseThis);
                }
                
                Console.Write("\nWould you like to enter another word of phrase? ");
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
