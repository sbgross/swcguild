using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringProgram
{
    class FlooringCalculator
    {
        public static decimal MaterialCalculation(decimal width, decimal length, decimal cost)
        {
            var calc = width * length * cost;

            return calc;
        }

        public static decimal LaborCalculation(decimal width, decimal length)
        {
            decimal laborRate = 86.00M;
            var area = width * length;

            decimal laborCost = laborRate*Math.Floor(area/20);

            if (area%20 >=1 && area%20 <=5)
            {
                laborCost += 21.5M;
            }

            if (area % 20 >= 6 && area % 20 <= 10)
            {
                laborCost += 43.00M;
            }

            if (area % 20 >= 11 && area % 20 <= 15)
            {
                laborCost += 64.5M;
            }

            if (area % 20 >= 16 && area % 20 <= 19)
            {
                laborCost += 86.00M;
            }

            return laborCost;
        }
    }
}
