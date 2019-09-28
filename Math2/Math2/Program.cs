using System;

namespace Math2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person " + 1);

                Console.WriteLine("Hourly Rate?");
                int hourRatePerson1 = 30;
                Console.WriteLine(hourRatePerson1);

                Console.WriteLine("Hours worked per week?");
                int hourWeekPerson1 = 43;
                Console.WriteLine(hourWeekPerson1);

                Console.WriteLine("Weekly salary of Person " + 1 +":");
                int salaryWeekPerson1 = hourRatePerson1 * hourWeekPerson1;
                Console.WriteLine(salaryWeekPerson1);

            Console.WriteLine("Person " + 2);

                Console.WriteLine("Hourly Rate?");
                int hourRatePerson2 = 33;
                Console.WriteLine(hourRatePerson2);

                Console.WriteLine("Hours worked per week?");
                int hourWeekPerson2 = 42;
                Console.WriteLine(hourWeekPerson2);

                Console.WriteLine("Weekly salary of Person " + 2 + ":");
                int salaryWeekPerson2 = hourRatePerson2 * hourWeekPerson2;
                Console.WriteLine(salaryWeekPerson2);

            bool TrueOrFalse = salaryWeekPerson1 > salaryWeekPerson2;
            Console.WriteLine(TrueOrFalse);

        }
    }
}
