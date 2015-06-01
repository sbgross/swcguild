using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class MainMenu
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Fibonacci Sequence Generator");
                Console.WriteLine("============================\n");

                int term = UserPrompts.TermNumber();

                for (int i = 0; i < term; i++)
                {
                    Console.WriteLine(FibonacciGenerator.Execute(i));
                }
                            
                Console.Write("Would you like to run another sequence Y or N? ");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }

                Console.Clear();

            } while (true);
        }
    }
}
