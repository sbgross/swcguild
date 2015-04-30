using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 101; i++)
            {
                string result = i + " ";
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }

                if (i % 5 == 0)
                {
                    result += "Buzz";
                }

                Console.WriteLine(result);             
            }
            Console.ReadLine();
        }
    }
}
