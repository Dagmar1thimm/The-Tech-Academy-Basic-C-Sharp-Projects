using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Dagmar";
            string timezone = "CET";
            string action = "lives";

            Console.WriteLine("Hello, " + name + " who " + action + " in the " + timezone + "?");
            Console.ReadLine();

            name = "Dagmar";
            timezone = "CET";
            action = "lives";
            name = name.ToUpper();
            action = action.ToUpper();
            Console.WriteLine("Hello, " + name + " who " + action + " in the " + timezone + "?");
            Console.ReadLine();


        }


    }
}
