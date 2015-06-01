using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AlarmClock
{
    class Program
    {
        private static System.Timers.Timer _aTimer;
        private static DateTime _alarmDate;
        private static DateTime _alarmTime;
        private static string _alarmMessage;
        private static DateTime _fullAlarm;
        static string answer;

        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Alarm Clock Program");
                Console.WriteLine("====================\n");

                Console.WriteLine("The current date and time is {0}", DateTime.Now.ToString("MM/dd/yy h:mm:ss tt"));

                string correct;
                
                do
                {
                    _alarmDate = UserPrompts.AlarmDate();
                    _alarmTime = UserPrompts.AlarmTime();

                    _fullAlarm = _alarmDate.Date + _alarmTime.TimeOfDay;

                    _alarmMessage = UserPrompts.AlarmMessage();

                    Console.Write("\nOn {0}, \"{1}\" will display on the console. \nIs this correct Y or N? ",
                        _fullAlarm, _alarmMessage);
                    correct = Console.ReadLine().ToUpper();                    
                    
                } while (correct == "N");

                StartTimer();
                
                var cancelOrQuit = UserPrompts.CancelOrQuit();

                if (cancelOrQuit == "C")
                {
                    Console.Clear();
                    continue;
                }

                if (cancelOrQuit == "Q")
                {
                    break;
                }                

            } while (true);
        }

        public static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            if (_fullAlarm <= DateTime.Now)
            {
                Console.WriteLine("\n\nAlarm time: {0}", e.SignalTime);
                Console.WriteLine("Message: {0}", _alarmMessage);
                Console.Write("\nPress enter to set another alarm.");
                _aTimer.Enabled = false;
                _aTimer.Close();                
                Console.ReadLine();
            }
        }

        public static void StartTimer()
        {
            _aTimer = new System.Timers.Timer(1000);
            _aTimer.Elapsed += (OnTimedEvent);

            _aTimer.Interval = 1000;
            _aTimer.Enabled = true;
        }        
    }
}
