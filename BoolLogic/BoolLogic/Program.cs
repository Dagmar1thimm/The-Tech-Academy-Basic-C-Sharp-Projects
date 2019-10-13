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
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? true or false");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            

            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = 2;
            Console.WriteLine(speedTicket);
            int speedTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool isQualified = (Age > 15 && DUI == false && speedTicket <=3);
            Console.WriteLine(isQualified);
            Console.ReadLine();

        }
    }
}
