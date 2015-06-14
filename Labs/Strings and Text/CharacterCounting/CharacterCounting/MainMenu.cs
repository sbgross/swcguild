using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounting
{
    public class MainMenu
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Character Counting Program");
                Console.WriteLine("==========================");
                Console.WriteLine("This program counts the number of vowels in a word or phrase.");

                Console.Write("\nEnter a word or phrase: ");
                string countThis = Console.ReadLine().ToLower();

                Counter c = new Counter();
                int vowelCounter = c.CountVowels(countThis);

                Console.WriteLine("\nThe number of vowels in your entry is {0}.", vowelCounter);

                Console.Write("\nWould you like to enter another word of phrase? ");
                var userInput = Console.ReadLine().ToUpper();

                if (userInput =="N")
                {
                    break;
                }

                Console.Clear();

            } while (true);            
        }
    }
}
