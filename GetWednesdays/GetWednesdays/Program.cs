using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWednesdays
{
    class Program
    {
        static void Main(string[] args)
        {            
            DateTime date = GetDateFromUser();
            int numberWednesdays = GetNumberWednesdays();

            List<DateTime> ListOfWednesdays = GetListOfWednesdays(date, numberWednesdays);

            PrintList(ListOfWednesdays);
            Console.ReadLine();
        }

        private static void PrintList(List<DateTime> ListOfWednesdays)
        {
            foreach (var d in ListOfWednesdays)
            {
                Console.WriteLine(d.ToString("d"));
            }
        }

        private static List<DateTime> GetListOfWednesdays(DateTime date, int numberWednesdays)
        {
            List<DateTime> ListOfWednesdays = new List<DateTime>();
            int counter = 0;

            while (counter < numberWednesdays)
            {
                date = date.AddDays(1);
                if (date.DayOfWeek == DayOfWeek.Wednesday)
                {
                    ListOfWednesdays.Add(date);
                    counter++;
                }                
            }

            return ListOfWednesdays;
        }

        private static int GetNumberWednesdays()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Please enter the number of subsequent Wednesdays: ");
                string answer = Console.ReadLine();

                if (int.TryParse(answer, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("That is not a valid number. Please re-enter.");
                }
            }  
        }

        private static DateTime GetDateFromUser()
        {
            DateTime date;
            while (true)
            {
                Console.WriteLine("Please enter a date: ");
                string answer = Console.ReadLine();
                
                if (DateTime.TryParse(answer, out date))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine("That is not a valid date. Please re-enter.");
                }
            }            
        }
    }
}
