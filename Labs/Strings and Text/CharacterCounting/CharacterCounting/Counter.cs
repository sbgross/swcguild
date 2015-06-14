using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounting
{
    public class Counter
    {
        public int CountVowels(string countThis)
        {
            int vowelCounter = 0;
            char[] vowels = {'a','e','i','o','u'};
            foreach (var c in countThis)
            {
                if (vowels.Contains(c))
                {
                    vowelCounter++;
                }                
            }
            return vowelCounter;
        }
    }
}
