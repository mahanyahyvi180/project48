using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTime = new Timer();
            myTime.SetTime(11, 34, 15);

            Console.Write("Use the DisplayTime extension method:");
            myTime.DisplayTime();

            Console.Write("Add 5 hour with the AddHours extention method:");

            var timeAdded = myTime.AddHours(5);
            timeAdded.DisplayTime();

            Console.Write("Add 15 hour with the AddHour extension method:");


            myTime.AddHours(15).DisplayTime();

       

            Console.Write("Use fully qualifield extension extension-method name:");
            TimeExtensions.DisplayTime(myTime);
            Console.ReadLine();

        }
    }
    static class TimeExtensions
    {
        public static void DisplayTime(this Timer aTime)
        {
            Console.WriteLine(aTime.ToString());
        }

        public static Timer AddHours(this Timer aTime, int hours)
        {
            var newTime = new Timer()
            {
                Minute = aTime.Minute,
                Second = aTime.Second
            };

            newTime.AddHours = (aTime.AddHours + hours) % 24;

            return newTime;
        }
    }

}





