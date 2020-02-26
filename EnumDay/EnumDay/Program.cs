using System;

namespace EnumDay
{
    class Program
    {
        enum WeekDays {Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };

        static void Main(string[] args)
        {

            WeekDays myDay;
            bool noValidDay = true;

            while (noValidDay)
            {
                try
                {
                    Console.WriteLine("Please enter the day of the week:");
                    myDay = (WeekDays)Enum.Parse(typeof(WeekDays), Console.ReadLine());
                    noValidDay = false;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an ACTUAL day of the week.");
                    noValidDay = true;
                }
            }
            Console.WriteLine("Have a nice day!" );
            Console.ReadLine();
        }
    }
}
