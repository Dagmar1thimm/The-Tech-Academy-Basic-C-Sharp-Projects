using System;

namespace BoolLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int Age = 17;
            Console.WriteLine(Age);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            int DUI = 0;
            bool TrueOrFalse = DUI > 0;
            Console.WriteLine(TrueOrFalse);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = 2;
            Console.WriteLine(speedTicket);
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool isQualified = (Age > 15 && DUI == 0 && speedTicket <=3);
            Console.WriteLine(isQualified);
            Console.ReadLine();

        }
    }
}
