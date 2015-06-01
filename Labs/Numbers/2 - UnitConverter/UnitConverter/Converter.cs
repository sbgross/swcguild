using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class Converter
    {
        public static decimal CelsiusToKelvin(decimal celsius)
        {
            decimal kelvin = celsius + 273.15M;

            return kelvin;
        }

        internal static decimal KelvinToCelsius(decimal kelvin)
        {
            decimal celsius = kelvin - 273.15M;

            return celsius;
        }
    }
}
