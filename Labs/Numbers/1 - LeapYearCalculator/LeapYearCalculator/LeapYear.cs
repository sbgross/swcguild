using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculator
{
    class LeapYear
    {
        public static List<int> LeapYearCalculator(int startYear,int endYear)
        {
            List<int> leapYears = new List<int>();

            for (int i = startYear; i <= endYear; i++)
            {
                if (i%4 == 0 && i%100 != 0 || i%400 == 0)
                {
                    leapYears.Add(i);
                }
            }

            return leapYears;
        }
    }
}
