using System;

namespace AgeTry
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            DateTime today = new DateTime();
            int age = 0;

            while (!ok)
            {
                Console.WriteLine("Please enter your age:");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something was wrong... sorry!");
                }
                if (age > 0) ok = true;
                else Console.WriteLine("Only positive numbers please...");
            }
            today = DateTime.Now;
            int birthyear = today.Year - age;
//            birthyear -= age;
            Console.WriteLine("You were born in the year: " + birthyear);
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
