using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    public class UserPrompts
    {
        public string GetString()
        {
            Console.Write("\nEnter a string you would like to reverse: ");
            var userInput = Console.ReadLine();

            return userInput;
        }
    }
}
