using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    public class MainMenu
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Reverse A String Program");
                Console.WriteLine("========================");

                var prompt = new UserPrompts();
                var text = new TextReverser();

                string original = prompt.GetString();
                string reverse = text.Reverse(original);

                Console.WriteLine("\nYour string in reverse order is {0}", reverse);
                Console.Write("Would you like to reverse another string? ");
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
