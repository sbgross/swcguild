using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FlooringProgram
{
    class UserPrompts
    {
        //changed all methods to static bc of message in Main Menu Execute():
        //"Cannot access non-static method in static context"
        public static decimal WidthPrompt()
        {
            do
            {                            
                Console.Write("Enter the width of the area to be tiled: ");
                string userInput = Console.ReadLine();

                decimal width;

                var validWidth = decimal.TryParse(userInput, out width);

                if (validWidth)
                {
                    return width;
                }                
            } while (true);
        }

        public static decimal LengthPrompt()
        {
            do
            {
                Console.Write("Enter the length of the area to be tiled: ");
                string userInput = Console.ReadLine();

                decimal length;

                var validLength = decimal.TryParse(userInput, out length);

                if (validLength)
                {
                    return length;                    
                }
            } while (true);
        }

        public static decimal CostPrompt()
        {
            do
            {
                Console.Write("Enter the cost per unit of tile: ");
                string userInput = Console.ReadLine();

                decimal cost;

                var validCost = decimal.TryParse(userInput, out cost);

                if (validCost)
                {
                    return cost;                                
                }
            } while (true);
        }        
    }
}
