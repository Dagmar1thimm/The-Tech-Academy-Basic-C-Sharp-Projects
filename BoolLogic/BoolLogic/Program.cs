using System;

namespace BoolLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());


            if (age > 15)
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }

            Console.WriteLine("Have you ever had a DUI?");


            int DUI = Convert.ToInt32(Console.ReadLine());


            if (DUI == 0)
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }


            Console.WriteLine("How many speeding tickets do you have?");

            int speedticket = Convert.ToInt32(Console.ReadLine());


            if (speedticket <= 3)
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }

            Console.WriteLine("Qualified?");
            bool result = (true && true && true);
            Console.WriteLine(result);
            Console.ReadLine();
















            //Console.WriteLine("Qualified?");
            //bool isQualified = (age > 15 && DUI == false && speedTicket <=3);
            //Console.WriteLine(isQualified);
            //Console.ReadLine();

        }
    }
}

