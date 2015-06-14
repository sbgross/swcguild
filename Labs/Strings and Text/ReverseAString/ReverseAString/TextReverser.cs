using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    public class TextReverser
    {
        public string Reverse(string original)
        {
            string reverse ="";

            for (int i = 1; i <= original.Length; i++)
            {
                reverse += original[original.Length - i];
            }
            return reverse;
        }
    }
}
