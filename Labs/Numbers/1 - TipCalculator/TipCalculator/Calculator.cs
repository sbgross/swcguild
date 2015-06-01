using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Calculator
    {
        public static decimal CalculateTip(decimal dollarAmount, decimal tipPercent)
        {
            var tipAmount = dollarAmount*tipPercent;

            return tipAmount;
        }

        public static decimal CalculateTotal(decimal dollarAmount, decimal tipAmount)
        {
            var totalAmount = dollarAmount + tipAmount;

            return totalAmount;
        }
    }
}
