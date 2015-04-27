using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    class ColumnDecoder
    {
        internal int ColumnLetterToNumber(string xCoordinate)
        {
            Dictionary<string, int> ColumnDecode = new Dictionary<string, int>
            {
                {"A", 1},
                {"B", 2},
                {"C", 3},
                {"D", 4},
                {"E", 5},
                {"F", 6},
                {"G", 7},
                {"H", 8},
                {"I", 9},
                {"J", 10}
            };

            if (ColumnDecode.ContainsKey(xCoordinate))
            {
                int value = ColumnDecode[xCoordinate];
                return value;
            }
            else
            {
                return 0;
            }
        }
    }
}
