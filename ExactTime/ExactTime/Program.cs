using System;

namespace ExactTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt_now = new DateTime();
            dt_now = DateTime.Now;

            Console.WriteLine("The exact date is: " + dt_now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

            Console.WriteLine("Please enter a number of hours to add to that date:");
            int dh = Convert.ToInt32(Console.ReadLine());

            DateTime dt_new = dt_now.AddHours(dh);

            Console.WriteLine("In " + dh + " hours the date will be: " + dt_new.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

        }
    }
}
