using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class ConversionList
    {
        public static List<Conversion> _conversions;

        static ConversionList()
        {
            _conversions = new List<Conversion>()
            {
                new Conversion() {ConversionId = 1, ConversionName = "Celsius to Kelvin"},
                new Conversion() {ConversionId = 2, ConversionName = "Kelvin to Celsius"}
            };
        }

        public static List<Conversion> GetAll()
        {
            return _conversions;
        }
    }
}
