using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLetterCombinations
{
    public class Combinations
    {
        public List<string> GenerateCombinations(string stringNumber)
        {
            List<string> combinationsList = new List<string>();

            Dictionary<int, char[]> PhonePadDecode = new Dictionary<int, char[]>()
            {
                {2, new[] {'A', 'B', 'C'}},
                {3, new[] {'D', 'E', 'F'}},
                {4, new[] {'G', 'H', 'I'}},
                {5, new[] {'J', 'K', 'L'}},
                {6, new[] {'M', 'N', 'O'}},
                {7, new[] {'P', 'Q', 'R', 'S'}},
                {8, new[] {'T', 'U', 'V'}},
                {9, new[] {'W', 'X', 'Y', 'Z'}}
            };

            int keyA = int.Parse(stringNumber.Substring(0, 1));
            int keyB = int.Parse(stringNumber.Substring(1, 1));

            char[] arrayA = PhonePadDecode[keyA];
            char[] arrayB = PhonePadDecode[keyB];


            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    string combinationsListtoadd = (arrayA[i].ToString() + arrayB[j].ToString());
                    combinationsList.Add(combinationsListtoadd);

                }
            }

            return combinationsList;
        }
    }
}
