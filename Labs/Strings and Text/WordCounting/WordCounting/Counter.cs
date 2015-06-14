using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounting
{
    public class Counter
    {
        public int CountWords(string countThis)
        {
            int wordCount = 0;

            string[] split = countThis.Split(new Char[] { ' ', ',', '.', ':', '\t' });

            foreach (var w in split)
            {
                wordCount++;
            }

            return wordCount;
        }
    }
}
