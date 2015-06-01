using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class UserPrompts
    {
        public static int GetConversionOption()
        {
            do
            {                
                Console.Write("\nSelect a conversion option from the list above: ");                
                var userInput = Console.ReadLine();

                int number;

                var validNumber = int.TryParse(userInput, out number);

                if (validNumber && number >= 0 && number < 3)
                {
                    return number;
                }

            } while (true);
        }

        internal static decimal GetCelsius()
        {
            do
            {
                Console.Write("\nEnter the Celsius temperature you wish to convert: ");
                var userInput = Console.ReadLine();

                decimal celsius;

                var validTemp = decimal.TryParse(userInput, out celsius);

                if (validTemp)
                {
                    return celsius;
                }
            } while (true);          
        }

        internal static decimal GetKelvin()
        {
            do
            {
                Console.Write("\nEnter the Kelvin temperature you wish to convert: ");
                var userInput = Console.ReadLine();

                decimal kelvin;

                var validInput = decimal.TryParse(userInput, out kelvin);

                if (validInput)
                {
                    return kelvin;
                }
            } while (true);
        }
    }
}
