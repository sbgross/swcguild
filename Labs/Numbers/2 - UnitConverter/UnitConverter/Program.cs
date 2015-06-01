using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Unit Converter Program");
                Console.WriteLine("=======================\n");

                var options = ConversionList.GetAll();

                foreach (var o in options)
                {
                    Console.WriteLine("Option " + o.ConversionId + ": " + o.ConversionName);
                }

                int number = UserPrompts.GetConversionOption();

                if (number == 1)
                {
                    decimal celsius = UserPrompts.GetCelsius();
                    decimal newKelvin = Converter.CelsiusToKelvin(celsius);
                    Console.WriteLine("Kelvin equivalent is {0}.\n", newKelvin);
                }

                if (number == 2)
                {
                    decimal kelvin = UserPrompts.GetKelvin();
                    decimal newCelsius = Converter.KelvinToCelsius(kelvin);
                    Console.WriteLine("Celsius equivalent is {0}.\n", newCelsius);
                }

                Console.Write("Would you like to convert another temperature Y or N? ");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
                Console.Clear();

            } while (true);
        }
    }
}
