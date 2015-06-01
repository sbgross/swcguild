using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class PrimeGenerator
    {
        public static int NextPrime(int number)
        {
            bool notPrime = true;
            int primeNumber = 0;
            
            int a = number + 1;
            
            for (int i = a; notPrime; i++)
            {
                int counter = 0;
                double b = Math.Sqrt(i);

                for (int j = 2; j <= b; j++)
                {                
                    if (i % j == 0)
                    {
                        counter++;
                    }                    
                }
                if (counter == 0)
                {
                    primeNumber = i;
                    notPrime = false;
                }                
            }

            return primeNumber;
        }
    }
}
