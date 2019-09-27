using System;

namespace DailyReport_drill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Acedemy");
        
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course you are on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number");
            string number = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string needHelp = Console.ReadLine();
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();

        }
    }
}
