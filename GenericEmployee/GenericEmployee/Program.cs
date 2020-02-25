using System;
using System.Collections.Generic;

namespace GenericEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourFN1 = "Sample";
            string yourLN1 = "Student";
            //int yourId1 = 1;

            GenericEmployee<List<string>> stringEmployee = new GenericEmployee<List<string>>();
            //stringEmployee.setEmployeeId(yourId1);
            stringEmployee.setFullName(yourFN1, yourLN1);



            List<string> myStringList = new List<string>() { "Flowers", "Seeds", "Pots", "Weed" };

            stringEmployee.things = myStringList;

            Console.WriteLine("myStringList contains:");
            foreach (var thing in myStringList)
            {
                Console.WriteLine(thing);
            }

            new List<string> () { "Flowers", "Seeds", "Pots", "Weed" };

            List<string> hisStuff = stringEmployee.things;

            stringEmployee.sayName();
            Console.WriteLine("This employee has these things:");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            foreach (var thing in stringEmployee.things)
            {
                Console.WriteLine(thing);
            }

            string yourFN2 = "Bob";
            string yourLN2 = "Myer";
            //int yourId2 = 2;

            GenericEmployee<List<int>> intEmployee = new GenericEmployee<List<int>>();
            //intEmployee.setEmployeeId(yourId2);
            intEmployee.setFullName(yourFN2, yourLN2);

            intEmployee.things = new List<int>() { 1, 5000, 99, -3 };

            List<int> hisNumbers = intEmployee.things;

            intEmployee.sayName();
            Console.WriteLine("This employee has these things:");
            foreach (var thing in hisNumbers)
            {
                Console.WriteLine(thing);
            }


            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
