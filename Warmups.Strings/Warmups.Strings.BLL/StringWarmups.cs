using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Strings.BLL
{
    public class StringWarmups
    {
        public string SayHi(string name)
        {
            string sayHi = ("Hello " + name + "!");

            return sayHi;
        }

        public string Abba(string a, string b)
        {
            string abba = a + b + b + a;
            return abba;
        }

        public string MakeTags(string tag, string content)
        {          
            string makeTags = string.Format("<{0}>{1}</{0}>", tag, content);
            return makeTags;
        }

        public string InsertWord(string container, string word)
        {
            string insertWord = container.Insert(2, word);
            return insertWord;
        }

        public string MultipleEndings(string str)
        {
            string newStr = "";

            for (int i = 0; i < 3; i++)
            {
                newStr += string.Format("{0}{1}", str[str.Length - 2], str[str.Length - 1]);
            }

            return newStr;
        }

        public string FirstHalf(string str)
        {
            string newstr = "";
            int half = str.Length/2;
            for (int i = 0; i < half; i++)
            {
                newstr += str[i];
            }

            return newstr;
        }

        public string TrimOne(string str)
        {
            string newStr = "";
            for (int i = 1; i < str.Length - 1; i++)
            {
                newStr += str[i];
            }
            return newStr;
        }

        public string LongInMiddle(string a, string b)
        {
            string newStr = "";
            if (a.Length > b.Length)
            {
                newStr = string.Format(b + a + b);
            }
            else
            {
                newStr = string.Format(a + b + a);
            }
            return newStr;
        }

        public string RotateLeft2(string str)
        {
            string newStr = str;
            if (str.Length > 2)
            {
                newStr = string.Format(str.Substring(2, str.Length - 2) + str.Substring(0, 2));
            }

            return newStr;
        }

        public string RotateRight2(string str)
        {
            string newStr = str;
            if (str.Length > 2)
            {
                newStr = string.Format(str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2));
            }
            return newStr;
        }

        public string TakeOne(string str, bool fromFront)
        {
            string newStr = "";
            if (fromFront)
            {
                return newStr += str[0];
            }
            return newStr += str[str.Length - 1];
        }

        public string MiddleTwo(string str)
        {
            string newStr = "";
            int strLen = str.Length;
            if (strLen % 2 == 0)
            {
                newStr = string.Format(str.Substring((strLen / 2) - 1, 2));
            }

            return newStr;
        }

        public bool EndsWithLy(string str)
        {
            if (str.Length > 1 && str.Substring(str.Length - 2, 2) == "ly")
            {
                return true;
            }
            return false;
        }

        public string FrontAndBack(string str, int n)
        {
            string newStr = string.Format(str.Substring(0, n) + str.Substring(str.Length - n, n));
            return newStr;
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            string newStr = str;
            if (n > str.Length - 2)
            {
                return newStr = string.Format(str.Substring(0, 2));
            }
            else
            {
                return newStr = string.Format(str.Substring(n, 2));
            }
        }

        public bool HasBad(string str)
        {
            return (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad");
        }

        public string AtFirst(string str)
        {
            string newStr = str;
            if (str.Length >= 2)
            {
                return newStr = string.Format(str.Substring(0, 2));
            }
            else if (str.Length == 1)
            {
                return newStr = string.Format(str[0] + "@");
            }
            else
            {
                return newStr = "@@";
            }
        }

        public string LastChars(string a, string b)
        {
            string newStr = "";
            newStr += (a.Length >= 1) ? a[0] : '@';
            newStr += (b.Length >= 1) ? b[b.Length - 1] : '@';
            return newStr;
        }

        public string ConCat(string a, string b)
        {
            string newStr = string.Format(a + b);

            if (a != "" && b != "" && newStr[a.Length - 1] == newStr[a.Length])
            {
                newStr = newStr.Remove(a.Length - 1, 1);
            }
            return newStr;
        }

        public string SwapLast(string str)
        {
            string newStr = str;
            if (str.Length >= 2)
            {                
                newStr = (str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1, 1) + str.Substring(str.Length - 2, 1));
            }
            return newStr;
        }

        public bool FrontAgain(string str)
        {
            return (str.Substring(0, 2) == str.Substring(str.Length - 2, 2));
        }

        public string MinCat(string a, string b)
        {
            string newStr = "";
            if (a.Length > b.Length)
            {
                newStr = (a.Substring(0 + (a.Length - b.Length), a.Length - (a.Length - b.Length)) + b);
            }
            else if (b.Length > a.Length)
            {
                newStr = (a + b.Substring(0 + (b.Length - a.Length), b.Length - (b.Length - a.Length)));
            }
            else
            {
                newStr = a + b;
            }
            return newStr;
        }

        public string TweakFront(string str)
        {
            string newStr = str;

            if (newStr.Length >= 2 && newStr[0] == 'a' && newStr[1] != 'b')
            {
                newStr = newStr.Remove(1, 1);
            }
            else if (newStr.Length >= 2 && newStr[0] != 'a')
            {
                newStr = newStr.Remove(0, 2);
            }
            return newStr;
        }

        public string StripX(string str)
        {            
            if (str[0] == 'x')
            {
                str = str.Remove(0, 1);
            }
            
            if (str[str.Length - 1] == 'x')
            {
                str = str.Remove(str.Length - 1, 1);
            }
            return str;            
        }
    }
}
