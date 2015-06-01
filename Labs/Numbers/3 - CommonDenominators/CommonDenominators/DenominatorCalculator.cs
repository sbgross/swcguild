using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDenominators
{
    public class DenominatorCalculator
    {
        public static List<int> numbers = new List<int>(); 

        public List<int> CommonDenominator(int denominator1, int denominator2)
        {                            
            for (int i = 1; i <= denominator1 * denominator2; i++)
            {
                if (i % denominator1 == 0 && i % denominator2 == 0)
                {
                    numbers.Add(i);
                }
            }           

            return numbers;
        }
    }
}
