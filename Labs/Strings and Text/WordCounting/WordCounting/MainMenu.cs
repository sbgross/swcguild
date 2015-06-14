using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounting
{
    public class MainMenu
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Word Counting Program");
                Console.WriteLine("==========================");
                Console.WriteLine("This program counts the number of words in a phrase.");

                Console.Write("\nEnter a word or phrase: ");
                string countThis = Console.ReadLine().ToLower();

                Counter c = new Counter();
                int wordCount = c.CountWords(countThis);

                Console.WriteLine("\nThe number of words is {0}.", wordCount);

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
