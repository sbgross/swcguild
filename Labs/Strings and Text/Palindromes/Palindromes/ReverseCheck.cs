using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class ReverseCheck
    {
        public bool Reverse(string reverseThis)
        {
            bool palindrome = false;
            string reversed = "";

            reverseThis = reverseThis.Replace(" ","");

            for (int i = 1; i <= reverseThis.Length; i++)
            {
                reversed += reverseThis[reverseThis.Length - i];
            }
            if (reversed == reverseThis)
            {
                palindrome = true;
            }

            return palindrome;
        }
    }
}
