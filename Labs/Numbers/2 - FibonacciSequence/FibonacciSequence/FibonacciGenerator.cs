using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class FibonacciGenerator
    {
        public static int Execute(int f)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < f; i++)
            {
                int c = a + b;
                a = b;
                b = c;                
            }

            return a;
        }
    }
}
