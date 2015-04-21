using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Warmups.Loops.BLL
{
    public class LoopWarmups
    {
        public string StringTimes(string str, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += str;
            }

            return result;
        }

        public string FrontTimes(string str, int n)
        {
            string result = "";
            string newstr = str.Substring(0, 3);

            for (int i = 0; i < n; i++)
            {
                result += newstr;
            }
            return result;
        }

        public int CountXX(string str)
        {
            int count = 0;
            if (str.Length >= 2)
            {
                for (int i = 0; i <= str.Length - 2; i++)
                {
                    if (str.Substring(i, 2) == "xx")
                    {
                        count++;
                    }
                }
            }
            else
            {
                return 0;
            }
            return count;
        }

        public bool DoubleX(string str)
        {
            int position = 0;
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str.Substring(i, 1) == "x")
                {
                    break;
                }
                position ++;
            }
            if (str.Substring(position+1, 1) == "x")
            {
                return true;
            }
            return false;
        }

        public string EveryOther(string str)
        {
            string newstr="";
            for (int i = 0; i < str.Length; i+=2)
            {
                newstr += str[i];
            }
            return newstr;
        }

        public string StringSplosion(string str)
        {
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newstr += str.Substring(0, i+1);
            }
            return newstr;
        }

        public int CountLast2(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i,1) == str.Substring(i+1, 1))
                {
                    count++;
                    i++;
                }
            }
            return count;
        }

        public int Count9(int[] numbers)
        {
            int numInt = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    numInt++;
                }
            }
            return numInt;
        }

        public bool ArrayFront9(int[] numbers)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (numbers[i] == 9)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] == 1) && (numbers[i+1] == 2) && (numbers[i+2] == 3))
                {
                    return true;
                }
            }
            return false;
        }

        public int SubStringMatch(string a, string b)
        {
            int loopCounter = a.Length;
            int count = 0;

            if (a.Length > b.Length)
            {
                loopCounter = b.Length;
            }
            for (int i = 0; i < loopCounter - 1; i++)
            {
                if (a.Substring(i,2) == b.Substring(i,2))
                {
                    count++;
                }
            }
            return count;
        }

        public string StringX(string str)
        {            
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str.Substring(i,1) == "x")
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }
            return str;
        }

        public string AltPairs(string str)
        {            
            for (int i = 2; i < str.Length; i+=2)
            {
                str = str.Remove(i, 2);
            }
            return str;
        }

        public string DoNotYak(string str)
        {
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i,3) == "yak")
                {
                    str = str.Remove(i, 3);
                    i -= 1;
                }
            }
            return str;
        }

        public int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                {
                    count++;
                }
            }
            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] == numbers[i+1]) && (numbers[i] == numbers[i+2]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 2 && numbers[i+1] == 7 && numbers[i+2] == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
