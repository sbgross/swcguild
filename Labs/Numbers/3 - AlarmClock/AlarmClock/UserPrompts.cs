using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class UserPrompts
    {
        public static DateTime AlarmDate()
        {
            do
            {
                Console.Write("\nEnter alarm date (ex. 5/20/15): ");
                var userInput = Console.ReadLine();

                DateTime alarmDate;

                var validNumber = DateTime.TryParse(userInput, out alarmDate);

                if (validNumber && alarmDate >= DateTime.Today)
                {
                    return alarmDate;
                }

                Console.WriteLine("Date must be in a valid format and today or later.");

            } while (true);
        }

        public static DateTime AlarmTime()
        {
            do
            {
                Console.Write("Enter alarm time (ex. 3:15pm): ");
                var userInput = Console.ReadLine();

                DateTime alarmTime;

                var validNumber = DateTime.TryParse(userInput, out alarmTime);             

                if (validNumber)
                {
                    return alarmTime;
                }

            } while (true);
        }

        public static string AlarmMessage()
        {
            do
            {
                Console.Write("Enter alarm message: ");
                string alarmMessage = Console.ReadLine();

                var validMessage = string.IsNullOrEmpty(alarmMessage);

                if (!validMessage)
                {
                    return alarmMessage;
                }

            } while (true);
        }

        public static string CancelOrQuit()
        {
            Console.Clear();
            Console.Write("Alarm is set. \nPress \"C\" to cancel and set a new time or \"Q\" to quit the program.");
            var input = Console.ReadLine().ToUpper();

            return input;
        }
    }
}
