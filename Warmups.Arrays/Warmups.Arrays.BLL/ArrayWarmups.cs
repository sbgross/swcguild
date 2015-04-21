using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Arrays.BLL
{
    public class ArrayWarmups
    {
        public bool FirstLast6(int[] numbers)
        {
            bool firstLast6 = (numbers[0] == 6 || numbers[numbers.Length - 1] == 6);

            return firstLast6;
        }

        public bool SameFirstLast(int[] numbers)
        {
            return (numbers.Length >= 1 && numbers[0] == numbers[numbers.Length-1]);
        }

        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = (int) Math.Floor(pi);
                pi -= result[i];
                pi *= 10;
            }

            return result;

        }

        public bool CommonEnd(int[] a, int[] b)
        {
            return (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1]);
        }

        public int Sum(int[] numbers)
        {
            int totalArray = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                totalArray += numbers[i];
            }

            return totalArray;

        }

        public int[] RotateLeft(int[] numbers)
        {
            int[] rotated = new int[numbers.Length];
            rotated[0] = numbers[numbers.Length - 1];

            for (int i = 1; i < numbers.Length; i++)
            {
                rotated[i-1] = numbers[i];
            }

            rotated[numbers.Length - 1] = numbers[0];

            return rotated;
        }

        public int[] Reverse(int[] numbers)
        {
            Array.Reverse(numbers);
            return numbers;

        }

        public int[] HigherWins(int[] numbers)
        {
            int[] higherArray = new int[numbers.Length];
            int higher = numbers[numbers.Length - 1];
            if (numbers[0] > numbers[numbers.Length - 1] )
            {
                higher = numbers[0];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                higherArray[i] += higher;
            }
            return higherArray;

        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] middleArray = new int[2] { a[1], b[1] };

            return middleArray;
        }

        public bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] doubleArray = new int[numbers.Length*2];

            for (int i = 0; i < doubleArray.Length - 1; i++)
            {
                doubleArray[i] += 0;
            }
            doubleArray[doubleArray.Length - 1] = numbers[numbers.Length - 1];

            return doubleArray;
        }

        public bool Double23(int[] numbers)
        {
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    count2 ++;
                }
                if (numbers[i] == 3)
                {
                    count3 ++;
                }
            }

            if (count2 == 2 || count3 == 2)
            {
                return true;
            }

            return false;
        }

        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2 && numbers[i+1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }

            return numbers;
        }

        public bool Unlucky1(int[] numbers)
        {            
            if ((numbers[0] == 1 && numbers[1] == 3) ||
                (numbers[1] == 1 && numbers[2] == 3) ||
                (numbers[numbers.Length-2] == 1 && numbers[numbers.Length - 1] == 3))
            {
                return true;
            }           
            
            return false;
        }

        public int[] make2(int[] a, int[] b)
        {
            int[] newArray = new int[2];

            for (int i = 0; i < a.Length && i < newArray.Length; i++)
            {
                newArray[i] = a[i];
            }

            for (int j = a.Length; j < newArray.Length; j++)
            {
                newArray[j] = b[j - a.Length];
            }
            return newArray;
        }
    }
         
}
