using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnChange
{
    public class ChangeCalculator
    {
        public static decimal Change(decimal itemCost, decimal payAmount)
        {
            decimal change = Math.Abs(itemCost - payAmount);

            return change;
        }

        public static ChangeList CoinBreakout(decimal change)
        {
            ChangeList changeList = new ChangeList();

            if (change / .25M >= 1)
            {
                changeList.Quarters = Math.Floor(change / .25M);
                change -= changeList.Quarters * .25M;
            }

            if (change / .1M >= 1)
            {
                changeList.Dimes = Math.Floor(change / .1M);
                change -= changeList.Dimes * .1M;   
            }

            if (change / .05M >= 1)
            {
                changeList.Nickels = Math.Floor(change / .05M);
                change -= changeList.Nickels * .05M;
            }

            if (change / .01M >= 0)
            {
                changeList.Pennies = Math.Floor(change / .01M);
                change -= changeList.Pennies *  .01M;    
            }

            return changeList;
        }
    }
}
