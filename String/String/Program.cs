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

            Console.WriteLine("Hello, " + name  + " who " + action + " in the " + timezone + "?");

            
            name = "Dagmar";
            timezone = "CET";
            action = "lives";
            name = name.ToUpper();
            Console.WriteLine("Hello, " + name + " who " + action + " in the " + timezone + "?");

            

        }


    }
}
