using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Logic.BLL
{
	public class LogicWarmups
	{        
		public bool GreatParty(int cigars, bool isWeekend)
		{
			return ((cigars >= 40 && isWeekend) || (cigars >= 40 && cigars <= 60 && !isWeekend));
		}

		public int CanHazTable(int yourStyle, int dateStyle)
		{
			int table = 1;

			if (yourStyle <= 2 || dateStyle <= 2)
			{
				table = 0;
			}

			if (yourStyle >= 8 || dateStyle >= 8)
			{
				table = 2;
			}
			return table;
		}

		public bool PlayOutside(int temp, bool isSummer)
		{
			return (temp >= 60 && temp <= 90 && !isSummer || temp >= 60 && temp <= 100 && isSummer);
		}

		public int CaughtSpeeding(int speed, bool isBirthday)
		{
			int ticket = 1;
			int trueSpeed = speed;

			if (isBirthday)
			{
				trueSpeed = speed - 5;
			}
			if (trueSpeed <= 60)
			{
				ticket = 0;
			}
			if (trueSpeed >= 81)
			{
				ticket = 2;
			}
			return ticket;
		}

		public int SkipSum(int a, int b)
		{
			int sum = a + b;
			if (sum >= 10 && sum <= 19)
			{
				sum = 20;
			}
			return sum;
		}

		public string AlarmClock(int day, bool vacation)
		{
			if (day > 0 && day < 6)
			{
				return !vacation ? "7:00" : "10:00";
			}
			else
			{
				return !vacation ? "10:00" : "off";
			}
		}

		public bool LoveSix(int a, int b)
		{
			return (a + b == 6 || a == 6 || b == 6);
		}

		public bool InRange(int n, bool outsideMode)
		{
			if (n > 0 && n < 11)
			{
				return true;
			}
			else
			{
				return (outsideMode);
			}
		}

		public bool SpecialEleven(int n)
		{
			return (n%11 == 0 || n%11 == 1);
		}

		public bool Mod20(int n)
		{
			return (n%20 == 1 || n%20 == 2);
		}

		public bool Mod35(int n)
		{
			return (n%3 == 0 && n%5 != 0 || n%3 != 0 && n%5 == 0);
		}

		public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
		{
			if (isMorning && !isMom || isAsleep)
			{
				return false;
			}
			return true;
		}

		public bool TwoIsOne(int a, int b, int c)
		{
			return (a + b == c || a + c == b || b + c == a);
		}

		public bool AreInOrder(int a, int b, int c, bool bOk)
		{
			return ((b > a || bOk) && c > b);
		}

		public bool InOrderEqual(int a, int b, int c, bool equalOk)
		{
			if (equalOk)
			{
				return a <= b && b <= c;
			}
			else
			{
				return a < b && b < c;
			}
		}

		public bool LastDigit(int a, int b, int c)
		{
			return (a%5 == b%5 || a%5 == c%5);
		}

		public int RollDice(int die1, int die2, bool noDoubles)
		{
			int sum = die1 + die2;
			if (die1 == die2 && noDoubles)
			{
				int n = die1 + 1;
				if (n == 7)
				{
					n = 1;
				}
				sum = n + die2;
			}                        
			return sum;
		}
	}
}
