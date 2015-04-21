using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Conditionals.BLL
{
    public class ConditionalWarmups
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return (aSmile == bSmile);
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            return (isWeekday == isVacation);
        }

        public int SumDouble(int a, int b)
        {
            if (a != b)
            {
                return a + b;
            }

            return (a*2) + (b*2);
        }

        public int Diff21(int n)
        {
            if (n >= 21)
            {
                return (n - 21)*2;
            }

            return 21 - n;
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking && hour < 7 || hour > 20)
            {
                return true;
            }

            return false;
        }

        public bool Makes10(int a, int b)
        {
            if (a == 10 || b == 10 || a + b == 10)
            {
                return true;
            }
            return false;
        }

        public bool NearHundred(int n)
        {
            return (Math.Abs(100 - n) <= 10 || Math.Abs(200 - n) <= 10);
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            return (a < 0 || b < 0 && negative == false);
        }

        public string NotString(string s)
        {
            if (s.Length >= 3 && s.Substring(0,3) == "not")
            {
                return s;
            }

            return "not " + s;
        }

        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        public string FrontBack(string str)
        {
            var charFirst = str.Substring(0, 1);
            var charLast = str.Substring(str.Length - 1, 1);
            if (str.Length > 1)
            {
                str = charLast + str.Substring(1,str.Length-2) + charFirst;

            }
            return str;
        }

        public string Front3(string str)
        {
            string newStr = "";

            if (str.Length > 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    newStr += str.Substring(0, 3);

                }
            }
            else
            {
                newStr = str + str + str;
            }
            return newStr;
        }

        public string BackAround(string str)
        {
            var char1 = str.Substring(str.Length - 1, 1);
            return str = char1 + str + char1;
        }

        public bool Multiple3or5(int number)
        {
            return (number%3 == 0 || number%5 == 0);
        }

        public bool StartHi(string str)
        {
            if (str.Length > 2)
            {
                return str.Substring(0, 3) == "hi ";
            }

            return str.Substring(0, 2) == "hi";
        }

        public bool IcyHot(int temp1, int temp2)
        {
            return (temp1 < 0 && temp2 > 100 || temp1 > 100 && temp2 < 0);            
        }

        public bool Between10and20(int a, int b)
        {
            return (a > 9 && a < 21 || b > 9 && b < 21);
        }

        public bool HasTeen(int a, int b, int c)
        {
            return (a > 12 && a < 20 || b > 12 && b < 20) || c > 12 && c < 20;
        }

        public bool SoAlone(int a, int b)
        {
            if (a > 9 && a < 21 || b > 9 && b < 21)
            {
                return true;
            }
            return false;

        }

        public string RemoveDel(string str)
        {
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i,3) == "del")
                {
                    str = str.Remove(i, 3);
                }
            }
            return str;
        }

        public bool IxStart(string str)
        {
            return str.Substring(1, 2) == "ix";
        }

        public string StartOz(string str)
        {
            string newStr = "";

            if (str.Length >= 1 && str.Substring(0, 1) == "o")
            {
                newStr += str[0];
            }

            if (str.Length >= 2 && str.Substring(1, 1) == "z")
            {
                newStr += str[1];
            }
            return newStr;
        }

        public int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }
            return max;
        }

        public int Closer(int a, int b)
        {
            int closer = 0;
            if (Math.Abs(10 - a) < Math.Abs(10 - b))
            {
                closer = a;
            }
            if (Math.Abs(10 - a) > Math.Abs(10 - b))
            {
                closer = b;
            }
            return closer;
        }

        public bool GotE(string str)
        {
            int e = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e')
                {
                    e += 1;
                }
            }
            return (e >= 1 && e <= 3);
        }

        public string EndUp(string str)
        {
            string newstr = str.ToUpper();
            if (str.Length > 3)
            {
                return newstr = str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
            }
            return newstr;
        }

        public string EveryNth(string str, int n)
        {           
            int i = 0;
            string newstr = "";
            while (i < str.Length)
            {
                newstr += str[i];
                i += n;
            }
            return newstr;
        }
    }
}
